using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Dominio
{
    [Serializable]
    public class Tarefa : EntidadeBase
    {
        private List<ItemTarefa> itens = new List<ItemTarefa>();

        public Tarefa() 
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string t)
        {
            Numero = n;
            Titulo = t;
            DataConclusao = null;
        }

        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public PrioridadeTarefa Prioridade { get; set; }


        public List<ItemTarefa> Itens { get { return itens; } }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return $"Número: {Numero}, Titulo: {Titulo}, Percentual: {percentual}," +
                    $" Concluida: {DataConclusao.Value.ToShortDateString()}";
            }
            return $"Número: {Numero}, Titulo: {Titulo}, Percentual: {percentual}";

        }

        public void AdicionarItem(ItemTarefa item)
        {
            if (itens.Exists(x => x.Equals(item)) == false)
            {
                itens.Add(item);
            }
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }

        public void MarcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();


        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var pecentualConcluido = qtdConcluidas / (decimal)itens.Count * 100;
            return Math.Round(pecentualConcluido, 2);
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
