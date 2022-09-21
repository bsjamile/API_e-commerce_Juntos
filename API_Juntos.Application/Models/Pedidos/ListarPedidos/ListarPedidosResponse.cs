using API_Juntos.Core.Entidades;
using System;
using System.Collections.Generic;

namespace API_Juntos.Application.Models.Pedidos.ListarPedidos
{
    public class ListarPedidosResponse
    {
        public int IdPedido { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public List<ProdutosDoPedido> ProdutosDoPedido { get; set; }
        public int IdCliente { get; set; }
    }
}
