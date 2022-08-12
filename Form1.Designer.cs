namespace banco_de_dados
{
    partial class Academia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_ledlogado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestaoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledlogado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lb_nomeUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_ledlogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 33);
            this.panel1.TabIndex = 0;
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Location = new System.Drawing.Point(164, 11);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(16, 13);
            this.lb_nomeUsuario.TabIndex = 4;
            this.lb_nomeUsuario.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario: ";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(90, 11);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 13);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            // 
            // pb_ledlogado
            // 
            this.pb_ledlogado.Image = global::banco_de_dados.Properties.Resources.led_vermelho;
            this.pb_ledlogado.Location = new System.Drawing.Point(3, 3);
            this.pb_ledlogado.Name = "pb_ledlogado";
            this.pb_ledlogado.Size = new System.Drawing.Size(30, 27);
            this.pb_ledlogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledlogado.TabIndex = 0;
            this.pb_ledlogado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.manutençaoToolStripMenuItem,
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.novoAlunoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestaoDeUsuariosToolStripMenuItem,
            this.novoUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // gestaoDeUsuariosToolStripMenuItem
            // 
            this.gestaoDeUsuariosToolStripMenuItem.Name = "gestaoDeUsuariosToolStripMenuItem";
            this.gestaoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestaoDeUsuariosToolStripMenuItem.Text = "Gestao de Usuarios";
            this.gestaoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestaoDeUsuariosToolStripMenuItem_Click);
            // 
            // novoUsuarioToolStripMenuItem
            // 
            this.novoUsuarioToolStripMenuItem.Name = "novoUsuarioToolStripMenuItem";
            this.novoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.novoUsuarioToolStripMenuItem.Text = "Novo Usuario";
            this.novoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuarioToolStripMenuItem_Click);
            // 
            // manutençaoToolStripMenuItem
            // 
            this.manutençaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.gestãoDeProfessoresToolStripMenuItem});
            this.manutençaoToolStripMenuItem.Name = "manutençaoToolStripMenuItem";
            this.manutençaoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençaoToolStripMenuItem.Text = "Manutençao";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.horariosToolStripMenuItem.Text = "Horarios";
            this.horariosToolStripMenuItem.Click += new System.EventHandler(this.horariosToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGONToolStripMenuItem,
            this.lOGOFFToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.lOGINToolStripMenuItem.Text = "Login";
            // 
            // lOGONToolStripMenuItem
            // 
            this.lOGONToolStripMenuItem.Name = "lOGONToolStripMenuItem";
            this.lOGONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lOGONToolStripMenuItem.Text = "LogOn";
            this.lOGONToolStripMenuItem.Click += new System.EventHandler(this.lOGONToolStripMenuItem_Click);
            // 
            // lOGOFFToolStripMenuItem
            // 
            this.lOGOFFToolStripMenuItem.Name = "lOGOFFToolStripMenuItem";
            this.lOGOFFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lOGOFFToolStripMenuItem.Text = "LogOff";
            this.lOGOFFToolStripMenuItem.Click += new System.EventHandler(this.lOGOFFToolStripMenuItem_Click);
            // 
            // gestãoDeProfessoresToolStripMenuItem
            // 
            this.gestãoDeProfessoresToolStripMenuItem.Name = "gestãoDeProfessoresToolStripMenuItem";
            this.gestãoDeProfessoresToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestãoDeProfessoresToolStripMenuItem.Text = "Gestão de Professores";
            this.gestãoDeProfessoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProfessoresToolStripMenuItem_Click);
            // 
            // Academia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Academia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia - 1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledlogado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pb_ledlogado;
        public System.Windows.Forms.Label lb_nomeUsuario;
        public System.Windows.Forms.Label lb_acesso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestaoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProfessoresToolStripMenuItem;
    }
}

