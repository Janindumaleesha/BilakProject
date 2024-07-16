using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilakProject
{
    public class Data
    { 
        private static Data _instance;

        public static Data instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Data();
                return _instance;
            }

            set { _instance = value; }
        }

        public string name { get; set; }
    }
}
