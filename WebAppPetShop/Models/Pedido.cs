using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPetShop.Models
{
    public class Pedido
    {
        public int PedidosId { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}