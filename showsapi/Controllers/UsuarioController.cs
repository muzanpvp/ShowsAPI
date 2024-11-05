using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using showsapi.Interfaces;
using showsapi.Models;
using showsapi.ViewModels;

namespace showsapi.Controllers
{
    [ApiController]
    [Route("api/Usuario")]
    public class UsuarioController : ControllerBase
    {
        
        private readonly IUsuarioInterface _usuariointerface;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioInterface usuariointerface, IMapper mapper){
            _usuariointerface = usuariointerface;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> Add([FromBody] UsuarioViewModel usuarioviewmodel){
            
            var mapper = _mapper.Map<Usuario>(usuarioviewmodel);
            await _usuariointerface.create(mapper);
           
            return Ok();
           
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll(){
            var usuarios = await _usuariointerface.getAll();  
            if(usuarios != null){ 
            return Ok(usuarios);
            }else{
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}/update")]
        public async Task<IActionResult> Update(UsuarioViewModel usuario,int id){
            var mapper = _mapper.Map<Usuario>(usuario);
            var usuarioModel = await _usuariointerface.update(mapper,id);
            return Ok(usuarioModel);
        }

        [HttpDelete]
        [Route("{id}/delete")]
        public async Task<IActionResult> Delete(int id){
            var shows = await _usuariointerface.delete(id);
            if(_usuariointerface.get(id) != null)
            {
                return Ok();
            }else{
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id){
            var show = await _usuariointerface.get(id);
            return Ok(show);
        }
    }
}