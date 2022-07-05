using System;

namespace UPCASTING__DOWNCASTING
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            GetElements(1, 2, 3, 4, 5, 8, 9, 9);


            CheckRole(1);

        }

        private static void CheckRole(int v)
        {
            throw new NotImplementedException();
        }

        public static void GetElements(params int[] nums)
        {
            foreach (var item in nums)
            {
                Console.WriteLine(item);


                static void CheckRole(int roleId)
                {
                    switch (roleId)
                    {
                        case (int)Roles.SuperAdmin:
                            Console.WriteLine("Super admin");
                            break;
                        case (int)Roles.Admin:
                            Console.WriteLine("Admin");
                            break;
                        case (int)Roles.Member:
                            Console.WriteLine("Member");
                            break;
                        default:
                            Console.WriteLine("Not found role id");
                            break;
                    }
                }
            }
        }
        public enum Roles
        {
            SuperAdmin,
            Admin,
            Member,
        }
    }
