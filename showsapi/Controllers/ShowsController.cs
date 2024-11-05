using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using showsapi.Interfaces;
using showsapi.Models;
using showsapi.ViewModels;
using showsapi.Mappers;
using AutoMapper;
using System.Runtime.CompilerServices;

namespace showsapi.Controllers
{
    [ApiController]
    [Route("api/Shows")]
    public class ShowsController : ControllerBase
    {

        private readonly IShowsInterface _showsinterface;
        private readonly IMapper _mapper;

        public ShowsController(IShowsInterface showsinterface, IMapper mapper){
            _showsinterface = showsinterface;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> Add([FromBody] ShowsViewModel showsviewmodel){
            
            var mapper = _mapper.Map<Shows>(showsviewmodel);
            await _showsinterface.create(mapper);
           
            return Ok();
           
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll(){
            var shows = await _showsinterface.getAll();  
            if(shows != null){ 
            return Ok(shows);
            }else{
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}/update")]
        public async Task<IActionResult> Update(ShowsViewModel shows,int id){
            var mapper = _mapper.Map<Shows>(shows);
            var show = await _showsinterface.update(mapper,id);
            return Ok(show);
        }

        [HttpDelete]
        [Route("{id}/delete")]
        public async Task<IActionResult> Delete(int id){
            var shows = await _showsinterface.delete(id);
            if(_showsinterface.get(id) != null)
            {
                return Ok();
            }else{
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id){
            var show = await _showsinterface.get(id);
            return Ok(show);
        }
    }
}