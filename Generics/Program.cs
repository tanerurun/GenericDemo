internal class Program
{
    private static void Main(string[] args)
    {
        Utilities utilities = new Utilities();
        List<string> result = utilities.BuildList<string>("Sirnak", "Van", "Hakkari");
        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] data)
        {
            return new List<T>(data);
        }
    }

    class Product : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
    class Customer : IEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string City { get; set; }

    }
    interface IProductDal : IRepository<Product>
    {

    }
    class ProductDal : IProductDal
    {
        IProductDal productDal = new ProductDal();
        public void Add(Product item)
        {
            productDal.Add(item);
        }

        public void Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
    interface ICustomerDal : IRepository<Customer>
    {


    }

    interface IEntity
    {

    }

    interface IRepository<T> where T : class, IEntity, new()
    {
        T GetById(int id);
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}