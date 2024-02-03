namespace Classes.Person
{
    public class Insurer : Person
    {
        public Insurer(string name, DateTime birthDate, string cpf) 
        { 
            Name = name;
            BirthDate = birthDate;
            CPF = cpf;
        }
        
        private string CPF { get; set; }
        public int InsurerId { get; set; }
        
        public override string GetDocumentNumber()
        {
            return CPF;
        }

        public bool BuyInsurace()
        {
            return true;
        }
    }
}
