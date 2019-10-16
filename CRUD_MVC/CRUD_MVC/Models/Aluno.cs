using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_MVC.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        [Display(Name ="Endereço")]
        public String Endereco { get; set; }
        [Required]
        public String Telefone { get; set; }
        public String Email { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}