Para conectar ao MySQL usando JavaScript, você pode usar a biblioteca `mysql`. Esta biblioteca fornece uma API para estabelecer uma conexão com o MySQL e executar consultas SQL.

Para usar a biblioteca `mysql`, você primeiro precisa instalá-la. Você pode fazer isso usando o gerenciador de pacotes do npm. Abra o terminal e digite o seguinte comando:

```
npm install mysql
```

Depois de instalar a biblioteca, você pode usar a função `createConnection()` para estabelecer uma conexão com o MySQL. O código a seguir mostra como fazer isso:

```javascript
const mysql = require("mysql");

const connection = mysql.createConnection({
  host: "localhost",
  port: 3306,
  database: "my_database",
  user: "root",
  password: "",
});
```

Este código irá estabelecer uma conexão com o MySQL usando as seguintes credenciais:

* Servidor: localhost
* Porta: 3306
* Banco de dados: my_database
* Usuário: root
* Senha: ""

Depois de estabelecer a conexão, você pode usar a função `query()` para executar consultas SQL. O código a seguir mostra como fazer isso:

```javascript
const connection = mysql.createConnection({
  host: "localhost",
  port: 3306,
  database: "my_database",
  user: "root",
  password: "",
});

connection.connect((err) => {
  if (err) {
    console.log(err);
    return;
  }

  // Executa a consulta
  connection.query("SELECT * FROM customers", (err, results) => {
    if (err) {
      console.log(err);
      return;
    }

    // Itera nos resultados
    for (const row of results) {
      // Imprime os dados
      console.log(row.id, row.name);
    }
  });
});
```

Este código irá executar a seguinte consulta no MySQL:

```sql
SELECT * FROM customers
```

A consulta irá retornar todos os registros da tabela `customers`. O código irá imprimir os dados de cada registro.

Para obter mais informações sobre como usar a biblioteca `mysql`, consulte a documentação da biblioteca.

Além da biblioteca `mysql`, existem outras bibliotecas que podem ser usadas para conectar ao MySQL usando JavaScript. Algumas dessas bibliotecas incluem:

* `mysql2`
* `node-mysql`
* `knex`

A escolha da biblioteca mais adequada depende das suas necessidades específicas.