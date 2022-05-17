namespace TrampoWarren.Models
{
    public class Customer
    {
        public Customer() { }
        public Customer(int Id, string nome, string email, string emailConfirmation, string cpf, string cellPhone, DateTime birthdate, Boolean emailSms, Boolean whatsapp, string country, string city, string postalcode, string address, string number)
        {
            this.Id = Id;
            this.Nome = nome;
            this.Email = email;
            this.EmailConfirmation = emailConfirmation;
            this.Cpf = cpf;
            this.CellPhone = cellPhone;
            this.BirthDate = birthdate;
            this.EmailSms = emailSms;
            this.Whatsapp = whatsapp;
            this.Country = country;
            this.City = city;
            this.PostalCode = postalcode;
            this.Address = address;
            this.Number = number;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string EmailConfirmation { get; set; }
        public string Cpf { get; set; }
        public string CellPhone { get; set; }
        public DateTime BirthDate { get; set; }
        public Boolean EmailSms { get; set; }
        public Boolean Whatsapp { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }


    }
}

