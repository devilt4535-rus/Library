using library;

Library lib = new Library();
Book book = new Book();
while (true)
{

    void Menu()
    {
        Console.WriteLine("1. Добавить книгу");
        Console.WriteLine("2. Удалить книгу");
        Console.WriteLine("3. Посмотреть информацию о книгах в библиотеке");
        Console.WriteLine("4. Получить информацию");
        string menu = Console.ReadLine();
        int menu1 = int.Parse(menu);

        if (menu1 == 1)
        {
            Create();
        }

        if (menu1 == 2)
        {
            lib.DeleteBook(book);
        }

        if (menu1 == 3)
        {
            lib.ListOfBooks();
        }

        if (menu1 == 4)
        {

        }
    }
    void Create()
    {
        Console.WriteLine("Введите автора");
        string author = Console.ReadLine();

        Console.WriteLine("Введите колчество страниц");
        string page = Console.ReadLine();
        int page1 = int.Parse(page);

        Console.WriteLine("Введите название книги");
        string bookName = Console.ReadLine();

        Console.WriteLine("Введите год выпуска книги");
        string date = Console.ReadLine();
        int date1 = int.Parse(date);

        Book book = new Book(author, page1, bookName, date1);
        book.GetInfo();

        lib.AddBook(book);
    }
    Menu();
}
