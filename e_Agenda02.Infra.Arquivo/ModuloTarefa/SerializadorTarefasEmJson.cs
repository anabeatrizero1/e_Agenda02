using e_Agenda02.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Infra.Arquivo.ModiloTarefa
{
    public class SerializadorTarefasEmJson : ISerializador<Tarefa>
    {
        private const string arquivoTarefas = @"C:\temp\tarefas.json";

        public List<Tarefa> CarregarRegistrosDoAquivo()
        {
            if (File.Exists(arquivoTarefas) == false)
                return new List<Tarefa>();

            string tarefaJson = File.ReadAllText(arquivoTarefas);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Tarefa>>(tarefaJson, settings);
        }

        public void GravarRegistrosEmArquivo(List<Tarefa> tarefas)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = JsonConvert.SerializeObject(tarefas, settings);

            File.WriteAllText(arquivoTarefas, tarefasJson);

        }
    }
}
