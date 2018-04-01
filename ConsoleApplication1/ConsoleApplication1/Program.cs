using System;
using System.Reflection;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            // Get the Type Using GetType() static method
            Type T = Type.GetType("Pragim.Customer");

            Customer c2 = new Customer();
            Type T1 = c2.GetType(); //get type when you have just the object 
            // Print the Type details
            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the Class Name = {0}", T.Name);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
            Console.WriteLine();
            // Print the list of Methods
            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                // Print the Return type and the name of the method
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine();
            //  Print the Properties
            Console.WriteLine("Properties in Customer Class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                // Print the property type and the name of the property
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();
            //  Print the Constructors
            Console.WriteLine("Constructors in Customer Class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }


        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }


        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}


/*
 * Reflection is the ability of inspecting an assembly metadata at runtime. It is used to find all 
 * types in an assembly and/or dynamically invoke methods in an assembly
 * 
 * Use ofd reflection
 * late binding
 * 
 * OUTPUT:
 * 
 * Full Name = Pragim.Customer
Just the Class Name = Customer
Just the Namespace = Pragim

Methods in Customer Class
Int32 get_Id
Void set_Id
String get_Name
Void set_Name
Void PrintID
Void PrintName
String ToString
Boolean Equals
Int32 GetHashCode
Type GetType

Properties in Customer Class
Int32 Id
String Name

Constructors in Customer Class
Void .ctor(Int32, System.String)
Void .ctor()
Press any key to continue . . .



 */

