using Classes.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Person
{
    public class Broker : Person
    {
        public Broker(string name, DateTime birthDate, string cnpj)
        {
            Name = name;
            BirthDate = birthDate;
            CNPJ = cnpj;
        }

        private string CNPJ { get; set; }
        public int BrokerId { get; set; }

        public override string GetDocumentNumber()
        {
            return CNPJ;
        }

        public void SellInsurace()
        {
            //...
        }

    }
}
