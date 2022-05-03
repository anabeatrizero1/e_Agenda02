using e_Agenda02.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Infra.Arquivo.ModuloContato
{
    public class RepositorioContato : IRepositorioContato
    {
        private readonly ISerializador<Contato> serializador;
        List<Contato> contatos;
        private int contador = 0;

        public RepositorioContato(ISerializador<Contato> serializador)
        {
            this.serializador = serializador;

            contatos = serializador.CarregarRegistrosDoAquivo();

            if (contatos.Count > 0)
                contador = contatos.Max(x => x.Numero);

        }
        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            string resultado = novoContato.Validar();
            if(resultado != "REGISTRO_VALIDO")
            {
                return;
            }
            novoContato.Numero = ++contador;

            contatos.Add(novoContato);
            
            serializador.GravarRegistrosEmArquivo(contatos);

        }

        public void Editar(Contato contato)
        {
            foreach(var item in contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Email = contato.Email;
                    item.Telefone = contato.Telefone;
                    item.Cargo = contato.Cargo;
                    item.Empresa = contato.Empresa;
                    break;
                }
            }
            serializador.GravarRegistrosEmArquivo(contatos);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);

            serializador.GravarRegistrosEmArquivo(contatos);
        }

    }
}
