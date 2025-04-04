using Domain;

namespace Infra;

public class PostService : IService<Post>
{
    private List<Post> posts = new List<Post>();
    public void Create(Post item)
    {
        posts.Add(item);
    }

    public List<Post> GetAll()
    {
        return posts;
    }

    public Post GetById(int id)
    {
        foreach (var item in posts)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null!;
    }
    public Post GetByName(string name)
    {
        foreach (var item in posts)
        {
            if (item.Title == name)
            {
                return item;
            }
        }
        return null!;
    }

    public List<Post> GetByDate(DateTime date)
    {
        foreach (var item in posts)
        {
            if (item.CreatedAt == date)
            {
                return posts;
            }
        }
        return null!;
    }

    public void Delete(int id)
    {
        foreach (var item in posts)
        {
            if (item.Id == id)
            {
                posts.Remove(item);
            }
        }
    }
}
