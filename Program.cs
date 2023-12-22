
class Program {
    public static void Main() {
        DataService ds = new DataService();
        List<Book> bookList = ds.getBooks();
        foreach (var book in bookList) {
            Console.WriteLine(book.Author);
        }
    }
}

