using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using System.Globalization;

namespace Foto_SanRemo
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        public bool status = true;
        public int cont = 4;
        public string arquivoExcel = "";
        public string arquivoExcelFotografo = "";
        public string arquivoExcelRepresentante = "";
        public string statusAtual = "";
        public double valor = 0.00;
        public double aPagar = 0.00;
        public string valorAntigo = "";


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Confirma_Click(object sender, EventArgs e)
        {
            this.ControlBox = true;

            try
            {
                if (valor == Convert.ToInt32(value: Txt_Sinal.Text))
                {
                    DialogResult confirm = MessageBox.Show("Deseja fechar a nota?", "STATUS PEDIDO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        Txt_Status.Text = "Fechado";
                    }
                }

                    String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                String SQL = "Select * from TblEscolas";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "TblEscolas");

                //Txt_Escola.DataSource = SQL; Isso é um erro

                var wb = new XLWorkbook(arquivoExcel);
                var ws = wb.Worksheet(1);

                ws.Cell("B" + cont.ToString()).Value = "Total :";
                ws.Cell("C" + cont.ToString()).Value = Lbl_ValorTotal.Text.Replace("R$","");
                ws.Cell("D" + cont.ToString()).Value = "Sinal :";
                ws.Cell("E" + cont.ToString()).Value = Txt_Sinal.Text;
                ws.Cell("F" + cont.ToString()).Value = "A Pagar :";
                ws.Cell("G" + cont.ToString()).Value = Lbl_APagar.Text.Replace("R$", "");

                wb.Save();

                dgvDados.DataSource = null;

                
                if (Txt_Status.Text == "Fechado" && statusAtual == "Aberto")
                {
                    string sourceFile = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + Txt_Pedido.Text + ".xlsx";
                    string destinationFile = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + Txt_Escola.Text + @"\" + Txt_Pedido.Text + ".xlsx";

                    // To move a file or folder to a new location:
                    File.Move(sourceFile, destinationFile);
                }

                

                Btn_Gera.Visible = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            //----------Parte Destinada ao Fotografo-------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string format = Txt_Data.Text;
                string[] separa = format.Split('/');

                string day = separa[0];
                string mounth = separa[1];
                string year = separa[2];
                string year1 = DateTime.Today.Year.ToString();

                var mes = ExibirMesPorExtenso(new DateTime(2020, Convert.ToInt32(DateTime.Today.Month.ToString()), 1));

                //var mes = ExibirMesPorExtenso(new DateTime(Convert.ToInt32(year), Convert.ToInt32(mounth), Convert.ToInt32(day)));

                if (Txt_Status.Text == "Fechado")
                {
                    
                    try
                    {
                        
                        arquivoExcelFotografo = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Txt_Fotografo.Text + @"\" + mes + @"\" + mes + year1 + ".xlsx";
                        var wb = new XLWorkbook(arquivoExcelFotografo);
                        
                    }
                    catch (Exception)
                    {
                        // Cria uma pasta com o nome do mês e formata um excel para o fotografo
                        DirectoryInfo pasta = new DirectoryInfo(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Txt_Fotografo.Text);
                        pasta.CreateSubdirectory(mes);

                        var wb = new XLWorkbook();
                        var ws = wb.Worksheets.Add("Planilha 1");

                        // Título do Relatório
                        ws.Cell("A1").Value = Txt_Fotografo.Text;
                        
                        ws.Cell("C1").Value = mes;

                        // Cabeçalho do Relatório
                        ws.Cell("A2").Value = "N: ";
                        ws.Cell("B2").Value = "Data: ";
                        ws.Cell("C2").Value = "Pedido: ";
                        ws.Cell("D2").Value = "Escola: ";
                        ws.Cell("E2").Value = "Campanha: ";
                        ws.Cell("F2").Value = "Valor:";

                        wb.SaveAs(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Txt_Fotografo.Text + @"\" + mes + @"\" + mes + year1 + ".xlsx");
                        arquivoExcelFotografo = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Txt_Fotografo.Text + @"\" + mes + @"\" + mes + year1 + ".xlsx";
                        // Liberar objetos
                        wb.Dispose();
                    }

                    var wbb = new XLWorkbook(arquivoExcelFotografo);
                    var wss = wbb.Worksheet(1);

                    int num = 3;
                    string vazio = "NOK";
                    
                    while (!String.IsNullOrEmpty(vazio))
                    {
                        vazio = wss.Cell("A" + num.ToString()).Value.ToString();
                        
                        if (!String.IsNullOrEmpty(vazio))
                        {
                            num += 1;
                        }
                    }

                    wss.Cell("A" + num.ToString()).Value = (num-2).ToString();
                    wss.Cell("B" + num.ToString()).Value = Txt_Data.Text;
                    wss.Cell("C" + num.ToString()).Value = Txt_Pedido.Text;
                    wss.Cell("D" + num.ToString()).Value = Txt_Escola.Text;
                    wss.Cell("E" + num.ToString()).Value = Txt_Campanha.Text;
                    wss.Cell("F" + num.ToString()).Value = valor.ToString();

                    wbb.Save();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            //----------Parte Destinada ao Representante---------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string format = Txt_Data.Text;
                string[] separa = format.Split('/');

                string day = separa[0];
                string mounth = separa[1];
                string year = separa[2];
                string year1 = DateTime.Today.Year.ToString();

                var mes = ExibirMesPorExtenso(new DateTime(2020, Convert.ToInt32(DateTime.Today.Month.ToString()), 1));

                //var mes = ExibirMesPorExtenso(new DateTime(Convert.ToInt32(year), Convert.ToInt32(mounth), Convert.ToInt32(day)));

                if (Txt_Status.Text == "Fechado")
                {

                    try
                    {

                        arquivoExcelRepresentante = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Txt_Representante.Text + @"\" + mes + @"\" + mes + year1 + ".xlsx";
                        var wb = new XLWorkbook(arquivoExcelRepresentante);

                    }
                    catch (Exception)
                    {
                        // Cria uma pasta com o nome do mês e formata um excel para o fotografo
                        DirectoryInfo pasta = new DirectoryInfo(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Txt_Representante.Text);
                        pasta.CreateSubdirectory(mes);

                        var wb = new XLWorkbook();
                        var ws = wb.Worksheets.Add("Planilha 1");

                        // Título do Relatório
                        ws.Cell("A1").Value = Txt_Representante.Text;

                        ws.Cell("C1").Value = mes;

                        // Cabeçalho do Relatório
                        ws.Cell("A2").Value = "N: ";
                        ws.Cell("B2").Value = "Data: ";
                        ws.Cell("C2").Value = "Pedido: ";
                        ws.Cell("D2").Value = "Escola: ";
                        ws.Cell("E2").Value = "Campanha: ";
                        ws.Cell("F2").Value = "Valor:";

                        wb.SaveAs(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Txt_Representante.Text + @"\" + mes + @"\" + mes + year1 + ".xlsx");
                        arquivoExcelRepresentante = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Txt_Representante.Text + @"\" + mes + @"\" + mes + year1 + ".xlsx";
                        // Liberar objetos
                        wb.Dispose();
                    }

                    var wbb = new XLWorkbook(arquivoExcelRepresentante);
                    var wss = wbb.Worksheet(1);

                    int num = 3;
                    string vazio = "NOK";

                    while (!String.IsNullOrEmpty(vazio))
                    {
                        vazio = wss.Cell("A" + num.ToString()).Value.ToString();

                        if (!String.IsNullOrEmpty(vazio))
                        {
                            num += 1;
                        }
                    }

                    wss.Cell("A" + num.ToString()).Value = (num - 2).ToString();
                    wss.Cell("B" + num.ToString()).Value = Txt_Data.Text;
                    wss.Cell("C" + num.ToString()).Value = Txt_Pedido.Text;
                    wss.Cell("D" + num.ToString()).Value = Txt_Escola.Text;
                    wss.Cell("E" + num.ToString()).Value = Txt_Campanha.Text;
                    wss.Cell("F" + num.ToString()).Value = valor.ToString();

                    wbb.Save();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            Btn_Adicionar.Visible = false;
            Btn_Confirma.Visible = false;

            Txt_Pedido.Text = "";
            Txt_Escola.Text = "";
            Txt_Status.Text = "Aberto";
            Txt_Representante.Text = "";
            Txt_Fotografo.Text = "";
            Txt_Campanha.Text = "";
            Txt_Data.Text = "";

            valor = 0;
            Lbl_ValorTotal.Text = "0";
            aPagar = 0;
            Lbl_APagar.Text = "0";
            Txt_Sinal.Text = "0";
            valorAntigo = "";
        }

        private void Btn_Gera_Click(object sender, EventArgs e)
        {
            statusAtual = Txt_Status.Text;

            this.ControlBox = false;

            if (String.IsNullOrEmpty(Txt_Pedido.Text) ||
                String.IsNullOrEmpty(Txt_Status.Text) ||
                String.IsNullOrEmpty(Txt_Escola.Text) ||
                String.IsNullOrEmpty(Txt_Campanha.Text) ||
                String.IsNullOrEmpty(Txt_Fotografo.Text) ||
                String.IsNullOrEmpty(Txt_Representante.Text) ||
                String.IsNullOrEmpty(Txt_Data.Text))
            {
                MessageBox.Show("Preencha todos os campos para abrir o pedido.");
            }
            else
            {
                try
                {
                    String status = Txt_Status.Text;

                    try
                    {
                        if (status == "Aberto")
                        {
                            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + Txt_Pedido.Text + ".xlsx";
                            var wb = new XLWorkbook(arquivoExcel);
                            wb.Dispose();
                            CarregaDadosExcel();
                        }
                        if (status == "Fechado")
                        {
                            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + Txt_Escola.Text + @"\" + Txt_Pedido.Text + ".xlsx";
                            var wb = new XLWorkbook(arquivoExcel);
                            wb.Dispose();
                            CarregaDadosExcel();
                        }

                        var wbb = new XLWorkbook(arquivoExcel);
                        var wss = wbb.Worksheet(1);

                        int linha = dgvDados.Rows.Count;
                        
                        valor = Convert.ToDouble(wss.Cell("C" + linha.ToString()).Value);
                        aPagar = Convert.ToDouble(wss.Cell("G" + linha.ToString()).Value);

                        Lbl_ValorTotal.Text = "R$ " + valor.ToString();
                        Lbl_APagar.Text = "R$ " + aPagar.ToString();
                        Txt_Sinal.Text = wss.Cell("E" + linha.ToString()).Value.ToString();

                        cont = dgvDados.Rows.Count;

                    }
                    catch (Exception)
                    {

                        var wb = new XLWorkbook();
                        var ws = wb.Worksheets.Add("Planilha 1");

                        // Título do Relatório
                        ws.Range("A1", "C1").Merge();
                        ws.Range("E1", "F1").Merge();
                        ws.Range("J1", "K1").Merge();

                        ws.Cell("A1").Value = Txt_Escola.Text;
                        ws.Cell("D1").Value = "Fotógrafo: ";
                        ws.Cell("E1").Value = Txt_Fotografo.Text;
                        ws.Cell("G1").Value = "Campanha: ";
                        ws.Cell("H1").Value = Txt_Campanha.Text;
                        ws.Cell("I1").Value = "Representante: ";
                        ws.Cell("J1").Value = Txt_Representante.Text;
                        ws.Cell("L1").Value = "Data: ";
                        ws.Cell("M1").Value = Txt_Data.Text;

                        // Cabeçalho do Relatório
                        ws.Cell("A2").Value = "N:";
                        ws.Cell("B2").Value = "Aluno:";
                        ws.Cell("C2").Value = "Quant.:";
                        ws.Cell("D2").Value = "Produto 1:";
                        ws.Cell("E2").Value = "Quant.:";
                        ws.Cell("F2").Value = "Produto 2:";
                        ws.Cell("G2").Value = "Quant.:";
                        ws.Cell("H2").Value = "Produto 3:";
                        ws.Cell("I2").Value = "Quant.:";
                        ws.Cell("J2").Value = "Produto 4:";
                        ws.Cell("K2").Value = "Quant.:";
                        ws.Cell("L2").Value = "Produto 5:";
                        ws.Cell("M2").Value = "Valor:";

                        ws.Columns("1-11").AdjustToContents();

                        if (status == "Aberto")
                        {

                            // Salvar o arquivo em Disco

                            wb.SaveAs(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + Txt_Pedido.Text + ".xlsx");
                            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + Txt_Pedido.Text + ".xlsx";
                            // Liberar objetos
                            wb.Dispose();

                            MessageBox.Show("Documento gerado com sucesso.");

                        }
                        else
                        {
                            wb.SaveAs(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + Txt_Escola.Text + @"\" + Txt_Pedido.Text + ".xlsx");
                            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + Txt_Escola.Text + @"\" + Txt_Pedido.Text + ".xlsx";

                            wb.Dispose();

                            MessageBox.Show("Documento gerado com sucesso.");
                        }

                        CarregaDadosExcel();

                        MessageBox.Show("Não era para aparecer");
                        cont = dgvDados.Rows.Count + 1;

                    }

                    Btn_Gera.Visible = false;
                    Btn_Adicionar.Visible = true;
                    Btn_Confirma.Visible = true;
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String status = Txt_Status.Text;

            if (String.IsNullOrEmpty(Txt_Aluno.Text) || String.IsNullOrEmpty(Txt_Valor.Text))
            {
                MessageBox.Show("O campo aluno e valor precisa ser preenchido.");
            }
            else if (!String.IsNullOrEmpty(Txt_Produto1.Text) && Txt_Quant1.Value == 0 ||
                !String.IsNullOrEmpty(Txt_Produto2.Text) && Txt_Quant2.Value == 0 ||
                !String.IsNullOrEmpty(Txt_Produto3.Text) && Txt_Quant3.Value == 0 ||
                !String.IsNullOrEmpty(Txt_Produto4.Text) && Txt_Quant4.Value == 0 ||
                !String.IsNullOrEmpty(Txt_Produto5.Text) && Txt_Quant5.Value == 0)
            {
                MessageBox.Show("Você precisa identificar quantos produtos foram pedidos.");
            }
            else
            {
                try
                {
                    var wb = new XLWorkbook(arquivoExcel);
                    var ws = wb.Worksheet(1);


                    ws.Cell("A" + cont.ToString()).Value = (cont - 2).ToString();
                    ws.Cell("B" + cont.ToString()).Value = Txt_Aluno.Text;
                    ws.Cell("C" + cont.ToString()).Value = Txt_Quant1.Text;
                    ws.Cell("D" + cont.ToString()).Value = Txt_Produto1.Text;
                    ws.Cell("E" + cont.ToString()).Value = Txt_Quant2.Text;
                    ws.Cell("F" + cont.ToString()).Value = Txt_Produto2.Text;
                    ws.Cell("G" + cont.ToString()).Value = Txt_Quant3.Text;
                    ws.Cell("H" + cont.ToString()).Value = Txt_Produto3.Text;
                    ws.Cell("I" + cont.ToString()).Value = Txt_Quant4.Text;
                    ws.Cell("J" + cont.ToString()).Value = Txt_Produto4.Text;
                    ws.Cell("K" + cont.ToString()).Value = Txt_Quant5.Text;
                    ws.Cell("L" + cont.ToString()).Value = Txt_Produto5.Text;
                    ws.Cell("M" + cont.ToString()).Value = Txt_Valor.Text.Replace(",",".");

                    wb.Save();
                    cont++;

                    Txt_Aluno.Clear();
                    Txt_Produto1.Clear();
                    Txt_Produto2.Clear();
                    Txt_Produto3.Clear();
                    Txt_Produto4.Clear();
                    Txt_Produto5.Clear();
                    Txt_Quant1.Value = 0;
                    Txt_Quant2.Value = 0;
                    Txt_Quant3.Value = 0;
                    Txt_Quant4.Value = 0;
                    Txt_Quant5.Value = 0;

                    CarregaDadosExcel();

                    if (Btn_Adicionar.Text == "Editar")
                    {
                        
                        valor = valor - Convert.ToDouble(valorAntigo.Replace(".",""));
                            
                        cont = dgvDados.Rows.Count + 1;
                        Num_Linha.Value = 1;
                        Btn_Adicionar.Text = "Adicionar";
                    }

                    valor = valor + Convert.ToDouble(Txt_Valor.Text);
                    aPagar = valor - Convert.ToDouble(Txt_Sinal.Text);

                    int quant = valor.ToString().Length;

                    Txt_Valor.Clear();

                    Lbl_ValorTotal.Text = "R$ " + valor.ToString();
                    Lbl_APagar.Text = "R$ " + aPagar.ToString();

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }
            }
            
            
        }

        private void GeraPedido(
            string txtPedido, 
            string txtStatus, 
            string txtEscola, 
            string txtCampanha,
            string txtFotografo,
            string txtRepresentante,
            string txtData,
            string tipo)
        {
            statusAtual = txtStatus;

            if (String.IsNullOrEmpty(txtPedido) ||
                String.IsNullOrEmpty(txtStatus) ||
                String.IsNullOrEmpty(txtEscola) ||
                String.IsNullOrEmpty(txtCampanha) ||
                String.IsNullOrEmpty(txtFotografo) ||
                String.IsNullOrEmpty(txtRepresentante) ||
                String.IsNullOrEmpty(txtData))
            {
                MessageBox.Show("Preencha todos os campos para abrir o pedido.");
            }
            else
            {
                try
                {
                    String status = txtStatus;

                    try
                    {
                        if (status == "Aberto")
                        {
                            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + txtPedido + ".xlsx";
                            var wb = new XLWorkbook(arquivoExcel);
                            wb.Dispose();
                            CarregaDadosExcel();
                        }
                        if (status == "Fechado")
                        {
                            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + txtEscola + @"\" + txtPedido + ".xlsx";
                            var wb = new XLWorkbook(arquivoExcel);
                            wb.Dispose();
                            CarregaDadosExcel();
                        }

                        var wbb = new XLWorkbook(arquivoExcel);
                        var wss = wbb.Worksheet(1);

                        if (tipo == "Picadinho")
                        {
                            int linha = dgvDados3.Rows.Count;
                            int quant = Txt_Valor.Text.Length;

                            valor = Convert.ToDouble(wss.Cell("C" + linha.ToString()).Value);
                            aPagar = Convert.ToDouble(wss.Cell("G" + linha.ToString()).Value);

                            Lbl_ValorTotal2.Text = "R$ " + valor.ToString().Insert(quant - 2, ".");
                            Lbl_APagar2.Text = "R$ " + aPagar.ToString().Insert(quant - 2, ".");
                            Txt_Sinal2.Text = wss.Cell("E" + linha.ToString()).Value.ToString();

                            cont = dgvDados.Rows.Count;
                        }
                        else
                        {
                            int linha = dgvDados.Rows.Count;
                            int quant = Txt_Valor.Text.Length;

                            valor = Convert.ToDouble(wss.Cell("C" + linha.ToString()).Value);
                            aPagar = Convert.ToDouble(wss.Cell("G" + linha.ToString()).Value);

                            Lbl_ValorTotal.Text = "R$ " + valor.ToString().Insert(quant - 2,".") ;
                            Lbl_APagar.Text = "R$ " + aPagar.ToString().Insert(quant - 2, ".");
                            
                            Txt_Sinal.Text = wss.Cell("E" + linha.ToString()).Value.ToString();

                            cont = dgvDados.Rows.Count;
                        }
                        

                    }
                    catch (Exception)
                    {

                        var wb = new XLWorkbook();
                        var ws = wb.Worksheets.Add("Planilha 1");

                        // Título do Relatório
                        ws.Range("A1", "C1").Merge();
                        ws.Range("E1", "F1").Merge();
                        ws.Range("J1", "K1").Merge();

                        ws.Cell("A1").Value = txtEscola;
                        ws.Cell("D1").Value = "Fotógrafo: ";
                        ws.Cell("E1").Value = txtFotografo;
                        ws.Cell("G1").Value = "Campanha: ";
                        ws.Cell("H1").Value = txtCampanha;
                        ws.Cell("I1").Value = "Representante: ";
                        ws.Cell("J1").Value = txtRepresentante;
                        ws.Cell("L1").Value = "Data: ";
                        ws.Cell("M1").Value = txtData;

                        // Cabeçalho do Relatório
                        ws.Cell("A2").Value = "N:";
                        ws.Cell("B2").Value = "Aluno:";
                        ws.Cell("C2").Value = "Quant.:";
                        ws.Cell("D2").Value = "Produto 1:";
                        ws.Cell("E2").Value = "Quant.:";
                        ws.Cell("F2").Value = "Produto 2:";
                        ws.Cell("G2").Value = "Quant.:";
                        ws.Cell("H2").Value = "Produto 3:";
                        ws.Cell("I2").Value = "Quant.:";
                        ws.Cell("J2").Value = "Produto 4:";
                        ws.Cell("K2").Value = "Quant.:";
                        ws.Cell("L2").Value = "Produto 5:";
                        ws.Cell("M2").Value = "Valor:";

                        ws.Columns("1-11").AdjustToContents();

                        if (status == "Aberto")
                        {

                            // Salvar o arquivo em Disco

                            wb.SaveAs(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + txtPedido + ".xlsx");
                            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + txtPedido + ".xlsx";
                            // Liberar objetos
                            wb.Dispose();

                            MessageBox.Show("Documento gerado com sucesso.");

                        }
                        else
                        {
                            wb.SaveAs(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + txtEscola + @"\" + txtPedido + ".xlsx");
                            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + txtEscola + @"\" + txtPedido + ".xlsx";

                            wb.Dispose();

                            MessageBox.Show("Documento gerado com sucesso.");
                        }

                        CarregaDadosExcel();
                        if (tipo == "Picadinho")
                        {
                            cont = dgvDados3.Rows.Count + 1;
                        }
                        else
                        {
                            cont = dgvDados.Rows.Count + 1;
                        }
                        

                    }

                    if (tipo == "Picadinho")
                    {
                        Btn_picadinho.Visible = false;
                        Btn_Adicionar2.Visible = true;
                        Btn_Confirma2.Visible = true;
                    }
                    else
                    {
                        Btn_Gera.Visible = false;
                        Btn_Adicionar.Visible = true;
                        Btn_Confirma.Visible = true;
                    }
                    
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void CarregaDadosExcel()
        {
            try
            {

                //converte os dados do Excel para um DataTable
                DataTable dt = GetTabelaExcel(arquivoExcel);

                //ajusta a largura das colunas aos dados
                dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDados.DataSource = dt;

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void CarregaDadosExcel2()
        {
            try
            {

                //converte os dados do Excel para um DataTable
                DataTable dt = GetTabelaExcel(arquivoExcel);

                //ajusta a largura das colunas aos dados
                dgvDados2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDados2.DataSource = dt;

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private DataTable GetTabelaExcel(string arquivoExcel)
        {
            DataTable dt = new DataTable();
            try
            {
                //pega a extensão do arquivo
                string Ext = Path.GetExtension(arquivoExcel);
                string connectionString = "";
                //verifica a versão do Excel pela extensão
                if (Ext == ".xls")
                { //para o  Excel 97-03    
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                { //para o  Excel 07 e superior
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                //le todos os dados da planilha para o Data Table    
                conn.Open();
                cmd.CommandText = "SELECT * From [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        private void Btn_Seleciona_Click(object sender, EventArgs e)
        {
            try
            {
                cont = Convert.ToInt32(Num_Linha.Value + 2);
                Btn_Adicionar.Text = "Editar";

                var wb = new XLWorkbook(arquivoExcel);
                var ws = wb.Worksheet(1);

                Txt_Aluno.Text = ws.Cell("B" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value.ToString();
                Txt_Quant1.Value = Convert.ToInt32(ws.Cell("C" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value);
                Txt_Produto1.Text = ws.Cell("D" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value.ToString();
                Txt_Quant2.Value = Convert.ToInt32(ws.Cell("E" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value);
                Txt_Produto2.Text = ws.Cell("F" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value.ToString();
                Txt_Quant3.Value = Convert.ToInt32(ws.Cell("G" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value);
                Txt_Produto3.Text = ws.Cell("H" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value.ToString();
                Txt_Quant4.Value = Convert.ToInt32(ws.Cell("I" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value);
                Txt_Produto4.Text = ws.Cell("J" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value.ToString();
                Txt_Quant5.Value = Convert.ToInt32(ws.Cell("K" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value);
                Txt_Produto5.Text = ws.Cell("L" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value.ToString();
                Txt_Valor.Text = ws.Cell("M" + Convert.ToInt32(Num_Linha.Value + 2).ToString()).Value.ToString();
                
                valorAntigo = Txt_Valor.Text;
            }
            catch (Exception)
            {

                
            }
            
        }

        private void Cb_Escolas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            Txt_Valor.TextAlign = HorizontalAlignment.Right;

            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                string query = "select * from TblEscolas";
                string SQL = "select * from TblFotografo";
                string representante = "select * from TblRepresentante";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Txt_Escola.Items.Add(reader["Nome_Cliente"].ToString());
                }

                command.CommandText = SQL;
                reader.Close();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Txt_Fotografo.Items.Add(reader["Nome"].ToString());
                }

                command.CommandText = representante;
                reader.Close();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Txt_Representante.Items.Add(reader["Nome"].ToString());
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Txt_Pedido_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var wb = new XLWorkbook(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + Txt_Pedido.Text + ".xlsx");
                var ws = wb.Worksheet(1);

                Txt_Escola.Text = ws.Cell("A1").Value.ToString();
                Txt_Fotografo.Text = ws.Cell("E1").Value.ToString();
                Txt_Campanha.Text = ws.Cell("H1").Value.ToString();
                Txt_Representante.Text = ws.Cell("J1").Value.ToString();
                Txt_Data.Text = ws.Cell("M1").Value.ToString();
                Txt_Status.Text = "Aberto";
                

            }
            catch (Exception)
            {
                
                try
                {
                    var wb = new XLWorkbook(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + Txt_Escola.Text + @"\" + Txt_Pedido.Text + ".xlsx");
                    var ws = wb.Worksheet(1);

                    Txt_Escola.Text = ws.Cell("A1").Value.ToString();
                    Txt_Fotografo.Text = ws.Cell("E1").Value.ToString();
                    Txt_Campanha.Text = ws.Cell("H1").Value.ToString();
                    Txt_Representante.Text = ws.Cell("J1").Value.ToString();
                    Txt_Data.Text = ws.Cell("M1").Value.ToString();
                    Txt_Status.Text = "Fechado";
                }
                catch (Exception)
                {
                    
                    Txt_Fotografo.Text = "";
                    Txt_Campanha.Text = "";
                    Txt_Representante.Text = "";
                    Txt_Data.Text = "";
                }
            }
        }

        private void Txt_Sinal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txtvalor = Txt_Valor.Text;
                int quant = txtvalor.Length;

                if (quant < 3)
                {
                    status = false;
                }
                else
                {
                    if ((status && quant != 2) || quant == 3)
                    {
                        status = false;
                        if (quant == 3)
                        {
                            string newvalue1 = txtvalor.Replace(",", "");
                            if (newvalue1.Length > 2)
                            {
                                Txt_Valor.Text = newvalue1.Insert((quant - 2), ",");
                            }
                        }
                        string newvalue = txtvalor.Replace(",", "");
                        Txt_Valor.Text = newvalue.Insert((quant - 3), ",");

                    }
                    else
                    {
                        status = true;
                    }

                }
                Txt_Valor.TextAlign = HorizontalAlignment.Right;
                Txt_Valor.Select(quant, 0);
            }
            catch (Exception)
            {


            }

            try
            {
                double sinal = Convert.ToDouble(Txt_Sinal.Text);

                aPagar = valor - sinal;

                Lbl_APagar.Text = aPagar.ToString();
            }
            catch (Exception)
            {
                Lbl_APagar.Text = valor.ToString();
            }
            

            
        }

        public static string ExibirMesPorExtenso(DateTime data)
        {
            return data.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br"));
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                List_Conculta.Items.Clear();
                List_Consulta2.Items.Clear();

                if (Cb_Status.Text == "Aberto")
                {
                    dgvDados2.Width = 658;
                    dgvDados2.Location = new Point(132, 39);
                    List_Consulta2.Visible = false;

                    string pasta = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto";

                    DirectoryInfo directory = new DirectoryInfo(pasta);
                    FileInfo[] arquivos = directory.GetFiles("*", SearchOption.TopDirectoryOnly);

                    foreach (var fil in arquivos)
                    {
                        List_Conculta.Items.Add(fil.Name);
                    }
                }
                else
                {
                    List_Consulta2.Visible = true;
                    dgvDados2.Width = 532;
                    dgvDados2.Location = new Point(258, 39);
                    
                    string pasta = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco";
                    DirectoryInfo directory = new DirectoryInfo(pasta);
                    DirectoryInfo[] diretorios = directory.GetDirectories("*", SearchOption.TopDirectoryOnly);

                    foreach (var dir in diretorios)
                    {
                        List_Conculta.Items.Add(dir.Name);
                    }
                }
                
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            


        }

        private void List_Conculta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List_Consulta2.Items.Clear();

                if (Cb_Status.Text == "Aberto")
                {
                    arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + List_Conculta.SelectedItem.ToString();
                    CarregaDadosExcel2();
                }
                else
                {
                    arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + List_Conculta.SelectedItem.ToString();

                    DirectoryInfo directory = new DirectoryInfo(arquivoExcel);
                    FileInfo[] arquivos = directory.GetFiles("*", SearchOption.TopDirectoryOnly);

                    foreach (var fil in arquivos)
                    {
                        List_Consulta2.Items.Add(fil.Name);
                    }
                }
                
            }
            catch (Exception erro)
            {
                
                MessageBox.Show(erro.Message);
            }
        }

        private void List_Consulta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + List_Conculta.SelectedItem.ToString() + @"\" + List_Consulta2.SelectedItem.ToString();
            CarregaDadosExcel2();
        }

        private void Btn_picadinho_Click(object sender, EventArgs e)
        {
            string pedido = Txt_Pedido2.Text + "Pic";
            string tipo = "Picadinho";

            GeraPedido(
                pedido,
                Txt_Status2.Text,
                Txt_Escola2.Text,
                Txt_Campanha2.Text,
                Txt_Fotografo2.Text,
                Txt_Representante2.Text,
                Txt_Data2.Text,
                tipo);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Produtos chamaProduto = new Produtos();
            chamaProduto.ShowDialog();

            chamaProduto.ShowDialog();
            
        }

        private void Txt_Pedido2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var wb = new XLWorkbook(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Pedido\Aberto\" + Txt_Pedido2.Text + ".xlsx");
                var ws = wb.Worksheet(1);

                Txt_Escola2.Text = ws.Cell("A1").Value.ToString();
                Txt_Fotografo2.Text = ws.Cell("E1").Value.ToString();
                Txt_Campanha2.Text = ws.Cell("H1").Value.ToString();
                Txt_Representante2.Text = ws.Cell("J1").Value.ToString();
                Txt_Data2.Text = ws.Cell("M1").Value.ToString();
                Txt_Status2.Text = "Aberto";


            }
            catch (Exception)
            {

                try
                {
                    var wb = new XLWorkbook(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\" + Txt_Escola2.Text + @"\" + Txt_Pedido2.Text + ".xlsx");
                    var ws = wb.Worksheet(1);

                    Txt_Escola2.Text = ws.Cell("A1").Value.ToString();
                    Txt_Fotografo2.Text = ws.Cell("E1").Value.ToString();
                    Txt_Campanha2.Text = ws.Cell("H1").Value.ToString();
                    Txt_Representante2.Text = ws.Cell("J1").Value.ToString();
                    Txt_Data2.Text = ws.Cell("M1").Value.ToString();
                    Txt_Status2.Text = "Fechado";
                }
                catch (Exception)
                {

                    Txt_Fotografo2.Text = "";
                    Txt_Campanha2.Text = "";
                    Txt_Representante2.Text = "";
                    Txt_Data2.Text = "";
                }
            }
        }

        private void Txt_Valor_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string txtvalor = Txt_Valor.Text;
                int quant = txtvalor.Length;

                if (quant < 3)
                {
                    status = false;
                }
                else
                {
                    if ((status && quant != 2) || quant == 3)
                    {
                        status = false;
                        if (quant == 3)
                        {
                            string newvalue1 = txtvalor.Replace(",", "");
                            if (newvalue1.Length > 2)
                            {
                                Txt_Valor.Text = newvalue1.Insert((quant - 2), ",");
                            }
                        }
                        string newvalue = txtvalor.Replace(",", "");
                        Txt_Valor.Text = newvalue.Insert((quant - 3), ",");

                    }
                    else
                    {
                        status = true;
                    }

                }
                Txt_Valor.TextAlign = HorizontalAlignment.Right;
                Txt_Valor.Select(Txt_Valor.Text.Length, 0);
            }
            catch (Exception)
            {

                
            }
            


        }
    }
}
