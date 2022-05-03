using e_Agenda02.Dominio;
using e_Agenda02.Infra.Arquivo;
using e_Agenda02.Infra.Arquivo.ModiloTarefa;
using e_Agenda02.Infra.Arquivo.ModuloContato;
using e_Agenda02.WinApp.ModuloCompromisso;
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
    public partial class ListagemTarefasForm : Form
    {

        public RepositorioTarefa repositorioTarefa;

        public RepositorioContato repositorioContatos;

          ListagemContatosForm telaContatos = new ListagemContatosForm();
          LIstagemCompromissosForm telaCompromissos = new LIstagemCompromissosForm();


        public ListagemTarefasForm()
        {
            SerializadorTarefasEmJson serializadorTarefas = new SerializadorTarefasEmJson();
            SerializadorContatosEmJson serializadorContatos = new SerializadorContatosEmJson();

            repositorioTarefa = new RepositorioTarefa(serializadorTarefas);
            repositorioContatos = new RepositorioContato(serializadorContatos);


            InitializeComponent();

            CarregarTarefas();
        }
        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos().OrderBy(x => x.Prioridade).ToList();

            listTarefas.Items.Clear();

            foreach (Tarefa t in tarefas)
            {
                listTarefas.Items.Add(t);
            }
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroTarefa tela = new CadastroTarefa();

            tela.Tarefa = new Tarefa();

            DialogResult result = tela.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }
        }
 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro!",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroTarefa tela = new CadastroTarefa();

            tela.Tarefa = tarefaSelecionada;

            DialogResult result = tela.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                CarregarTarefas();
            }

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro!",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Esclusão de Tarefas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }

        }
        private void btnCadastrarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecinada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecinada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro!",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecinada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecinada, itens);

                CarregarTarefas();
            }

        }
        private void btnAtualizarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeir",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);

                CarregarTarefas();
            }
        }
        private void btnTarefasConcluidas_Click(object sender, EventArgs e)
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.TarefasConcluidas();

            listTarefas.Items.Clear();
            
            foreach (Tarefa t in tarefasConcluidas)
            {
                listTarefas.Items.Add(t);
            }
        }
        private void btnTarefasPendentes_Click(object sender, EventArgs e)
        {
            List<Tarefa> tarefasPendentes = repositorioTarefa.TarefasPendentes();

            listTarefas.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listTarefas.Items.Add(t);
            }

        }

        #region Outras telas
        private void brnContatos_Click(object sender, EventArgs e)
        {
             this.Dispose();
             telaContatos.ShowDialog();
             
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            this.Dispose();
            telaCompromissos.ShowDialog();
        }


        #endregion

        
    }
}
