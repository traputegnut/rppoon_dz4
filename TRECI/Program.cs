using System;

namespace TRECI
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccountConfigurator accountConfiguartor = new ConcreteAccountConfigurator();
            PresetPermissions presetPermissions = new PresetPermissions();
            Console.WriteLine("admin permission setuup...");
            presetPermissions.Admin(accountConfiguartor);
            Console.WriteLine();
        }
    }
}
