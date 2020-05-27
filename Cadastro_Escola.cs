using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Foto_SanRemo
{
    public partial class Cadastro_Escola : Form
    {
        public Cadastro_Escola()
        {
            InitializeComponent();
        }

        public String Codigo;

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                
                String SQL;

                SQL = " INSERT INTO TblEscolas(Nome_Cliente,Diretora,Aniversario,Rua,Num,Bairro,Cidade,Telefone_Celular,Telefone_Fixo,Email,Instagram)";
                SQL += "Values ('"+Txt_Escola.Text+"','"+Txt_Diretora.Text+"','"+Txt_Niver.Text+"','"+Txt_Rua.Text+"','"+Txt_N.Text+"','"+Txt_Bairro.Text+"','"+Txt_Cidade.Text+"','"+Txt_Cel.Text+"','"+Txt_Fixo.Text+"','"+Txt_Email.Text+"','"+Txt_Insta.Text+"')";
               
                OleDbCommand cmd = new OleDbCommand(SQL,conn);
                
                DirectoryInfo pasta = new DirectoryInfo(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco");
                pasta.CreateSubdirectory(Txt_Escola.Text);

                MessageBox.Show("Cadastrado com sucesso !!!");

                Txt_Escola.Clear();
                Txt_Diretora.Clear();
                Txt_Niver.Clear();
                Txt_Rua.Clear();
                Txt_Bairro.Clear();
                Txt_N.Clear();
                Txt_Bairro.Clear();
                Txt_Cidade.Clear();
                Txt_Cel.Clear();
                Txt_Fixo.Clear();
                Txt_Email.Clear();
                Txt_Insta.Clear();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                String SQL = "Select * from TblEscolas";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "TblEscolas");

                DgResultado.DataSource = DS.Tables["TblEscolas"];
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                
                String SQL;

                SQL = " INSERT INTO TblEscolas(Nome_Cliente,Diretora,Aniversario,Rua,Num,Bairro,Cidade,Telefone_Celular,Telefone_Fixo,Email,Instagram)";
                SQL += "Values ('" + Txt_Escola.Text + "','" + Txt_Diretora.Text + "','" + Txt_Niver.Text + "','" + Txt_Rua.Text + "','" + Txt_N.Text + "','" + Txt_Bairro.Text + "','" + Txt_Cidade.Text + "','" + Txt_Cel.Text + "','" + Txt_Fixo.Text + "','" + Txt_Email.Text + "','" + Txt_Insta.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                DirectoryInfo pasta = new DirectoryInfo(@"C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco");
                pasta.CreateSubdirectory(Txt_Escola.Text);

                MessageBox.Show("Cadastrado com sucesso !!!");

                Txt_Escola.Clear();
                Txt_Diretora.Clear();
                Txt_Niver.Clear();
                Txt_Rua.Clear();
                Txt_Bairro.Clear();
                Txt_N.Clear();
                Txt_Bairro.Clear();
                Txt_Cidade.Clear();
                Txt_Cel.Clear();
                Txt_Fixo.Clear();
                Txt_Email.Clear();
                Txt_Insta.Clear();

                Lbl_Id.Text = (Convert.ToInt32(Lbl_Id.Text) + 1).ToString();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                String SQL;

                SQL = "update TblEscolas set Nome_Cliente = '" + Txt_Escola.Text + "',";
                SQL += "Diretora = '" + Txt_Diretora.Text + "',";
                SQL += "Aniversario = '" + Txt_Niver.Text + "',";
                SQL += "Rua = '" + Txt_Rua.Text + "',";
                SQL += "Num = '" + Txt_N.Text + "',";
                SQL += "Bairro = '" + Txt_Bairro.Text + "',";
                SQL += "Cidade = '" + Txt_Cidade.Text + "',";
                SQL += "Telefone_Celular = '" + Txt_Cel.Text + "',";
                SQL += "Telefone_Fixo = '" + Txt_Fixo.Text + "',";
                SQL += "Email = '" + Txt_Email.Text + "',";
                SQL += "Instagram = '" + Txt_Insta.Text + "' ";
                SQL += "Where idEscola = " + Codigo;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso !!!");

                Txt_Escola.Clear();
                Txt_Diretora.Clear();
                Txt_Niver.Clear();
                Txt_Rua.Clear();
                Txt_N.Clear();
                Txt_Bairro.Clear();
                Txt_Cidade.Clear();
                Txt_Cel.Clear();
                Txt_Fixo.Clear();
                Txt_Email.Clear();
                Txt_Insta.Clear();

                Button1.Visible = true;
                Btn_Alterar.Visible = false;

                TabCadastrar.TabPages["TabConsulta"].Show();

                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Codigo = DgResultado.SelectedCells[0].Value.ToString();
            Txt_Escola.Text = DgResultado.SelectedCells[1].Value.ToString();
            Txt_Diretora.Text = DgResultado.SelectedCells[2].Value.ToString();
            Txt_Niver.Text = DgResultado.SelectedCells[3].Value.ToString();
            Txt_Rua.Text = DgResultado.SelectedCells[4].Value.ToString();
            Txt_N.Text = DgResultado.SelectedCells[5].Value.ToString();
            Txt_Bairro.Text = DgResultado.SelectedCells[6].Value.ToString();
            Txt_Cidade.Text = DgResultado.SelectedCells[7].Value.ToString();
            Txt_Cel.Text = DgResultado.SelectedCells[8].Value.ToString();
            Txt_Fixo.Text = DgResultado.SelectedCells[9].Value.ToString();
            Txt_Email.Text = DgResultado.SelectedCells[10].Value.ToString();
            Txt_Insta.Text = DgResultado.SelectedCells[11].Value.ToString();

            Button1.Visible = false;
            Btn_Alterar.Visible = true;

            this.TabCadastrar.TabPages["tabPage1"].Show();

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                String cod = DgResultado.SelectedCells[0].Value.ToString();
                String SQL = "delete from TblEscolas Where idEscola = " + cod;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados apagados com sucesso");

                BtnConsultar_Click(sender, e);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void DgResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cadastro_Escola_Load(object sender, EventArgs e)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\Users\User\Source\Repos\Foto SanRemo\bin\Banco\BD_Escolas.accdb'";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                string query = "select * from TblEscolas";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idtxt = Convert.ToInt32(reader["idEscola"]);
                    Lbl_Id.Text = (idtxt + 1).ToString();
                }

               
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
    }
}
