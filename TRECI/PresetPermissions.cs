using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRECI
{
    class PresetPermissions:IAccountConfigurator
    {
        public void Admin(IAccountConfigurator configurator)
        {
            configurator.AddCreatePermission(new CreatePermission());
            configurator.AddDeletePermission(new DeletePermission());
            configurator.AddViewPermission(new ViewPermission());
            configurator.AddEditPermission(new EditPermission());
        }

        public void User(IAccountConfigurator configurator)
        {
            configurator.AddViewPermission(new ViewPermission());

        }
        public void Manager(IAccountConfigurator configurator)
        {
            configurator.AddCreatePermission(new CreatePermission());
            configurator.AddEditPermission(new EditPermission());
            configurator.AddViewPermission(new ViewPermission());

        }
    }
}
