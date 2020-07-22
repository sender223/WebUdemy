using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();


        public Departamentos() {

        }

        public Departamentos(int id, string nome) {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Vendedor vendedor) {
            Vendedor.Add(vendedor);
        }

        public double TotalVendas(DateTime inicial, DateTime final) {
            return Vendedor.Sum(vendedor => vendedor.TotalVendas(inicial, final));
        }






    }
}
