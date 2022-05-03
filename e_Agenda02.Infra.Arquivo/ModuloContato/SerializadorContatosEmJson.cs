using e_Agenda02.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Infra.Arquivo.ModuloContato
{
    public class SerializadorContatosEmJson : ISerializador<Contato>
    {
        private const string arquivoContatos = @"C:\temp\contatos.json";

        public List<Contato> CarregarRegistrosDoAquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            string tarefaJson = File.ReadAllText(arquivoContatos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Contato>>(tarefaJson, settings);

        }

        public void GravarRegistrosEmArquivo(List<Contato> contatos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = JsonConvert.SerializeObject(contatos, settings);

            File.WriteAllText(arquivoContatos, tarefasJson);

        }
    }
}
