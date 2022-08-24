namespace banco_de_dados
{
    partial class F_novoAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_gravar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 29);
            this.panel1.TabIndex = 0;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(12, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(120, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(138, 3);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(120, 23);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(264, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Fechar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(12, 47);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(290, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Enabled = false;
            this.mtb_telefone.Location = new System.Drawing.Point(345, 47);
            this.mtb_telefone.Mask = "(99)00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(145, 20);
            this.mtb_telefone.TabIndex = 2;
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 102);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(271, 21);
            this.cb_status.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // tb_turma
            // 
            this.tb_turma.Location = new System.Drawing.Point(306, 102);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(153, 20);
            this.tb_turma.TabIndex = 7;
            this.tb_turma.Tag = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Turma";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(465, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(233, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Plano";
            // 
            // tb_plano
            // 
            this.tb_plano.Location = new System.Drawing.Point(12, 152);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.ReadOnly = true;
            this.tb_plano.Size = new System.Drawing.Size(215, 20);
            this.tb_plano.TabIndex = 10;
            // 
            // F_novoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 345);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_plano);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.panel1);
            this.Name = "F_novoAluno";
            this.Text = "F_novoAluno";
            this.Load += new System.EventHandler(this.F_novoAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_turma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_plano;
    }
}