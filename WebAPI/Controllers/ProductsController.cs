using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled
        IProductService _productService;
        //interface dışındakilere bağlantı kurma
        //IoC Container -- Inversion of Control
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(5000);

            var result = _productService.GetAll();
            if (result.Success)
            {
                //return Ok(result.Data);
                return Ok(result);
            }
            //return BadRequest(result.Message);
            return BadRequest(result);
        }
        //public List<Product> Get()
        //{

        //    var result =  _productService.GetAll();
        //    return result.Data;
        //}
        //public string GetMessage()
        //{
        //    IProductService productServicce = new ProductManager(new EfProductDal());
        //    var result = productServicce.GetAll();
        //    return result.Message;
        //}

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
