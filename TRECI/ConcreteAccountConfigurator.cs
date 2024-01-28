using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRECI
{
    class ConcreteAccountConfigurator:IAccountConfigurator
    {

        private Result result = new Result();
        public void ClearPermission(ClearPermission permission)
        {
            Console.WriteLine("has clear permission");
        }
        public void AddEditPermission(EditPermission permission)
        {
            result.Add(permission);
            Console.WriteLine("has edit permission");
        }
        public void AddDeletePermission(DeletePermission permission)
        {
            result.Add(permission);
            Console.WriteLine("has delete permisson");
        }
        public void AddCreatePermission(CreatePermission permission)
        {
            result.Add(permission);
            Console.WriteLine("has create permissin");
        }
        public void AddViewPermission(ViewPermission permission)
        {
            result.Add(permission);
            Console.WriteLine("has view permission");
        }

    
    }
}
