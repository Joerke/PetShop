using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPetShop.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public Pedido Pedido { get; set; }

    }
}