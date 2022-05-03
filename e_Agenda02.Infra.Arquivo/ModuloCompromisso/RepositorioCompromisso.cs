using e_Agenda02.Dominio.ModuloCompromissso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Infra.Arquivo.ModuloCompromisso
{
    public class RepositorioCompromisso : IRepositorioCompromisso
    {
        private readonly ISerializador<Compromisso> serializador;

        List<Compromisso> compromissos;
        private int contador = 0;

        public RepositorioCompromisso(ISerializador<Compromisso> serializador)
        {
            this.serializador = serializador;

            compromissos = serializador.CarregarRegistrosDoAquivo();

            if (compromissos.Count > 0)
                contador = compromissos.Max(x => x.Numero);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            string validacao = novoCompromisso.Validar();

            if(validacao == "REGISTRO_VALIDO")
            {
                novoCompromisso.Numero = ++contador;
                compromissos.Add(novoCompromisso);

                serializador.GravarRegistrosEmArquivo(compromissos);
            }
            
            
        }
        public void Editar(Compromisso compromisso)
        {
            
                foreach (var item in compromissos)
                {
                    if (item.Numero == compromisso.Numero)
                    {
                        item.Assunto = compromisso.Assunto;
                        item.Local = compromisso.Local;
                        item.DataCompromisso = compromisso.DataCompromisso;
                        item.HoraInicio = compromisso.HoraInicio;
                        item.HoraTermino = compromisso.HoraTermino;
                        item.Contato = compromisso.Contato;
                        break;
                    }
                }
                serializador.GravarRegistrosEmArquivo(compromissos);
            
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);

            serializador.GravarRegistrosEmArquivo(compromissos);

        }

       
        public List<Compromisso> CompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = compromissos.
                FindAll(compromisso => compromisso.DataCompromisso >= DateTime.Today).ToList();

            return compromissosFuturos;
        }

        public List<Compromisso> CompromissosPassados()
        {
            List<Compromisso> compromissosPassados = compromissos.
               FindAll(compromisso => compromisso.DataCompromisso < DateTime.Today).ToList();

            return compromissosPassados;

        }

        public List<Compromisso> SelecionarRegistrosPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            List<Compromisso> compromissosPorPeriodo = compromissos.
                FindAll(compromisso => compromisso.DataCompromisso > dataInicio 
                        && compromisso.DataCompromisso < dataTermino).ToList();

            return compromissosPorPeriodo;
        }
    }
}
