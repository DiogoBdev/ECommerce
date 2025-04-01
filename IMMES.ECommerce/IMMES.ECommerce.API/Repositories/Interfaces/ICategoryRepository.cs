using IMMES.ECommerce.API.Models.Domain;

namespace IMMES.ECommerce.API.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> AddCategory(Category category);
    }
}
