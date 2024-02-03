namespace Classes.Person
{
    public class Client : Person
    {
        public string CPF; 

        public override string GetDocumentNumber()
        {
            return CPF;
        }
    }
}
