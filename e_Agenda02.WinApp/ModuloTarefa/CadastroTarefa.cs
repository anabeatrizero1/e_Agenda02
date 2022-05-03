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

namespace e_Agenda02.WinApp
{
    public partial class CadastroTarefa : Form
    {
        private Tarefa tarefa;
        public CadastroTarefa()
        {
            InitializeComponent();
        }
        public Tarefa Tarefa
        {
            get 
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tarefa.Titulo = txtTitulo.Text;
            if( cbPrioridade.SelectedItem == null)
                Tarefa.Prioridade = (PrioridadeTarefa)1;
            else
            Tarefa.Prioridade = (PrioridadeTarefa)cbPrioridade.SelectedIndex;
        }
    }
}
