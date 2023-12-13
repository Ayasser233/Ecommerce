using Ecommerce.Data;
using Ecommerce.Models;
 
namespace Ecommerce.Models
{
    public class DeleteCommand : ICommand
    {
        private readonly AppDbContext _context;
        private readonly Category _category;

        public DeleteCommand(AppDbContext context, Category category)
        {
            _context = context;
            _category = category;
        }

        public void Execute()
        {
            _context.Categories.Remove(_category);
            _context.SaveChanges();
        }
    }
}
