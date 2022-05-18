using System;

namespace Properties
{
    public class Person
    {
        //FIELD
        public int height;

        public int getHeight()
        {
            return height;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        //Property to access field
        public int Height { get; set; }


        //Auto-implemented properties
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; set; }


        public Person()
        {
        }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }




        //Calculated properties
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }            
        }
    }
}
