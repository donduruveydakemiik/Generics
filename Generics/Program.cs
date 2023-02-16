using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.örnek

            Utilities utilities = new Utilities(); // METODLARIN OLDUĞU SINIF
            List<string> list = utilities.BuildList("ANKARA", "İSTANBUL", "AYDIN"); //BuildList diye metod oluşturduk.
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // 2.örnek

            List<Customer> customers = utilities.BuildList<Customer>(new Customer() { Name = "Rüveyda" }, new Customer() { Name = "Nihal" });

            foreach (var customer in customers) 
            {
                Console.WriteLine(customer.Name);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] values) // liste olarak T türünde değerler
        {
            return new List<T>(values); //yeni liste döndürecek
        }


    }
    class Customer : IEntity
    {
        public string Name { get; set; }
    } 
    class CustomerDal : IRepository<Customer>
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    class Product : IEntity
    {

    }

    class ProductDal : IRepository<Product>
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    interface IEntity
    {

    }
        
    interface IRepository<T> where T : class, IEntity, new() //T nesnesi Generics Kısıtlaması yapılmıştır.
    {
        List<T> GetAll();
        T Get(int id);
        void Update(T entity);
        void Delete(T entity);
        void Add(T entity);

    }
}
