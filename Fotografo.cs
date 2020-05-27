using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Foto_SanRemo
{
    public partial class Fotografo : Form
    {
        public Fotografo()
        {
            InitializeComponent();
        }

        public string arquivoExcel = "";

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                String SQL;

                SQL = " INSERT INTO TblFotografo(Nome,Email,Cel,Comissao)";
                SQL += "Values ('" + Txt_Fotografo.Text + "','" + Txt_Email.Text + "','" + Txt_Cel.Text + "','" + Txt_Comissao.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                DirectoryInfo pasta = new DirectoryInfo(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo");
                pasta.CreateSubdirectory(Txt_Fotografo.Text);

                MessageBox.Show("Cadastrado com sucesso !!!");

                Txt_Fotografo.Clear();
                Txt_Email.Clear();
                Txt_Comissao.Clear();
                Txt_Cel.Clear();

                cmd.ExecuteNonQuery();

                SQL = "Select * from TblFotografo";

                DataSet DS = new DataSet();

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);

                adapter.Fill(DS, "TblFotografo");

                Dg_Fotografos.DataSource = DS.Tables["TblFotografo"];

                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Fotografo_Load(object sender, EventArgs e)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                string query = "select * from TblFotografo";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cb_Fotografo.Items.Add(reader["Nome"].ToString());
                }

                DataSet DS = new DataSet();

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                adapter.Fill(DS, "TblFotografo");

                Dg_Fotografos.DataSource = DS.Tables["TblFotografo"];
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            try
            {
                string anoAtual = DateTime.Now.ToString("yyyy");
                arquivoExcel = @"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\Fotografo\" + Cb_Fotografo.Text + @"\" + Cb_Mes.Text + @"\"+ Cb_Mes.Text + anoAtual + ".xlsx";
                CarregaDadosExcel();

                var wb = new XLWorkbook(arquivoExcel);
                var ws = wb.Worksheet(1);

                int linha = Dg_tabela.Rows.Count + 1;
                int count = 4;
                float valor = 0;
                int ultvalor = 0;

                for (int i = 3; i < count; i++)
                {
                    if (!String.IsNullOrEmpty(ws.Cell("A" + i.ToString()).Value.ToString()))
                    {
                        count++;
                        valor += Convert.ToSingle(ws.Cell("F" + i.ToString()).Value);
                        ultvalor = i;
                    }
                }
                
                double comissao = valor * 0.025;
                
                // Retorna total e comissão
                ws.Cell("E" + (count - 1).ToString()).Value = "Total:";
                ws.Cell("F" + (count - 1).ToString()).Value = valor;
                ws.Cell("E" + count.ToString()).Value = "Comissão:";
                ws.Cell("F" + count.ToString()).Value = comissao;

                // Formatação da planilha
                ws.Range("A1:B1").Merge().Style.Font.SetBold().Font.FontSize = 11;
                ws.Range("D1:F1").Merge().Style.Font.SetBold().Font.FontSize = 11;
                ws.Range("F3:F" + ultvalor.ToString()).Style.NumberFormat.Format = "R$ #,#.##00";
                ws.Range("A2:F" + ultvalor + 2.ToString()).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range("E" + (ultvalor + 1).ToString() + ":F" + (ultvalor + 2).ToString()).Style
                    .Border.InsideBorder = XLBorderStyleValues.Medium;
                ws.Range("E" + (ultvalor + 1).ToString() + ":F" + (ultvalor + 2).ToString()).Style
                    .Border.InsideBorderColor = XLColor.BlizzardBlue;
                ws.Range("E" + (ultvalor + 1).ToString() + ":F" + (ultvalor + 2).ToString()).Style
                    .Border.OutsideBorder = XLBorderStyleValues.Medium;
                ws.Range("E" + (ultvalor + 1).ToString() + ":F" + (ultvalor + 2).ToString()).Style
                    .Border.OutsideBorderColor = XLColor.BlueBell;

                ws.Columns("1-6").AdjustToContents();
                wb.Save();
                wb.Dispose();

                CarregaDadosExcel();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void CarregaDadosExcel()
        {
            try
            {

                //converte os dados do Excel para um DataTable
                DataTable dt = GetTabelaExcel(arquivoExcel);

                //ajusta a largura das colunas aos dados
                Dg_tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Dg_tabela.DataSource = dt;

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

        private StringReader leitor;
        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            AbreVisualizadorPadrao(arquivoExcel);
            
        }

        private static void AbreVisualizadorPadrao(string caminho)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    Verb = "print",
                    FileName = caminho,
                },
            };
            process.Start();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
