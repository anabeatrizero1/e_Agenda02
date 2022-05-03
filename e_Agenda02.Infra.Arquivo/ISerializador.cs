using e_Agenda02.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Infra.Arquivo
{
    public interface ISerializador <T> where T : EntidadeBase
    {
        List<T> CarregarRegistrosDoAquivo();

        void GravarRegistrosEmArquivo(List<T> registros);
    }
}
