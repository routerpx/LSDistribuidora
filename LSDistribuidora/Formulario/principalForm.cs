using LSDistribuidora.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSDistribuidora
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.FormClosing += principalForm_FormClosing;
        }

        private void principalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                MessageBox.Show(
                "Deseja fechar o programa?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void principalForm_Load(object sender, EventArgs e)
        {
            horaTimer.Start();
            VerificarLogin();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosListarForm produtosListarForm = new ProdutosListarForm();
            produtosListarForm.MdiParent = this;
            produtosListarForm.WindowState = FormWindowState.Normal;
            produtosListarForm.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SobreForm().ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void horaTimer_Tick(object sender, EventArgs e)
        {
            aguardeHoraToolStripStatusLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void janelasEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void alinhamentoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void alinhamentoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ladoALadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void fazerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.UsuarioLogado = null;
            VerificarLogin();
        }

        void VerificarLogin()
        {
            if (Global.UsuarioLogado == null)
            {
                usuáriosToolStripMenuItem.Enabled = false;
                produtosToolStripMenuItem.Enabled = false;
                nomeUsuarioToolStripStatusLabel.Text = "Nenhum usuário logado";
                //fecha os forms abertos
                foreach (Form f in this.MdiChildren)
                    f.Close();
                fazerLoginToolStripMenuItem.Text = "Entrar";

                //chama a tela de login
                new LoginForm().ShowDialog();
            }

            if (Global.UsuarioLogado != null)
            {
                //só habilita o menu de usuários se for admin (nível 1)
                usuáriosToolStripMenuItem.Enabled = Global.UsuarioLogado.Nivel == 1;
                produtosToolStripMenuItem.Enabled = true;
                fazerLoginToolStripMenuItem.Text = "Fazer Logoff";
                nomeUsuarioToolStripStatusLabel.Text = Global.UsuarioLogado.Nome;
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosForm = new UsuariosForm();
            usuariosForm.MdiParent = this;
            usuariosForm.WindowState = FormWindowState.Normal;
            usuariosForm.Show();
        }
    }
}
