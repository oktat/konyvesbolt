
using MySqlConnector;

class Mariadb {
    readonly string host = "localhost";
    readonly string name = "konyvesbolt";
    readonly string user = "konyvesbolt";
    readonly string pass = "titok";

    public MySqlConnection? ConnectDb() {        
        MySqlConnection? conn = null;
        try {
            conn = TryConnectDb();    
        } catch (MySqlConnector.MySqlException) {            
            Console.WriteLine("Hiba! A kapcsolódás sikertelen!");
        }
        return conn;
    }
    public MySqlConnection TryConnectDb(){
        string str = $"Server={host};Database={name};" + 
        $"User ID={user};Password={pass};";
        MySqlConnection conn = new MySqlConnection(str);
        conn.Open();
        return conn;
    }
}
