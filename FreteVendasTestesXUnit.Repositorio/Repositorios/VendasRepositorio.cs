﻿using FreteVendasTestesXUnit.Entidades.Entidades;
using FreteVendasTestesXUnit.Repositorio.Interfaces;

namespace FreteVendasTestesXUnit.Repositorio.Repositorios
{
    public class VendasRepositorio : IVendasRepositorio
    {
        public IList<Vendas> BuscarVendas(short mes, short ano)
        {
            #region Criação das instâncias

            var novaVenda1 = new Vendas()
            {
                Data = new DateTime(2021, 04, 02),
                Valor = 500.00m
            };

            var novaVenda2 = new Vendas()
            {
                Data = new DateTime(2021, 04, 15),
                Valor = 50.00m
            };

            var novaVenda3 = new Vendas()
            {
                Data = new DateTime(2021, 04, 20),
                Valor = 353.50m
            };

            var listaVendas = new List<Vendas>()
            {
                novaVenda1,
                novaVenda2,
                novaVenda3
            };

            #endregion

            List<Vendas> resultado = [];

            resultado = listaVendas.Where(l => l.Data.Month == mes).ToList();

            if (resultado is not null && resultado.Count != 0)
            {
                return resultado;
            }
            else
            {
                return [];
            }
        }
    }
}
