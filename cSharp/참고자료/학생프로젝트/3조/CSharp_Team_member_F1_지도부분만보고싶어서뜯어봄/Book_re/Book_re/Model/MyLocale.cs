using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_re.Model
{
    public class MyLocale
    {


        public string Name

        {

            get;

            private set;

        }

        public double Lat

        {

            get;

            private set;

        }



        public double Lng

        {

            get;

            private set;

        }



        public MyLocale(string name, double lat, double lng)

        {

            Name = name;

            Lat = lat;

            Lng = lng;

        }

        public override string ToString()

        {

            return Name;

        }

    }
}
