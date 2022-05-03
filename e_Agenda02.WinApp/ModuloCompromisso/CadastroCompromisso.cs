using e_Agenda02.Dominio;
using e_Agenda02.Dominio.ModuloCompromissso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda02.WinApp.ModuloCompromisso
{
    public partial class CadastroCompromisso : Form
    {
        private Compromisso compromisso;
        private List<Contato> contatos;
        public CadastroCompromisso(List<Contato> contatos)
        {
            this.contatos = contatos;


            InitializeComponent();

        }
        public Compromisso Compromisso
        {
            get 
            { 
                return compromisso; 
            }
            set 
            { 
                compromisso = value;
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                txtHoraInicio.Text = compromisso.HoraInicio.ToString();
                txtHoraTermino.Text = compromisso.HoraTermino.ToString();
                datePickerCompromisso.MinDate= DateTime.Now;
                
            }    
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            compromisso.DataCompromisso = datePickerCompromisso.Value;

            if (cbNaoInserirContato.Checked == true)
            {
                Compromisso.Contato = null;
            }
            else
            {
                Compromisso.Contato = (Contato)cbListContatos.SelectedItem;
            }

            try
            {
                compromisso.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
                compromisso.HoraTermino = TimeSpan.Parse(txtHoraInicio.Text);
            }

            catch (Exception )
            {
                MessageBox.Show("Não foi possível gravar o Compromisso, verifique se os dados estão preenchidos corretamente. ",
               "Gestão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void CadastroCompromisso_Load(object sender, EventArgs e)
        {

        }

       
        private void cbNaoInserirContato_CheckedChanged(object sender, EventArgs e)
        {
            if(cbNaoInserirContato.Checked == true)
                cbListContatos.Enabled = false;
            else 
                cbListContatos.Enabled = true;
        }
    }
}
