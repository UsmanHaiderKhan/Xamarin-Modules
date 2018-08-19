using System.Collections.ObjectModel;
using TestXam.DataContext;
using TestXam.Model;

namespace TestXam.ViewModel
{
    public class PersonViewModel
    {
        private ObservableCollection<Person> peoples;
        public ObservableCollection<Person> Person { get { return peoples; } set { peoples = value; } }

        public PersonViewModel()
        {
            Person = new ObservableCollection<Person>();
            PersonContext personcontext = new PersonContext();
            foreach (var people in personcontext.person)
            {
                Person.Add(people);
            }
        }
    }
}
