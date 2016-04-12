using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia
{
    class Animal : ITaxonomy
    {
        private string _name = "";
        private string _food = "";
 
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string food
        {
            get
            {
                return _food;
            }
            set
            {
                if (value != "")
                {
                    _food = value;
                }
            }
        }

        public string Genus
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Species
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string CommonName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Animal(string name)
        {
            _name = name;
        }

        public virtual void eat(string food)
        {
            _food = food;
            Console.WriteLine("Currently eating {0}", food);
        }
    }
}
