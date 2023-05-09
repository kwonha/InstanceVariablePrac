using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariablePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //자바 스타일
            Product product1 = new Product();
            product1.name = "감자";
            product1.price = 2000;

            //C# 스타일
            Product product2 = new Product() { name = "고구마", price = 2100 };
            Product product3 = new Product() { name = "옥수수" };
            Product product4 = new Product() { price = 999999 };
            Product product5 = new Product { price = 7777, name = "비트" };

            Console.WriteLine(Product.origin);
            Console.WriteLine(product1.name + " / " + product1.price);
            Console.WriteLine(product1);

            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "곽경희", grade = 3 });
            list.Add(new Student() { name = "권하은", grade = 2 });
            list.Add(new Student() { name = "김선혜", grade = 1 });
        }
    }
}
