﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda02.Dominio.ModuloCompromissso
{
    [Serializable]

    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string Local { get; set; }

        private DateTime _dataCompromisso;
        public DateTime DataCompromisso { get => _dataCompromisso.Add(HoraInicio); set => _dataCompromisso = value; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Contato Contato { get; set; }

        public override string ToString()
        {
            string contatoRelacionado = Contato is null ? "Não disponível" : Contato.Nome;

            return $"Nº: {Numero}," +
                   $" Assunto: {Assunto}," +
                   $" Local: {Local}," +
                   $" Data do Compromisso: {DataCompromisso.ToShortDateString()}," +
                   $" Contato : {contatoRelacionado},";

        }

        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Assunto))
                sb.AppendLine("O assunto do compromisso é obrigatório!");

            if (string.IsNullOrEmpty(Local))
                sb.AppendLine("O local do compromisso é obrigatório!");

            if (DataCompromisso == DateTime.MinValue)
                sb.AppendLine("A data do compromisso obrigatória!");

            if (DataCompromisso < DateTime.Today)
                sb.AppendLine("A data do compromisso não pode ser antes de hoje!");

            if (HoraInicio > HoraTermino)
                sb.AppendLine("A hora de início não pode ser depois do término!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }
    }
}
