using Domain;
using Infra;

PostService postService = new PostService();
var ps1 = new Post { Id = 1, Title = "Title1", Description = "Description1", CreatedAt = new DateTime(2025, 4, 4), CategoryId = 1 };
var ps2 = new Post { Id = 2, Title = "Title2", Description = "Description2", CreatedAt = new DateTime(2025, 4, 4), CategoryId = 2 };
var ps3 = new Post { Id = 3, Title = "Title3", Description = "Description3", CreatedAt = new DateTime(2025, 4, 4), CategoryId = 3 };
var ps4 = new Post { Id = 4, Title = "Title4", Description = "Description4", CreatedAt = new DateTime(2025, 4, 4), CategoryId = 4 };
postService.Create(ps1);
postService.Create(ps2);
postService.Create(ps3);
postService.Create(ps4);

foreach (var item in postService.GetAll())
{
    System.Console.WriteLine($"{item.Id}, {item.Title} {item.Description} {item.CreatedAt} {item.CategoryId}");
}

System.Console.WriteLine($"\n{postService.GetById(2).Id} {postService.GetById(2).Title} {postService.GetById(2).Description} {postService.GetById(2).CreatedAt} {postService.GetById(2).CategoryId}");
System.Console.WriteLine($"{postService.GetByName("Title1").Id} {postService.GetByName("Title1").Title} {postService.GetByName("Title1").Description} {postService.GetByName("Title1").CreatedAt} {postService.GetByName("Title1").CategoryId} \n");


foreach (var item in postService.GetByDate(new DateTime(2025, 4, 4)))
{
    System.Console.WriteLine($"{item.Id}, {item.Title} {item.Description} {item.CreatedAt} {item.CategoryId}");
}

postService.Delete(3);




System.Console.WriteLine("\n\n");

CategoryService categoryService = new CategoryService();
var cat1 = new Category { Id = 1, Name = "Alisher", CreatedAt = new DateTime(2024, 4, 4) };
var cat2 = new Category { Id = 2, Name = "Yusuf", CreatedAt = new DateTime(2024, 4, 4) };
var cat3 = new Category { Id = 3, Name = "Umar", CreatedAt = new DateTime(2024, 4, 4) };
var cat4 = new Category { Id = 4, Name = "Bezhan", CreatedAt = new DateTime(2024, 4, 4) };
categoryService.Create(cat1);
categoryService.Create(cat2);
categoryService.Create(cat3);
categoryService.Create(cat4);

foreach (var item in categoryService.GetAll())
{
    System.Console.WriteLine($"{item.Id}, {item.Name} {item.CreatedAt}");
}

System.Console.WriteLine($"\n{categoryService.GetById(2).Id} {categoryService.GetById(2).Name} {categoryService.GetById(2).CreatedAt}");
System.Console.WriteLine($"{categoryService.GetByName("Alisher").Id} {categoryService.GetByName("Alisher").Name} {categoryService.GetByName("Alisher").CreatedAt} \n");


foreach (var item in categoryService.GetByDate(new DateTime(2024, 4, 4)))
{
    System.Console.WriteLine($"{item.Id}, {item.Name} {item.CreatedAt}");

}

categoryService.Delete(3);