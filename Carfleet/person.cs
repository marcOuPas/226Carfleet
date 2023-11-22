using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carfleet
{
    public class Person
    {

        private string _name;
        private string _firstname;
        private string _phonenumber;
        private string _emailaddress;
        private List<string> _languages;


        public Person(string name, string firstname, string phonenumber, string emailaddress, List<string>languages)
        {
            _name = name;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _emailaddress = emailaddress;
            _languages = languages;
 
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set {
                _name = value;
            }

        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
              _firstname=value;
            }

        }

        public string Phonenumber
        {
            get
            {
                return _phonenumber;
            }
            set
            {
                _phonenumber = value;
            }

        }

        public string Emailaddress
        {
            get
            {
                return _emailaddress;
            }
            set
            {
                _emailaddress = value;
            }

        }

        public List<string> Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                _languages = value;
            }

        }
    }

    
}
