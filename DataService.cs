using MySqlConnector;

class DataService {
    public List<Book> getBooks() {
        List<Book> bookList = new List<Book>();
        Mariadb mariadb = new Mariadb();
        MySqlConnection? conn = mariadb.ConnectDb();
        string sql = "select * from konyvek";
        using MySqlCommand cmd = new MySqlCommand(sql, conn);
        using MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read()) {
            Book book = new Book();
            if(!reader.IsDBNull(reader.GetOrdinal("cim"))) {
                string cim = reader.GetString("cim");
                string szerzo = reader.GetString("szerzo");
                book.Title = cim;
                book.Author = szerzo;
                bookList.Add(book);
            }else {
                Console.WriteLine("Az érték NULL");
            }
        }
        return bookList;
    }
}