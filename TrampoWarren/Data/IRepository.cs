using TrampoWarren.Models;

namespace TrampoWarren.Data
{
    public interface IRepository
    {
        List<Customer> Clients { get; set; }

        void add(Customer customer);
        void Delete(Customer customer);
        List<Customer> MeetCpf(string cpf);
        List<Customer> MeetEmail(string email);
        List<Customer> MeetId(int id);
        List<Customer> MeetName(string name);
        void Update(Customer customer, Customer customerUp);
    }
}