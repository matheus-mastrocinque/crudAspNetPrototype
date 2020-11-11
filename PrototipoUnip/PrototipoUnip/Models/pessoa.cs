using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrototipoUnip.Models
{
    public class pessoa
    {
        [Key]
        public int codigo { get; set; }
        public string nome { get; set; }

        public string cpf { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }

    }
}