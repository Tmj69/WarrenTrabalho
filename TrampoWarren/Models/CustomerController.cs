using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace TrampoWarren.Models
{
    public class CustomerController
    {
        [ApiController]
        public class AlunoController : ControllerBase
        {
            public List<Afiliados> Afiliados = new List<Afiliados>()
        {
            new Afiliados()
            {
                Id = 1,
                Nome = "Marcos Tilo",
                Email = "abc@gmail.com",
                Cpf = "123",
                CellPhone = "47 0000",
                EmailSms = true,
                Whatsapp = false,
                Country = "Brasil",
                City = "Blumenau",
                PostalCode = "068",
                Address = "Rua dos Cria",
                Number = "574"


            },
            new Afiliados()
            {
                Id = 2,
                Nome = "Marta Tilo",
                Email = "cde@gmail.com",
                Cpf = "123",
                CellPhone = "47 1111",
                EmailSms = true,
                Whatsapp = false,
                Country = "Brasil",
                City = "Balneario Camburiu",
                PostalCode = "213",
                Address = "Rua dos Cria",
                Number = "574"


            },
            new Afiliados()
            {
                Id = 3,
                Nome = "Maria Tilo",
                Email = "efg@gmail.com",
                Cpf = "669",
                CellPhone = "47 2222",
                EmailSms = true,
                Whatsapp = false,
                Country = "Brasil",
                City = "Joinvile",
                PostalCode = "068",
                Address = "Rua dos Cria",
                Number = "574"
            }
        };
        public AlunoController() { }

        public IActionResult Get()
        {
            return Ok(Afiliados);
        }


        }
    }
}
