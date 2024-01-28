using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRECI
{
    class Result
    {
        List<IPermission> permissions = new List<IPermission>();
        public void Add(IPermission permission)
        {
            permissions.Add(permission);
        }
        public void Remove(IPermission permission)
        {
            permissions.Remove(permission);
        }
    }
}
