using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiff_uebung
{
    public class Schiff
    {

        public string Title { get; set; }
        public double Shipweight { get; set; }

        public string ShipName { get; set; }

        List<Container> _container = new();

        public Schiff(string title)
        {
            this.Title = title;
        }
        public Schiff(double weight, string name) 
        {
            Shipweight = weight;
            ShipName = name;
        }
        public void Add(Container container)
        {
            _container.Add(container);
        }

        public double Gesamtgewicht()
        {
            double summe = 0;
            for(int i = 0; i < _container.Count; i++)
            {
                summe = summe + _container[i].Weight;
            }
            


            return Shipweight + summe;
        }
    }
}
