using Ecommerce.Data;
 
namespace Ecommerce.Models
{
    public class AddCommand : ICommand
    {
        private readonly AppDbContext _context;
        private readonly Category _category;

        public AddCommand(AppDbContext context, Category category)
        {
            _context = context;
            _category = category;
        }

        public void Execute()
        {
            _context.Categories.Add(_category);
            _context.SaveChanges();
        }
    }
}
