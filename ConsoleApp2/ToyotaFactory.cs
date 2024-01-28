using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ToyotaFactory:CarFactory
    {
        public override Toyota BuildACar()
        {
            return new Toyota();
        }
    }
}
