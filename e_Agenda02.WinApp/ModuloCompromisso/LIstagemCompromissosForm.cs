using e_Agenda02.Dominio;
using e_Agenda02.Dominio.ModuloCompromissso;
using e_Agenda02.Infra.Arquivo.ModuloCompromisso;
using e_Agenda02.Infra.Arquivo.ModuloContato;
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
    public partial class LIstagemCompromissosForm : Form
    {
        public readonly RepositorioCompromisso repositorioCompromisso;

        public LIstagemCompromissosForm(RepositorioContato repositorioContato)
        {
            SerializadorCompromissosEmJson serializadorCompromissos = new SerializadorCompromissosEmJson();

            repositorioCompromisso = new RepositorioCompromisso(serializadorCompromissos);
            

            InitializeComponent();

            CarregarCompromissos();


        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listCompromisso.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                listCompromisso.Items.Add(c);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            List<Contato> contatos = new List<Contato>();

            SerializadorContatosEmJson serializador =  new SerializadorContatosEmJson();
            contatos = serializador.CarregarRegistrosDoAquivo();

            CadastroCompromisso tela = new CadastroCompromisso(contatos);

            foreach (Contato contato in contatos) {
                tela.cbListContatos.Items.Add((Contato)contato);
            }

            tela.Compromisso = new Compromisso();
            
            DialogResult result = tela.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.Compromisso);
                CarregarCompromissos();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromisso.SelectedItem;
           
            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
               "Gestão de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Contato> contatos = new List<Contato>();

            SerializadorContatosEmJson serializador = new SerializadorContatosEmJson();
            contatos = serializador.CarregarRegistrosDoAquivo();

            CadastroCompromisso tela = new CadastroCompromisso(contatos);

            tela.Compromisso = compromissoSelecionado;

            foreach (Contato contato in contatos)
            {
                tela.cbListContatos.Items.Add(contato);
            }


            DialogResult result = tela.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioCompromisso.Editar(tela.Compromisso);
                CarregarCompromissos();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromisso.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um Compromisso primeiro!",
                "Gestão de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Deseja realmente excluir o Compromisso?",
                "Exclusão de Compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos();
            }
        }

        private void btnCompromissosFuturos_Click(object sender, EventArgs e)
        {
            this.btnFiltrar.Enabled = true;
            List<Compromisso> compromissosFuturos = repositorioCompromisso.CompromissosFuturos() ;

            listCompromisso.Items.Clear();

            foreach (Compromisso c in compromissosFuturos)
            {
                listCompromisso.Items.Add(c);
            }
        }

        private void btnCompromissosPassados_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissosPassados = repositorioCompromisso.CompromissosPassados();

            listCompromisso.Items.Clear();

            foreach (Compromisso c in compromissosPassados)
            {
                listCompromisso.Items.Add(c);
            }

        }

        private void btnTodosCompromissos_Click(object sender, EventArgs e)
        {
            CarregarCompromissos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissosPorPeriodo = repositorioCompromisso
                .SelecionarRegistrosPeriodo(datePickerInicio.Value, datePickerTermino.Value);

            listCompromisso.Items.Clear();

            foreach (Compromisso c in compromissosPorPeriodo)
            {
                listCompromisso.Items.Add(c);
            }
        }

        private void brnContatos_Click(object sender, EventArgs e)
        {
            ListagemContatosForm tela = new ListagemContatosForm();
            tela.ShowDialog();

        }

        private void brnTarefas_Click(object sender, EventArgs e)
        {
            ListagemTarefasForm tela = new ListagemTarefasForm();
            tela.ShowDialog();
        }
    }
}
