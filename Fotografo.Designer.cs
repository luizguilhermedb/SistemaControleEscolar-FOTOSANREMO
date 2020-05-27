namespace Foto_SanRemo
{
    partial class Fotografo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fotografo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Cb_Mes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_Abrir = new System.Windows.Forms.Button();
            this.Cb_Fotografo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dg_tabela = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Txt_Comissao = new System.Windows.Forms.TextBox();
            this.Txt_Cel = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Fotografo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Dg_Fotografos = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_tabela)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Fotografos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Cb_Mes);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Btn_imprimir);
            this.tabPage1.Controls.Add(this.Btn_Abrir);
            this.tabPage1.Controls.Add(this.Cb_Fotografo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Dg_tabela);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Relação";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Cb_Mes
            // 
            this.Cb_Mes.FormattingEnabled = true;
            this.Cb_Mes.Items.AddRange(new object[] {
            "janeiro",
            "fevereiro",
            "março",
            "abril",
            "maio",
            "junho",
            "julho",
            "agosto",
            "setembro",
            "outubro",
            "novembro",
            "dezembro"});
            this.Cb_Mes.Location = new System.Drawing.Point(92, 103);
            this.Cb_Mes.Name = "Cb_Mes";
            this.Cb_Mes.Size = new System.Drawing.Size(155, 21);
            this.Cb_Mes.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mês :";
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Location = new System.Drawing.Point(97, 226);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(143, 23);
            this.Btn_imprimir.TabIndex = 4;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            this.Btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            // 
            // Btn_Abrir
            // 
            this.Btn_Abrir.Location = new System.Drawing.Point(97, 172);
            this.Btn_Abrir.Name = "Btn_Abrir";
            this.Btn_Abrir.Size = new System.Drawing.Size(143, 23);
            this.Btn_Abrir.TabIndex = 3;
            this.Btn_Abrir.Text = "Abrir";
            this.Btn_Abrir.UseVisualStyleBackColor = true;
            this.Btn_Abrir.Click += new System.EventHandler(this.Btn_Abrir_Click);
            // 
            // Cb_Fotografo
            // 
            this.Cb_Fotografo.FormattingEnabled = true;
            this.Cb_Fotografo.Location = new System.Drawing.Point(92, 66);
            this.Cb_Fotografo.Name = "Cb_Fotografo";
            this.Cb_Fotografo.Size = new System.Drawing.Size(155, 21);
            this.Cb_Fotografo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fotógrafo :";
            // 
            // Dg_tabela
            // 
            this.Dg_tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_tabela.Location = new System.Drawing.Point(328, 6);
            this.Dg_tabela.Name = "Dg_tabela";
            this.Dg_tabela.Size = new System.Drawing.Size(459, 416);
            this.Dg_tabela.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Txt_Comissao);
            this.tabPage2.Controls.Add(this.Txt_Cel);
            this.tabPage2.Controls.Add(this.Txt_Email);
            this.tabPage2.Controls.Add(this.Txt_Fotografo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Btn_Cadastrar);
            this.tabPage2.Controls.Add(this.Dg_Fotografos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Txt_Comissao
            // 
            this.Txt_Comissao.Location = new System.Drawing.Point(303, 110);
            this.Txt_Comissao.Name = "Txt_Comissao";
            this.Txt_Comissao.Size = new System.Drawing.Size(38, 20);
            this.Txt_Comissao.TabIndex = 16;
            // 
            // Txt_Cel
            // 
            this.Txt_Cel.Location = new System.Drawing.Point(99, 110);
            this.Txt_Cel.Mask = "(99) 00000-0000";
            this.Txt_Cel.Name = "Txt_Cel";
            this.Txt_Cel.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cel.TabIndex = 15;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(99, 75);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(288, 20);
            this.Txt_Email.TabIndex = 14;
            // 
            // Txt_Fotografo
            // 
            this.Txt_Fotografo.Location = new System.Drawing.Point(99, 40);
            this.Txt_Fotografo.Name = "Txt_Fotografo";
            this.Txt_Fotografo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Fotografo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Comissão (%) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fotógrafo :";
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Location = new System.Drawing.Point(6, 158);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(780, 23);
            this.Btn_Cadastrar.TabIndex = 8;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dg_Fotografos
            // 
            this.Dg_Fotografos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Fotografos.Location = new System.Drawing.Point(7, 187);
            this.Dg_Fotografos.Name = "Dg_Fotografos";
            this.Dg_Fotografos.Size = new System.Drawing.Size(780, 235);
            this.Dg_Fotografos.TabIndex = 5;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Fotografo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Fotografo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotografo";
            this.Load += new System.EventHandler(this.Fotografo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_tabela)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Fotografos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_Abrir;
        private System.Windows.Forms.ComboBox Cb_Fotografo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dg_tabela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.DataGridView Dg_Fotografos;
        private System.Windows.Forms.ComboBox Cb_Mes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Comissao;
        private System.Windows.Forms.MaskedTextBox Txt_Cel;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Fotografo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}