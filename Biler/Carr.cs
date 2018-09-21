using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biler
{
    class Carr
    {
        static void Main(string[] args)
        {

        }

        private string _brand;
        private string _model;
        private int _year;
        private bool benzin;  // Encapsulate Field opretter variablen. Gør det meget nemmere
        private String color;
        private String _licensePlate;

        public Carr(String _brand, String _model, int _year)
        {
            _brand = this._brand;
            _model = "Cactus";
            _year = 2015;
        }

        public double Drive() 
        {
            return 1;
        }

        public void Gear()
        {

        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        public string Brand
        {
            get { return _brand; }
        }

        public string Model
        {
            get { return _model; }
        }

        public int Year
        {
            get { return _year; }
        }

        public bool Benzin
        {
            get { return benzin; }
        }
    }
}
