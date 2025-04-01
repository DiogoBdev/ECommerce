using IMMES.ECommerce.API.Models.Domain;
using IMMES.ECommerce.API.Repositories.Interfaces;

namespace IMMES.ECommerce.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<Category> AddCategory(Category category) 
        {
            throw new NotFiniteNumberException();
        }
    }
}