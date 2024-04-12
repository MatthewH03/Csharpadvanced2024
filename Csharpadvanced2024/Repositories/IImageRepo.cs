using Csharpadvanced2024.Models;

namespace Csharpadvanced2024.Repositories
{
    public interface IImageRepo
    {
        IEnumerable<Image> GetAll();
    }
}
