using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Machine_components
    {
        public int Machine_componentsId { get; set; }

        public int Sugar { get; set; }

        public int CheckPaper { get; set; }

        public int Cups { get; set; }


        public List<Drink> Drinks { get; set; } = new();
    }
}
