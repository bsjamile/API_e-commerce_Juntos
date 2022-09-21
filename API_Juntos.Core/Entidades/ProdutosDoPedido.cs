﻿using System.Collections.Generic;

namespace API_Juntos.Core.Entidades
{
    public class ProdutosDoPedido
    {
        public ProdutosDoPedido(int idProduto, int quantidade)
        {
            IdProduto = idProduto;
            Quantidade = quantidade;
        }
        public int IdProdutosDoPedido { get; set; } 
        public int Quantidade { get; set; } 
        public decimal ValorTotal { get; set; } 
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }        
    }
}