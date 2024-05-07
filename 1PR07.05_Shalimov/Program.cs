
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
{
new Product { Id = 1, Name = "Ноутбук", Category = "Електроніка", Price = 1200 },
new Product { Id = 2, Name = "Футболка", Category = "Одяг", Price = 20 },
new Product { Id = 3, Name = "Шоколадка", Category = "Їжа", Price = 2.5 },
new Product { Id = 4, Name = "Смартфон", Category = "Електроніка", Price = 800 },
new Product { Id = 5, Name = "Джинси", Category = "Одяг", Price = 50 },
new Product { Id = 6, Name = "Морозиво", Category = "Їжа", Price = 3 },
new Product { Id = 7, Name = "Телевізор", Category = "Електроніка", Price = 1500 },
new Product { Id = 8, Name = "Кросівки", Category = "Взуття", Price = 80 },
new Product { Id = 9, Name = "Піча", Category = "Їжа", Price = 10 },
new Product { Id = 10, Name = "Монітор", Category = "Електроніка", Price = 300 },
new Product { Id = 11, Name = "Світшот", Category = "Одяг", Price = 35 },
new Product { Id = 12, Name = "Книга", Category = "Книги", Price = 15 },
new Product { Id = 13, Name = "Браслет", Category = "Прикраси", Price = 25 },
new Product { Id = 14, Name = "Чайник", Category = "Побутова техніка", Price = 40 },
new Product { Id = 15, Name = "Батонцик", Category = "Їжа", Price = 1.5 },
new Product { Id = 16, Name = "Мишка", Category = "Електроніка", Price = 10 },
new Product { Id = 17, Name = "Портфель", Category = "Аксесуари", Price = 70 },
new Product { Id = 18, Name = "Спортивний костюм", Category = "Спорт", Price = 100 },
new Product { Id = 19, Name = "Кавоварка", Category = "Побутова техніка", Price = 60 },
new Product { Id = 20, Name = "Годинник", Category = "Прикраси", Price = 120 }
};


        //1.Вибрати всі товари з категорії "Електроніка".
        var productsElectronic = products.Where(x => x.Category == "Електроніка").ToList();

        //2.Знайти найдорожчий товар.
        var maxPrice = products.Max(x => x.Price);

        //3.Підрахувати загальну вартість всіх товарів.
        var sumPrice = products.Sum(x => x.Price);

        //4.Відсортувати товари за ціною у зростаючому порядку.
        var upPrice = products.OrderBy(x => x.Price);

        // 5. Вибрати унікальні категорії товарів.
        var uniqueCategory = products.Select(x => x.Category).Distinct();

        //6.Знайти кількість товарів у кожній категорії.

        var countElectronic = products.Count(x => x.Category == "Електроніка");
        var countCloth = products.Count(x => x.Category == "Одяг");
        var countFood = products.Count(x => x.Category == "Їжа");
        var countShoe = products.Count(x => x.Category == "Взуття");
        var countJewelry = products.Count(x => x.Category == "Прикраси");
        var countAccessories = products.Count(x => x.Category == "Аксесуари");
        var countSports = products.Count(x => x.Category == "Спорт");
        var countConsumerElectronics = products.Count(x => x.Category == "Побутова техніка");

        //7.Вибрати товари з назвами, які починаються на букву "С".
        var namedC = products.Where(x => x.Name[0] == 'C').ToList();

        //8.Знайти середню ціну товарів.
        var averagePrice = products.Average(x => x.Price);

        //9.Вибрати товари, ціна яких менше 50.
        var priceLess50 = products.Where(x => x.Price < 50).ToList();

        //10.Підрахувати кількість товарів з ціною більше 100.
        var sumProductsMore100 = products.Count(x => x.Price > 100);

        // 11.Вибрати перші 5 товарів.
        var Fist5Prod = products.Take(5);

        //12.Повернути останній товар.
        var lastProduct = products.Last();

        //13.Вибрати товари з категорії "Їжа" та відсортувати їх за зростанням ціни.
        var countFoodSort = products.Where(x => x.Category == "Їжа")
                                    .OrderBy(x => x.Price).ToList();
        // 14.Повернути імена товарів в верхньому регістрі.
        var upperCaseProducts = products.Select(x => x.Name.ToUpper()).ToList();

        //15.Вибрати товари, ціна яких лежить у діапазоні від 10 до 100
        var Prico10to100 = products.Where(x => x.Price > 10 && x.Price < 100).ToList();

        //16.Знайти найменшу ціну серед товарів.
        var lessPrice = products.Min(x => x.Price);

        //17.Вибрати товари, що містять слово "Кава" в назві.
        var nameCoffee = products.Where(x => x.Name == "Кава").ToList();

        //18.Підрахувати загальну кількість товарів.
        var countProduct = products.Count();

        //19.Знайти товар з найменшим ідентифікатором.
        var minID = products.Min(x => x.Id);

        // 20. Вибрати товари, назви яких містять лише одне слово.
        var prodWithOneWord = products.Where(x => x.Name.Contains(" ")).ToList();

    }
}