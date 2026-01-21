using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Data;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Loais : ControllerBase
    {
        private readonly MyDBContext _context;

        public Loais(MyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var loais = _context.Loais.ToList();
            return Ok(loais);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var loai = _context.Loais.Find(id);
            if (loai == null)
            {
                return NotFound();
            }
            return Ok(loai);
        }
        [HttpPost]
        public IActionResult CreateNew(LoaiModel model)
        {
            try
            {

                var loai = new Loai
                {
                    TenLoai = model.TenLoai
                };

                _context.Add(loai);
                _context.SaveChanges();
                return Ok(loai);

            }
            catch

            {
                return BadRequest();

            }
        }
    }
}
