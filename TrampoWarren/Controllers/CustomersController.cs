using Microsoft.AspNetCore.Mvc;
using TrampoWarren.Data;
using TrampoWarren.Models;

namespace TrampoWarren.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    { 

        private readonly IRepository _repository;
        public CustomersController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Clients);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetId(int id)
        {
            return SafeAction(() =>
            {
                var Id = _repository.Clients.Find(x => x.Id.Equals(id));
                if (Id is null) return NotFound($"Error 404 // Client not found! for id: {id}");
                return Ok(Id);
            });
        }

        [HttpGet("getByName/{name}")]
        public IActionResult GetName(string name)
        {
            return SafeAction(() =>
            {
                var Name = _repository.Clients.FindAll(x => x.Nome.Equals(name));
                if (Name is null) return NotFound($"Error 404 // Client not found! for name: {name}");
                return Ok(Name);
            });

        }

        [HttpGet("getByEmail/{email}")]
        public IActionResult GetEmail(string email)
        {
            return SafeAction(() =>
            {
                var Email = _repository.Clients.FindAll(x => x.Email.Equals(email));
                if (Email is null) return NotFound($"Error 404 // Client not found! for email: {email}");
                return Ok(Email);
            });

        }

        [HttpGet("getByCpf/{cpf}")]
        public IActionResult GetCpf(string cpf)
        {
            return SafeAction(() =>
            {
                var Cpf = _repository.Clients.FindAll(x => x.Cpf.Equals(cpf));
                if (Cpf is null) return NotFound($"Error 404 // Client not found! for cpf: {cpf}");
                return Ok(Cpf);
            });

        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            _repository.add(customer);
            return Created("~api/customer", "Your registration was successfully created, ID: " + customer.Id);
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int id, Customer customer)
        {
            var customerUpdate = _repository.Clients.FirstOrDefault(x => x.Id == id);
            if (customerUpdate == null) return NotFound($"ERROR: 404 // There is no such id {id} in the list.");
            _repository.Update(customerUpdate, customer);
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, Customer customer)
        {
            var customerDelete = _repository.Clients.FirstOrDefault(x => x.Id == id);
            if (customerDelete == null) return NotFound($"ERROR: 404 // The id {id} was not found in the list");
            _repository.Delete(customerDelete);
            return Ok("This user has been successfully deleted");
        }

        private IActionResult SafeAction(Func<IActionResult> action)
        {
            try
            {
                return action?.Invoke();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
