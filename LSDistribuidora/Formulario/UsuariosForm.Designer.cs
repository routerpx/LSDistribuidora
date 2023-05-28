
namespace LSDistribuidora.Formulario
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.loginCadastroTextBox = new System.Windows.Forms.TextBox();
            this.senhaCadastroTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 630);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(101, 380);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(237, 24);
            this.nomeUsuarioTextBox.TabIndex = 1;
            // 
            // loginCadastroTextBox
            // 
            this.loginCadastroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginCadastroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginCadastroTextBox.Location = new System.Drawing.Point(381, 380);
            this.loginCadastroTextBox.Name = "loginCadastroTextBox";
            this.loginCadastroTextBox.Size = new System.Drawing.Size(237, 24);
            this.loginCadastroTextBox.TabIndex = 2;
            // 
            // senhaCadastroTextBox
            // 
            this.senhaCadastroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaCadastroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaCadastroTextBox.Location = new System.Drawing.Point(661, 380);
            this.senhaCadastroTextBox.Name = "senhaCadastroTextBox";
            this.senhaCadastroTextBox.Size = new System.Drawing.Size(237, 24);
            this.senhaCadastroTextBox.TabIndex = 3;
            // 
            // salvarButton
            // 
            this.salvarButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salvarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salvarButton.Location = new System.Drawing.Point(648, 429);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(267, 65);
            this.salvarButton.TabIndex = 4;
            this.salvarButton.Text = "SALVAR";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 626);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.senhaCadastroTextBox);
            this.Controls.Add(this.loginCadastroTextBox);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuariosForm";
            this.Text = "Cadastro Usuários";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox loginCadastroTextBox;
        private System.Windows.Forms.TextBox senhaCadastroTextBox;
        private System.Windows.Forms.Button salvarButton;
    }
}