using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Machine
    {
        public int MachineId { get; set; }
        public int Machine_components { get; set; }
        public int Drink_1 { get; set; }
        public int Drink_2 { get; set; }
        public int Drink_3 { get; set; }
        public int Drink_4 { get; set; }
        public List<Machine_component> Components { get; set; } = new();
        public List<Drink> Drinks { get; set; } = new();
    }
}
