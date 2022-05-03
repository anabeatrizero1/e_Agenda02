using e_Agenda02.Dominio.ModuloCompromissso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Infra.Arquivo.ModuloCompromisso
{
    public interface IRepositorioCompromisso
    {
        void Editar(Compromisso compromisso);
        void Excluir(Compromisso compromisso);
        void Inserir(Compromisso novaCompromisso);
        List<Compromisso> SelecionarTodos();
    }
}
