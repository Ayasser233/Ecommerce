using Ecommerce.Data;
using Ecommerce.Models;

namespace Ecommerce.Models
{
    public class UpdateCommand : ICommand
    {
        private readonly AppDbContext _context;
        private readonly Category _category;

        public UpdateCommand(AppDbContext context, Category category)
        {
            _context = context;
            _category = category;
        }

        public void Execute()
        {
            _context.Categories.Update(_category);
            _context.SaveChanges();
        }
    }
}
