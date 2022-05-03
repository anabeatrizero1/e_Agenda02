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
    public partial class CadastroContato : Form
    {
        private Contato contato;
        public CadastroContato()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
                
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = txtTelefone.Text;
            contato.Cargo = txtCargo.Text;
            contato.Empresa = txtEmpresa.Text;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
