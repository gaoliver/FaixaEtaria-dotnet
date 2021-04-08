using FaixaEtaria.Validação;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaixaEtaria.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        [Remote("UsuarioExisteAsync", "Pessoas")]
        public string Nome { get; set; }

        [Adultos]
        public int Idade { get; set; }
    }
}
