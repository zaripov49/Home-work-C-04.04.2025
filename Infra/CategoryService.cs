using Domain;

namespace Infra;

public class CategoryService : IService<Category>
{
    private List<Category> categories = new List<Category>();
    public void Create(Category item)
    {
        categories.Add(item);
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category GetById(int id)
    {
        foreach (var item in categories)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null!;
    }
    public Category GetByName(string name)
    {
        foreach (var item in categories)
        {
            if (item.Name == name)
            {
                return item;
            }
        }
        return null!;
    }

    public List<Category> GetByDate(DateTime date)
    {
        foreach (var item in categories)
        {
            if (item.CreatedAt == date)
            {
                return categories;
            }
        }
        return null!;
    }

    public void Delete(int id)
    {
        foreach (var item in categories)
        {
            if (item.Id == id)
            {
                categories.Remove(item);
            }
        }
    }
}
