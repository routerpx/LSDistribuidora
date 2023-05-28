
namespace LSDistribuidora
{
    partial class principalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principalForm));
            this.principalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalToolStrip = new System.Windows.Forms.ToolStrip();
            this.principalStatusStrip = new System.Windows.Forms.StatusStrip();
            this.aguardeHoraToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nomeUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.horaTimer = new System.Windows.Forms.Timer(this.components);
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalMenuStrip.SuspendLayout();
            this.principalStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // principalMenuStrip
            // 
            this.principalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.principalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.principalMenuStrip.Name = "principalMenuStrip";
            this.principalMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.principalMenuStrip.TabIndex = 0;
            this.principalMenuStrip.Text = "menuStrip";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem,
            this.fazerLoginToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // fazerLoginToolStripMenuItem
            // 
            this.fazerLoginToolStripMenuItem.Name = "fazerLoginToolStripMenuItem";
            this.fazerLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fazerLoginToolStripMenuItem.Text = "Fazer Login";
            this.fazerLoginToolStripMenuItem.Click += new System.EventHandler(this.fazerLoginToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.janelasEmCascataToolStripMenuItem,
            this.alinhamentoHorizontalToolStripMenuItem,
            this.alinhamentoVerticalToolStripMenuItem,
            this.ladoALadoToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // janelasEmCascataToolStripMenuItem
            // 
            this.janelasEmCascataToolStripMenuItem.Name = "janelasEmCascataToolStripMenuItem";
            this.janelasEmCascataToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.janelasEmCascataToolStripMenuItem.Text = "Janelas em Cascata";
            this.janelasEmCascataToolStripMenuItem.Click += new System.EventHandler(this.janelasEmCascataToolStripMenuItem_Click);
            // 
            // alinhamentoHorizontalToolStripMenuItem
            // 
            this.alinhamentoHorizontalToolStripMenuItem.Name = "alinhamentoHorizontalToolStripMenuItem";
            this.alinhamentoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.alinhamentoHorizontalToolStripMenuItem.Text = "Alinhamento Horizontal";
            this.alinhamentoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.alinhamentoHorizontalToolStripMenuItem_Click);
            // 
            // alinhamentoVerticalToolStripMenuItem
            // 
            this.alinhamentoVerticalToolStripMenuItem.Name = "alinhamentoVerticalToolStripMenuItem";
            this.alinhamentoVerticalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.alinhamentoVerticalToolStripMenuItem.Text = "Alinhamento Vertical";
            this.alinhamentoVerticalToolStripMenuItem.Click += new System.EventHandler(this.alinhamentoVerticalToolStripMenuItem_Click);
            // 
            // ladoALadoToolStripMenuItem
            // 
            this.ladoALadoToolStripMenuItem.Name = "ladoALadoToolStripMenuItem";
            this.ladoALadoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ladoALadoToolStripMenuItem.Text = "Lado a Lado";
            this.ladoALadoToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // principalToolStrip
            // 
            this.principalToolStrip.Location = new System.Drawing.Point(0, 24);
            this.principalToolStrip.Name = "principalToolStrip";
            this.principalToolStrip.Size = new System.Drawing.Size(800, 25);
            this.principalToolStrip.TabIndex = 1;
            this.principalToolStrip.Text = "toolStrip1";
            // 
            // principalStatusStrip
            // 
            this.principalStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aguardeHoraToolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.nomeUsuarioToolStripStatusLabel});
            this.principalStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.principalStatusStrip.Name = "principalStatusStrip";
            this.principalStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.principalStatusStrip.TabIndex = 2;
            this.principalStatusStrip.Text = "statusStrip1";
            // 
            // aguardeHoraToolStripStatusLabel
            // 
            this.aguardeHoraToolStripStatusLabel.Name = "aguardeHoraToolStripStatusLabel";
            this.aguardeHoraToolStripStatusLabel.Size = new System.Drawing.Size(59, 17);
            this.aguardeHoraToolStripStatusLabel.Text = "aguarde...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = " | ";
            // 
            // nomeUsuarioToolStripStatusLabel
            // 
            this.nomeUsuarioToolStripStatusLabel.Name = "nomeUsuarioToolStripStatusLabel";
            this.nomeUsuarioToolStripStatusLabel.Size = new System.Drawing.Size(136, 17);
            this.nomeUsuarioToolStripStatusLabel.Text = "Nenhum usuário logado";
            // 
            // horaTimer
            // 
            this.horaTimer.Interval = 1000;
            this.horaTimer.Tick += new System.EventHandler(this.horaTimer_Tick);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.principalStatusStrip);
            this.Controls.Add(this.principalToolStrip);
            this.Controls.Add(this.principalMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.principalMenuStrip;
            this.Name = "principalForm";
            this.Text = "LS Distribuidora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principalForm_Load);
            this.principalMenuStrip.ResumeLayout(false);
            this.principalMenuStrip.PerformLayout();
            this.principalStatusStrip.ResumeLayout(false);
            this.principalStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip principalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip principalToolStrip;
        private System.Windows.Forms.StatusStrip principalStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel aguardeHoraToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel nomeUsuarioToolStripStatusLabel;
        private System.Windows.Forms.Timer horaTimer;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
    }
}

