using e_Agenda02.Dominio;
using e_Agenda02.Infra.Arquivo;
using e_Agenda02.Infra.Arquivo.ModuloContato;
using e_Agenda02.WinApp;
using e_Agenda02.WinApp;
using e_Agenda02.WinApp.ModuloCompromisso;
using e_Agenda02.WinApp.ModuloContato;
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
    public partial class ListagemContatosForm : Form
    {
        private IRepositorioContato repositorioContato;

        public RepositorioContato repositorioContatos;

          LIstagemCompromissosForm telaCompromissos = new LIstagemCompromissosForm();
         ListagemTarefasForm telaTarefas = new ListagemTarefasForm();

        public ListagemContatosForm()
        {
            SerializadorContatosEmJson serializador = new SerializadorContatosEmJson();
            SerializadorContatosEmJson serializadorContatos = new SerializadorContatosEmJson();

            repositorioContato = new RepositorioContato(serializador);

            InitializeComponent();

            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listContatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                listContatos.Items.Add(c);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroContato tela = new CadastroContato();

            tela.Contato = new Contato();

            DialogResult result = tela.ShowDialog();


            if(result == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarregarContatos();

            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
               "Gestão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContato tela = new CadastroContato();

            tela.Contato = contatoSelecionado;

            DialogResult result = tela.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um Contato primeiro!",
                "Gestão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Deseja realmente excluir o Contato?",
                "Exclusão de Contato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        private void btnVisualizarDetalhes_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
               "Gestão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            VisualozaContato tela = new VisualozaContato(contatoSelecionado);
            

            tela.ShowDialog();

        }



        #region Outras telas

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            this.Dispose();
            telaCompromissos.ShowDialog();
        }

        private void brnTarefas_Click(object sender, EventArgs e)
        {
            this.Dispose();
            telaCompromissos.ShowDialog();
        }
        #endregion
    }
}
