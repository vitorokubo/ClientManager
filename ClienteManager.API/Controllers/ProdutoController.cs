using ClientManager.Application.DTOs;
using ClientManager.Application.Interfaces;
using ClientManager.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClienteManager.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdutoDTO>>> Get()
        {
            var produtos = await _produtoService.GetProdutos();
            if (produtos == null)
            {
                return NotFound("Produtos not found");
            }
            return Ok(produtos);
        }

        [HttpGet("{id:int}", Name = "GetCategory" )]
        public async Task<ActionResult<ProdutoDTO>> Get(int id)
        {
            var produto = await _produtoService.GetById(id);
            if (produto == null)
            {
                return NotFound("Produto not found");
            }
            return Ok(produto);
            
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProdutoDTO produtoDTO)
        {
            if (produtoDTO == null) return BadRequest("Invalid Data");

            await _produtoService.Add(produtoDTO);

            return new CreatedAtRouteResult("GetCategory", new { id = produtoDTO.Id }, produtoDTO);

        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] ProdutoDTO produtoDTO)
        {
            if (id != produtoDTO.Id) return BadRequest();

            if (produtoDTO == null) return BadRequest();

            await _produtoService.Update(produtoDTO);

            return Ok(produtoDTO);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var produto = await _produtoService.GetById(id);
            if (produto == null)
            {
                return NotFound("Produto not found");
            }
            await _produtoService.Remove(id);
            return Ok(produto);
        }
    }
}
