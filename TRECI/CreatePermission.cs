using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRECI
{
    class CreatePermission:IPermission
    {
        public void Allow()
        {
            Console.WriteLine("has create permission");
        }
    }
}
