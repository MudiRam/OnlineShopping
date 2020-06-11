namespace OnlineShopping.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class OnlineShoppingContext : IdentityDbContext
    {
        public OnlineShoppingContext(DbContextOptions<OnlineShoppingContext> options)
        : base(options)
        {
        }
    }
}
