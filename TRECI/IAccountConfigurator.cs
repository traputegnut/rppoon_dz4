using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRECI
{
    public interface IAccountConfigurator
    {
         void AddEditPermission(EditPermission permission);
         void AddDeletePermission(DeletePermission permission);
         void AddCreatePermission(CreatePermission permission);
         void AddViewPermission(ViewPermission permission);
         void ClearPermission();
    }
}
