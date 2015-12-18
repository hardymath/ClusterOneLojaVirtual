﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClusterOne.LojaVirtual.Dominio.Repositorio;

namespace ClusterOne.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {

        private ProdutosRepositorio _repositorio;

        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(3);

            return View(produtos);
        }
    }
}