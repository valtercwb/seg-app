using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Domain.Entities
{
    public class ApoliceAutomovel
    {
        public int Id { get; set; }
        public string numero { get; set; }
        public Automovel Automovel { get; set; }
        public Segurado Segurado { get; set; }
        public decimal ValorPremio { get; set; }
    }
}
