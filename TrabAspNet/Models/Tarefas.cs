using System;
using System.ComponentModel.DataAnnotations;

namespace TrabAspNet.Models
{
    public class Tarefas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public bool Concluido { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatória")]
        public DateTime DataLimite { get; set; }

        public string Username { get; set; }
    }
}