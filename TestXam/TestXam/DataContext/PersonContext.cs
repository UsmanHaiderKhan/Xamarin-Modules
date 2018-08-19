using System.Collections.Generic;
using TestXam.Model;

namespace TestXam.DataContext
{
    public class PersonContext
    {
        public List<Person> person = new List<Person>()
        {
            new Person
            {
                Id=1,
                Name="Usman Khan",
                Origin="Northen"
            }
            ,
             new Person
            {
                Id=2,
                Name="Salman Khan",
                Origin="Eastern"
            }
            ,
             new Person
            {
                Id=3,
                Name="Arslan Ameer",
                Origin="Western"
            }
               ,
             new Person
            {
                Id=4,
                Name="Ahmand khan",
                Origin="Western"
            }
        };
    }
}
