using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckRole(0);

        }

        static void CheckRole(int roleId)
        {
            switch (roleId)
            {
                case (int)roleId.SuperAdmin:
                    Console.WriteLine("Super Admin");
                    break;
                case (int)roleId.Admin:
                    Console.WriteLine("Admin");
                    break;
                case (int)roleId.Member:
                    Console.WriteLine("Member");
                    break;
                default: 
                    Console.WriteLine("Not found role id");
                    break;

            }
        }

        public enum roleId
        {
            SuperAdmin,
            Member,
            Admin
        }
    }
}