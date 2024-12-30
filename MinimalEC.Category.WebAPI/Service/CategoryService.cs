namespace MinimalEC.Category.WebAPI.Service
{
    public class CategoryService
    {
        private readonly List<Models.Category> _categories;

        public CategoryService()
        {
            _categories = new List<Models.Category>
            {
            new() {Id = 1, Name = "Smartphone"},
            new() {Id = 2, Name = "Laptop"},
            new() {Id = 3, Name = "Tablet"},
            new() { Id = 4, Name = "Smartwatch"},
            new() { Id = 5, Name = "Bluetooth Speaker"},
            };
        }

        public List<Models.Category> GetAllCategories()
        {
            return _categories;
        }

        public Models.Category? GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(p => p.Id == id);
        }
    }
}
