using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;


namespace DIVTECH2.Models
{
    public class FornecedorModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage ="É necessário no minímo 100 caracters")]
        public string Nome { get; set; }

        [RegularExpression(@"^\d{14}$", ErrorMessage = "O CNPJ deve conter exatamente 14 dígitos.")]
        [StringLength(14)]
        public string CNPJ { get; set; }
        public string Especialidade { get; set; }

        [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve conter exatamente 8 dígitos.")]
        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(255, ErrorMessage ="É necessário no minímo 255 caracters")]
        public string Endereco { get; set; }
    }
}