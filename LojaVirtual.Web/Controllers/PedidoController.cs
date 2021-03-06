﻿using Microsoft.AspNetCore.Mvc;
using LojaVirtual.Dominio.Contratos;
using LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Web.Controllers
{
    [Route("api/[Controller]")]
    public class PedidoController: Controller
    {
        private IPedidoRepositorio _pedidoRepositorio;

        public PedidoController(IPedidoRepositorio pedidoRepositorio)
        {
            this._pedidoRepositorio = pedidoRepositorio;
        }
        [HttpPost]
        public IActionResult Post([FromBody]Pedido pedido)
        {

            try
            {
                _pedidoRepositorio.Adicionar(pedido);
                return Ok(pedido.Id);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }
}
