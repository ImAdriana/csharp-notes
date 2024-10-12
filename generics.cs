var numbers = new MyList<int>(5);
var names = new MyList<string>(5);
var books = new MyList<Book>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);


names.Add("Veronica");
names.Add("Michael");
names.Add("Sara");
names.Add("Burrows");
names.Add("Francisco");
names.Add("Milka");

books.Add(new Book()
{
    Name = "El banquete",
    Price = 5
});
books.Add(new Book()
{
    Name = "Crimen y castigo",
    Price = 8
});
books.Add(new Book()
{
    Name = "1984",
    Price = 5
});
books.Add(new Book()
{
    Name = "El Conde de Montecristo",
    Price = 3
});

Console.WriteLine(books.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>(); // Aqui se crea el objeto
    }

    public void Add(T item)
    {
        if (_list.Count < _limit)
        {
            _list.Add(item);
        }
    }

    public string GetContent()
    {
        string content = "";
        foreach (var item in _list)
        {
            content += item + ", ";
        }

        return content;
    }
}

public class Book
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return @"Name: " + Name + " Price: " + Price + ", ";
    }
}
