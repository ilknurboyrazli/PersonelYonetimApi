using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonelYonetimApi.Data;
using PersonelYonetimApi.Models;

namespace PersonelYonetimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PersonelController(AppDbContext context)
        {
            _context = context;
        }

        // TÜM PERSONELLERİ GETİR
        [HttpGet]
        public async Task<List<Personel>> PersonelleriGetir()
        {
            return await _context.Personeller.ToListAsync();
        }

        // ID'YE GÖRE TEK PERSONEL GETİR
        [HttpGet("{id}")]
        public async Task<ActionResult<Personel>> PersonelGetir(int id)
        {
            var personel = await _context.Personeller.FindAsync(id);

            if (personel == null)
            {
                return NotFound();
            }

            return personel;
        }

        // YENİ PERSONEL EKLE
        [HttpPost]
        public async Task<ActionResult<Personel>> PersonelEkle(Personel personel)
        {
            _context.Personeller.Add(personel);
            await _context.SaveChangesAsync();

            return Ok(personel);
        }

        // PERSONEL GÜNCELLE
        [HttpPut("{id}")]
        public async Task<IActionResult> PersonelGuncelle(int id, Personel yeniPersonel)
        {
            var personel = await _context.Personeller.FindAsync(id);

            if (personel == null)
            {
                return NotFound();
            }

            personel.Ad = yeniPersonel.Ad;
            personel.Soyad = yeniPersonel.Soyad;
            personel.Departman = yeniPersonel.Departman;
            personel.Maas = yeniPersonel.Maas;

            await _context.SaveChangesAsync();

            return Ok(personel);
        }

        // PERSONEL SİL
        [HttpDelete("{id}")]
        public async Task<IActionResult> PersonelSil(int id)
        {
            var personel = await _context.Personeller.FindAsync(id);

            if (personel == null)
            {
                return NotFound();
            }

            _context.Personeller.Remove(personel);
            await _context.SaveChangesAsync();

            return Ok("Personel başarıyla silindi.");
        }
    }
}