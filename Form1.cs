using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals("guto") && txtSenha.Text.Equals("1234"))
                {
                var menuRestrito = new Formulario();
                menuRestrito.Show();

                

            } else
            {
                MessageBox.Show("Senha ou Usuário incorreto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsuario.Focus();
                txtSenha.Text = "";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            //para deixar com cor diferente quando selecionar
            txtUsuario.BackColor = Color.LightYellow;
            txtUsuario.Text = "";
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = default;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para não deixar digitar caracteres especiais
            int tecla = (int)e.KeyChar;
            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8 && tecla != 13 && tecla != 127)
            {
                e.Handled = true;
                MessageBox.Show("Apenas Letras e números!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
