using Microsoft.AspNetCore.Rewrite.Internal.IISUrlRewrite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public double SalarioBase { get; set; }
        public Departamentos Departamentos { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor() {

        }

        public Vendedor(int id, string nome, string email, DateTime dataAniversario, double salarioBase, Departamentos departamentos) {
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            SalarioBase = salarioBase;
            Departamentos = departamentos;
        }

        public void AdicionaVenda(RegistroVendas rv) {
            Vendas.Add(rv);
        }

        public void RemoveVenda(RegistroVendas rv) {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicio, DateTime final) {

            return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= final).Sum(rv => rv.Montante);

        }


    }
}
