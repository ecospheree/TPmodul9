using Microsoft.AspNetCore.Mvc;

namespace TPmodul9
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa("Nabiel Prayoga Budiana", "1302210049"),
            new Mahasiswa("Walid Hanif Ataullah", "1302213120"),
            new Mahasiswa("Muhammad Raffa Zuhayr", "1302210068"),
            new Mahasiswa("Muhammad Yaasin Rafi", "1302210055"),
            new Mahasiswa("Sylvana Rheina Kharmeliawaty", "1302210017")
        };
        //membuat get di controller
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        //menambahkan object 
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswas.Add(value);
        }

        //get sesuia index
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswas[id];
        }

        //untuk mengahapus index
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}
