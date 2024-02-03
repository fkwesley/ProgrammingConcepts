namespace Classes.Person
{
    public abstract class Person    //this entity should not be used, it's only an abstraction
    {
        //Atributtes
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        //Methods already implemented (default for all type of people)
        public int GetAge()
        {
            DateTime today = DateTime.Today; 
            int age = today.Year - BirthDate.Year;

            //checking if the birthdate already passed this year
            if (BirthDate > today.AddYears(-age))
                age--;

            return age;
        }

        //Methods not implemented (sub-classes must implement following the same template)
        public abstract string GetDocumentNumber();

    }

}
