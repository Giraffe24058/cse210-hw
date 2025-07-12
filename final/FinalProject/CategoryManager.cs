public class CategoryManager
{
    private Dictionary<string, List<Receipt>> _categories = new Dictionary<string, List<Receipt>>();

    public void AssignCategory(string category, Receipt receipt)
    {
        if (!_categories.ContainsKey(category))
        {
            _categories[category] = new List<Receipt>();
        }
        _categories[category].Add(receipt);
    }

    public void ListCategories()
    {
        foreach (var category in _categories)
        {
            Console.WriteLine($"Category: {category.Key}");
            foreach (var receipt in category.Value)
            {
                Console.WriteLine($"  - {receipt.Title}");
            }
        }
    }
}
