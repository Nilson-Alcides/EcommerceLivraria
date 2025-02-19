﻿using AppLivraria_TsT.Models.DAO;
using AppLivraria_TsT.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLivraria_TsT.Models.DLL
{
    public class Pedido_DLL
    {
        Pedido_DAO dal = null;
        public Pedido_DLL() { }

        //Inserir Pedido
        public void novoPedido(Pedido_DTO pedido)
        {
            try
            {
                dal = new Pedido_DAO();
                dal.inserirPedido(pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //SELECIONAR Pedido por ID
        public List<Pedido_DTO> listaPedidoPorID()
        {
            try
            {
                dal = new Pedido_DAO();
                return dal.buscaPedidoPorId();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Faturar Pedido
        public void alteraPedidoFaturar(string id)
        {
            try
            {
                dal = new Pedido_DAO();
                dal.updatePedidoFaturar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        //Cancelar Pedido
        public void alteraPedidoCancelar(string id)
        {
            try
            {
                dal = new Pedido_DAO();
                dal.updatePedidoCancelar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Completar Pedido
        public void alteraPedidoCompletar(string id)
        {
            try
            {
                dal = new Pedido_DAO();
                dal.updatePedidoCompletar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pedido_DTO> listaPedido()
        {
            try
            {
                dal = new Pedido_DAO();
                return dal.selectListPedido();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Pedido_DTO> listaPedidoRetirado()
        {
            try
            {
                dal = new Pedido_DAO();
                return dal.selectListPedidoRetirados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}