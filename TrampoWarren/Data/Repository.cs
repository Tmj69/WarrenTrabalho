using TrampoWarren.Models;

namespace TrampoWarren.Data
{
    public class Repository : IRepository
    {
        public List<Customer> Clients { get; set; } = new List<Customer>();

        public void add( Customer customer)
        {
            int LastId = 0;
            if(Clients.Count == 0)
            {
                customer.Id = LastId + 1;
                Clients.Add(customer);
            }
            else
            {
                LastId = Clients.Last().Id;
                customer.Id = LastId + 1;
                Clients.Add(customer);
            }

        }

        public void Delete(Customer customer)
        {
            Clients.Remove(customer);
        }

        public void Update(Customer customer, Customer customerUp) 
        { 
            customer.Nome = customerUp.Nome;
            customer.Email = customerUp.Email;
            customer.EmailConfirmation = customerUp.EmailConfirmation;
            customer.Cpf = customerUp.Cpf;
            customer.CellPhone = customerUp.CellPhone;
            customer.BirthDate = customerUp.BirthDate;
            customer.EmailSms = customerUp.EmailSms;
            customer.Whatsapp = customerUp.Whatsapp;
            customer.Country = customerUp.Country;
            customer.City = customerUp.City;
            customer.PostalCode = customerUp.PostalCode;
            customer.Address = customerUp.Address;
            customer.Number = customerUp.Number;
        }
        public List<Customer> MeetId(int id)
        {
            var customer = Clients.FindAll(x => x.Id == id);
            if(customer.Count is 0)
            {
                return null;
            }
            return customer;
        }

        public List<Customer> MeetName(string name)
        {
            var customer = Clients.FindAll(x => x.Nome == name);
            if (customer.Count is 0)
            {
                return null;
            }
            return customer;
        }

        public List<Customer> MeetEmail(string email)
        {
            var customer = Clients.FindAll(x => x.Email == email);
            if (customer.Count is 0)
            {
                return null;
            }
            return customer;
        }

        public List<Customer> MeetCpf(string cpf)
        {
            var customer = Clients.FindAll(x => x.Cpf == cpf);
            if (customer.Count is 0)
            {
                return null;
            }
            return customer;
        }
    }
}