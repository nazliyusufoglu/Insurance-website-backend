using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {
        private IMusteriTableService _musteriTableService;

        public MusteriController(IMusteriTableService musteriTableService)
        {
            _musteriTableService = musteriTableService;
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _musteriTableService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbytckn")]
        public IActionResult GetByTCKN(string TCKN)
        {
            var result = _musteriTableService.GetByTCKN(TCKN);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(MusteriTable musteri)
        {
            var result = _musteriTableService.Add(musteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(MusteriTable musteri)
        {
            var result = _musteriTableService.Update(musteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(string id)
        {
            var musteri = new MusteriTable { TCKN = id };
            var result = _musteriTableService.Delete(musteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
