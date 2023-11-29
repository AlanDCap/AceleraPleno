Claro, aqui estão alguns exemplos de funções para tratar dados em queries de MySQL:

* **Funções matemáticas:** essas funções são usadas para realizar operações matemáticas, como adição, subtração, multiplicação, divisão e cálculo de raízes quadradas.

Por exemplo, a seguinte consulta usa a função `SUM()` para retornar o valor total de compras de todos os clientes:

```sql
SELECT SUM(valor) AS valor_total
FROM compras;
```

* **Funções lógicas:** essas funções são usadas para realizar operações lógicas, como comparação, igualdade, desigualdade, AND, OR e NOT.

Por exemplo, a seguinte consulta usa a função `LIKE()` para retornar os nomes dos clientes que começam com a letra "A":

```sql
SELECT nome
FROM clientes
WHERE nome LIKE 'A%';
```

* **Funções de string:** essas funções são usadas para manipular strings, como concatenação, substituição, remoção de caracteres e conversão de formatos.

Por exemplo, a seguinte consulta usa a função `CONCAT()` para retornar o nome completo de um cliente:

```sql
SELECT CONCAT(nome, ' ', sobrenome) AS nome_completo
FROM clientes;
```

* **Funções de data e hora:** essas funções são usadas para manipular datas e horas, como conversão de formatos, cálculo de diferença entre datas e horas e retorno de informações sobre uma data ou hora.

Por exemplo, a seguinte consulta usa a função `DATE()` para retornar a data atual:

```sql
SELECT DATE();
```

Aqui estão alguns exemplos mais específicos de como essas funções podem ser usadas:

* **Para filtrar dados com base em um determinado valor:**

```sql
SELECT *
FROM clientes
WHERE nome = 'João da Silva';
```

* **Para calcular estatísticas sobre um conjunto de dados:**

```sql
SELECT COUNT(*) AS total_clientes,
       SUM(valor) AS valor_total,
        AVG(valor) AS media_valor
FROM compras;
```

* **Para formatar dados de uma maneira específica:**

```sql
SELECT CONCAT(nome, ' ', sobrenome) AS nome_completo,
       DATE_FORMAT(data_nascimento, '%d/%m/%Y') AS data_nascimento_formatada
FROM clientes;
```

* **Para realizar operações lógicas complexas:**

```sql
SELECT nome
FROM clientes
WHERE (idade > 18 AND idade < 65) OR cidade = 'São Paulo';
```

Essas são apenas algumas possibilidades, existem muitas outras funções disponíveis para tratar dados em queries de MySQL.