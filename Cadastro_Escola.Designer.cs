namespace Foto_SanRemo
{
    partial class Cadastro_Escola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabCadastrar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Txt_Fixo = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Cel = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Niver = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Txt_Insta = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Diretora = new System.Windows.Forms.TextBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_N = new System.Windows.Forms.TextBox();
            this.Txt_Rua = new System.Windows.Forms.TextBox();
            this.Txt_Escola = new System.Windows.Forms.TextBox();
            this.TabConsulta = new System.Windows.Forms.TabPage();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.DgResultado = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.TabCadastrar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // TabCadastrar
            // 
            this.TabCadastrar.Controls.Add(this.tabPage1);
            this.TabCadastrar.Controls.Add(this.TabConsulta);
            this.TabCadastrar.Location = new System.Drawing.Point(0, 0);
            this.TabCadastrar.Name = "TabCadastrar";
            this.TabCadastrar.SelectedIndex = 0;
            this.TabCadastrar.Size = new System.Drawing.Size(801, 448);
            this.TabCadastrar.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.Txt_Fixo);
            this.tabPage1.Controls.Add(this.Txt_Cel);
            this.tabPage1.Controls.Add(this.Txt_Niver);
            this.tabPage1.Controls.Add(this.Lbl_Id);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.Btn_Alterar);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.Label11);
            this.tabPage1.Controls.Add(this.Label10);
            this.tabPage1.Controls.Add(this.Label9);
            this.tabPage1.Controls.Add(this.Label8);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Controls.Add(this.Label6);
            this.tabPage1.Controls.Add(this.Label5);
            this.tabPage1.Controls.Add(this.Label4);
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Controls.Add(this.Label2);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.Button1);
            this.tabPage1.Controls.Add(this.Txt_Insta);
            this.tabPage1.Controls.Add(this.Txt_Email);
            this.tabPage1.Controls.Add(this.Txt_Diretora);
            this.tabPage1.Controls.Add(this.Txt_Cidade);
            this.tabPage1.Controls.Add(this.Txt_Bairro);
            this.tabPage1.Controls.Add(this.Txt_N);
            this.tabPage1.Controls.Add(this.Txt_Rua);
            this.tabPage1.Controls.Add(this.Txt_Escola);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // Txt_Fixo
            // 
            this.Txt_Fixo.Location = new System.Drawing.Point(652, 209);
            this.Txt_Fixo.Mask = "(99) 0000-0000";
            this.Txt_Fixo.Name = "Txt_Fixo";
            this.Txt_Fixo.Size = new System.Drawing.Size(113, 20);
            this.Txt_Fixo.TabIndex = 68;
            this.Txt_Fixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Cel
            // 
            this.Txt_Cel.Location = new System.Drawing.Point(491, 209);
            this.Txt_Cel.Mask = "(99) 00000-0000";
            this.Txt_Cel.Name = "Txt_Cel";
            this.Txt_Cel.Size = new System.Drawing.Size(120, 20);
            this.Txt_Cel.TabIndex = 67;
            this.Txt_Cel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Niver
            // 
            this.Txt_Niver.Location = new System.Drawing.Point(360, 209);
            this.Txt_Niver.Mask = "00/00/0000";
            this.Txt_Niver.Name = "Txt_Niver";
            this.Txt_Niver.Size = new System.Drawing.Size(94, 20);
            this.Txt_Niver.TabIndex = 66;
            this.Txt_Niver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Niver.ValidatingType = typeof(System.DateTime);
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(79, 107);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Id.TabIndex = 65;
            this.Lbl_Id.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(208, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(345, 39);
            this.label13.TabIndex = 64;
            this.label13.Text = "Cadastro de Escolas";
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Location = new System.Drawing.Point(320, 352);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(148, 23);
            this.Btn_Alterar.TabIndex = 63;
            this.Btn_Alterar.Text = "Salvar Alteração";
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            this.Btn_Alterar.Visible = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Aniversário:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(472, 264);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(56, 13);
            this.Label11.TabIndex = 60;
            this.Label11.Text = "Instagram:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(28, 264);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(38, 13);
            this.Label10.TabIndex = 59;
            this.Label10.Text = "E-mail:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(617, 212);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(29, 13);
            this.Label9.TabIndex = 58;
            this.Label9.Text = "Fixo:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(460, 212);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(25, 13);
            this.Label8.TabIndex = 57;
            this.Label8.Text = "Cel:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(19, 212);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 13);
            this.Label7.TabIndex = 56;
            this.Label7.Text = "Diretora:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(586, 158);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 13);
            this.Label6.TabIndex = 55;
            this.Label6.Text = "Cidade:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(379, 158);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(37, 13);
            this.Label5.TabIndex = 54;
            this.Label5.Text = "Bairro:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(264, 158);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(22, 13);
            this.Label4.TabIndex = 53;
            this.Label4.Text = "N°:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(36, 158);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 13);
            this.Label3.TabIndex = 52;
            this.Label3.Text = "Rua:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(126, 107);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(42, 13);
            this.Label2.TabIndex = 51;
            this.Label2.Text = "Escola:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(45, 107);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(21, 13);
            this.Label1.TabIndex = 50;
            this.Label1.Text = "ID:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(362, 312);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 49;
            this.Button1.Text = "Confirmar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Txt_Insta
            // 
            this.Txt_Insta.Location = new System.Drawing.Point(537, 261);
            this.Txt_Insta.Name = "Txt_Insta";
            this.Txt_Insta.Size = new System.Drawing.Size(228, 20);
            this.Txt_Insta.TabIndex = 48;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(82, 261);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(328, 20);
            this.Txt_Email.TabIndex = 47;
            // 
            // Txt_Diretora
            // 
            this.Txt_Diretora.Location = new System.Drawing.Point(82, 209);
            this.Txt_Diretora.Name = "Txt_Diretora";
            this.Txt_Diretora.Size = new System.Drawing.Size(204, 20);
            this.Txt_Diretora.TabIndex = 44;
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(634, 155);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(131, 20);
            this.Txt_Cidade.TabIndex = 43;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(422, 155);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(131, 20);
            this.Txt_Bairro.TabIndex = 42;
            // 
            // Txt_N
            // 
            this.Txt_N.Location = new System.Drawing.Point(292, 155);
            this.Txt_N.Name = "Txt_N";
            this.Txt_N.Size = new System.Drawing.Size(47, 20);
            this.Txt_N.TabIndex = 41;
            // 
            // Txt_Rua
            // 
            this.Txt_Rua.Location = new System.Drawing.Point(82, 155);
            this.Txt_Rua.Name = "Txt_Rua";
            this.Txt_Rua.Size = new System.Drawing.Size(155, 20);
            this.Txt_Rua.TabIndex = 40;
            // 
            // Txt_Escola
            // 
            this.Txt_Escola.Location = new System.Drawing.Point(174, 104);
            this.Txt_Escola.Name = "Txt_Escola";
            this.Txt_Escola.Size = new System.Drawing.Size(591, 20);
            this.Txt_Escola.TabIndex = 39;
            // 
            // TabConsulta
            // 
            this.TabConsulta.BackColor = System.Drawing.Color.AliceBlue;
            this.TabConsulta.Controls.Add(this.BtnConsultar);
            this.TabConsulta.Controls.Add(this.DgResultado);
            this.TabConsulta.Location = new System.Drawing.Point(4, 22);
            this.TabConsulta.Name = "TabConsulta";
            this.TabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsulta.Size = new System.Drawing.Size(793, 422);
            this.TabConsulta.TabIndex = 1;
            this.TabConsulta.Text = "Consulta";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(8, 365);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(779, 23);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // DgResultado
            // 
            this.DgResultado.AllowUserToAddRows = false;
            this.DgResultado.AllowUserToDeleteRows = false;
            this.DgResultado.AllowUserToOrderColumns = true;
            this.DgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResultado.ContextMenuStrip = this.contextMenuStrip1;
            this.DgResultado.Location = new System.Drawing.Point(8, 32);
            this.DgResultado.Name = "DgResultado";
            this.DgResultado.ReadOnly = true;
            this.DgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgResultado.Size = new System.Drawing.Size(779, 327);
            this.DgResultado.TabIndex = 0;
            this.DgResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgResultado_CellContentClick);
            // 
            // Cadastro_Escola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabCadastrar);
            this.IsMdiContainer = true;
            this.Name = "Cadastro_Escola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Escola";
            this.Load += new System.EventHandler(this.Cadastro_Escola_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.TabCadastrar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl TabCadastrar;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TabPage TabConsulta;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView DgResultado;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Alterar;
        public System.Windows.Forms.TextBox Txt_Insta;
        public System.Windows.Forms.TextBox Txt_Email;
        public System.Windows.Forms.TextBox Txt_Diretora;
        public System.Windows.Forms.TextBox Txt_Cidade;
        public System.Windows.Forms.TextBox Txt_Bairro;
        public System.Windows.Forms.TextBox Txt_N;
        public System.Windows.Forms.TextBox Txt_Rua;
        public System.Windows.Forms.TextBox Txt_Escola;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.MaskedTextBox Txt_Fixo;
        private System.Windows.Forms.MaskedTextBox Txt_Cel;
        private System.Windows.Forms.MaskedTextBox Txt_Niver;
    }
}