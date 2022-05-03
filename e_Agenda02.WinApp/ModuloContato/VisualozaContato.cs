using e_Agenda02.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda02.WinApp.ModuloContato
{
    public partial class VisualozaContato : Form
    {
        public VisualozaContato(Contato contato)
        {
            InitializeComponent();

            labelNome.Text = contato.Nome;
            labelTelefone.Text = contato.Telefone;
            labelEmail.Text = contato.Email;
            labelEmpresa.Text = contato.Empresa;    
            labelCargo.Text = contato.Cargo;    
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
