using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes

        private string _workZone;
        private List<string> _languages;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, List<string> languages, string workZone = ""):base(name, firstname, phonenumber, emailaddress, languages)
        {

        }

        public string WorkZone
        {
            get
            {
                return _workZone;
            }

        }

        #endregion public methods
    }
}
