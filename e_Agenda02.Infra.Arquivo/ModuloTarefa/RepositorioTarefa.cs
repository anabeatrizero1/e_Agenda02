using e_Agenda02.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace e_Agenda02.Infra.Arquivo.ModiloTarefa
{
    public class RepositorioTarefa : IRepositorioTarefa
    {
        private readonly ISerializador<Tarefa> serializador;

        List<Tarefa> tarefas;
        private int contador = 0;


        public RepositorioTarefa(ISerializador<Tarefa> serializador)
        {
            this.serializador = serializador;

            tarefas = serializador.CarregarRegistrosDoAquivo();

            if (tarefas.Count > 0)
                contador = tarefas.Max(x => x.Numero);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public List<Tarefa> TarefasConcluidas()
        {
            List<Tarefa> tPendentes = new List<Tarefa>();
            foreach (var tarefa in tarefas)
            {
                if(tarefa.CalcularPercentualConcluido() == 100)
                    tPendentes.Add(tarefa);
            }
            return tPendentes;
        }
        public List<Tarefa> TarefasPendentes()
        {
            List<Tarefa> tPendentes = new List<Tarefa>();
            foreach (var tarefa in tarefas)
            {
                if (tarefa.CalcularPercentualConcluido() != 100)
                    tPendentes.Add(tarefa);
            }
            return tPendentes;
        }
        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);

            serializador.GravarRegistrosEmArquivo(tarefas);

        }
        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    break;
                }
            }
            serializador.GravarRegistrosEmArquivo(tarefas);


        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);

            serializador.GravarRegistrosEmArquivo(tarefas);

        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach(var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            serializador.GravarRegistrosEmArquivo(tarefas);

        }

        public void AtualizarItens(Tarefa tarefaSelecionada, 
            List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendenetes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }
            foreach (var item in itensPendenetes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }
            serializador.GravarRegistrosEmArquivo(tarefas);

        }

      
    }
}
