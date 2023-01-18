namespace WebApiApplication.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<string> GetAll()
        {
            return new List<string>()
            {
                "hasan","yusuf","huseyin","tuba"
            };
        }
    }
}
