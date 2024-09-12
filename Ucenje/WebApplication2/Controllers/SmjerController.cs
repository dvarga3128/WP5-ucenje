using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/vi/[Controller]")]
    public class SmjerController:ControllerBase
    {
        //dependency injection
        //1.definirati privatno svojstvo
        private readonly EdunovaContext _context;

        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Smjerovi);
        }

        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBySifra(int sifra)
        {
            return Ok(_context.Smjerovi.Find(sifra));
        }

        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {

            _context.Smjerovi.Add(smjer);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, smjer);

        }

        [HttpPut]
        [Route("{sifra:int}")]
        public IActionResult Put(int sifra, Smjer smjer)
        { 
            var smjerBaza = _context.Smjerovi.Find(sifra);

            smjerBaza.Naziv = smjer.Naziv;
            smjerBaza.Trajanje = smjer.Trajanje;
            smjerBaza.Cijena = smjer.Cijena;
            smjerBaza.IzvodiSeOd = smjer.IzvodiSeOd;
            smjerBaza.Vaucer = smjer.Vaucer;

            _context.Smjerovi.Update(smjerBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "uspješno promijenjeno" });

        }

        [HttpDelete]
        [Route("{sifra:int}")]
        public IActionResult Delete(int sifra, Smjer smjer)
        {
            var smjerBaza = _context.Smjerovi.Find(sifra);

            _context.Smjerovi.Remove(smjerBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "uspješno obrisano" });

        }



    }
}
