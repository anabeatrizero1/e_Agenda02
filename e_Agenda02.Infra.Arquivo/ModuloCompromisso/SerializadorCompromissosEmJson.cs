using e_Agenda02.Dominio.ModuloCompromissso;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Infra.Arquivo.ModuloCompromisso
{
    public class SerializadorCompromissosEmJson : ISerializador<Compromisso>
    {
        private const string arquivoCompromissos = @"C:\temp\compromissos.json";

        public List<Compromisso> CarregarRegistrosDoAquivo()
        {
            if (File.Exists(arquivoCompromissos) == false)
                return new List<Compromisso>();

            string compromissosJson = File.ReadAllText(arquivoCompromissos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Compromisso>>(compromissosJson, settings);
        }

        public void GravarRegistrosEmArquivo(List<Compromisso> compromissos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string compromissosJson = JsonConvert.SerializeObject(compromissos, settings);

            File.WriteAllText(arquivoCompromissos, compromissosJson);

        }
    }
}
