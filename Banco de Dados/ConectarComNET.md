Para conectar ao MySQL utilizando .NET ou C#, você pode usar o pacote `MySqlConnector`. Este pacote fornece uma classe chamada `MySqlConnection` que pode ser usada para estabelecer uma conexão com o MySQL.

Para usar o pacote `MySqlConnector`, você primeiro precisa instalá-lo. Você pode fazer isso usando o gerenciador de pacotes do NuGet. Abra o Visual Studio e selecione **Tools** > **NuGet Package Manager** > **Package Manager Console**. Na janela do console de pacotes, digite o seguinte comando:

```
Install-Package MySqlConnector
```

Depois de instalar o pacote, você pode usar a classe `MySqlConnection` para estabelecer uma conexão com o MySQL. O código a seguir mostra como fazer isso:

```c#
using MySqlConnector;

class Program
{
    static void Main(string[] args)
    {
        // Credenciais de conexão
        string server = "localhost";
        int port = 3306;
        string database = "my_database";
        string username = "root";
        string password = "";

        // Estabelece uma conexão com o MySQL
        MySqlConnection connection = new MySqlConnection();
        connection.Server = server;
        connection.Port = port;
        connection.Database = database;
        connection.Username = username;
        connection.Password = password;

        try
        {
            // Abre a conexão
            connection.Open();

            // Imprime o nome do banco de dados
            Console.WriteLine(connection.Database);

            // Fecha a conexão
            connection.Close();
        }
        catch (Exception e)
        {
            // Trata o erro
            Console.WriteLine(e.Message);
        }
    }
}
```

Este código irá estabelecer uma conexão com o MySQL usando as seguintes credenciais:

* Servidor: localhost
* Porta: 3306
* Banco de dados: my_database
* Usuário: root
* Senha: ""

Depois de estabelecer a conexão, o código irá imprimir o nome do banco de dados.

Você também pode usar o pacote `MySqlConnector` para executar consultas no MySQL. O código a seguir mostra como fazer isso:

```c#
using MySqlConnector;

class Program
{
    static void Main(string[] args)
    {
        // Credenciais de conexão
        string server = "localhost";
        int port = 3306;
        string database = "my_database";
        string username = "root";
        string password = "";

        // Estabelece uma conexão com o MySQL
        MySqlConnection connection = new MySqlConnection();
        connection.Server = server;
        connection.Port = port;
        connection.Database = database;
        connection.Username = username;
        connection.Password = password;

        try
        {
            // Abre a conexão
            connection.Open();

            // Cria um comando
            MySqlCommand command = new MySqlCommand();

            // Define a consulta
            command.CommandText = "SELECT * FROM customers";

            // Executa a consulta
            MySqlDataReader reader = command.ExecuteReader();

            // Itera nos resultados
            while (reader.Read())
            {
                // Imprime os dados
                Console.WriteLine($"Id: {reader["id"]} Nome: {reader["nome"]}");
            }

            // Fecha a conexão
            connection.Close();
        }
        catch (Exception e)
        {
            // Trata o erro
            Console.WriteLine(e.Message);
        }
    }
}
```

Este código irá executar a seguinte consulta no MySQL:

```sql
SELECT * FROM customers
```

A consulta irá retornar todos os registros da tabela `customers`. O código irá imprimir os dados de cada registro.

Para obter mais informações sobre como usar o pacote `MySqlConnector`, consulte a documentação do pacote.