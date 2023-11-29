Aqui estão alguns exemplos de consultas avançadas em MySQL:

* **Consultas com subqueries:** as subqueries são consultas SQL inseridas dentro de outras consultas. Elas podem ser usadas para executar operações complexas, como a combinação de dados de várias tabelas.

Por exemplo, a seguinte consulta usa uma subquery para retornar o nome do cliente com o maior valor de compra:

```sql
SELECT nome
FROM clientes
WHERE id = (
  SELECT id
  FROM compras
  ORDER BY valor DESC
  LIMIT 1
);
```

* **Consultas com JOINs:** os JOINs são usados para combinar dados de duas ou mais tabelas. Eles podem ser usados para criar consultas mais complexas, como a consulta de dados relacionados de diferentes fontes.

Por exemplo, a seguinte consulta usa um JOIN para retornar os nomes dos clientes e o nome dos produtos que eles compraram:

```sql
SELECT clientes.nome, produtos.nome
FROM clientes
INNER JOIN compras ON clientes.id = compras.id_cliente
INNER JOIN produtos ON compras.id_produto = produtos.id;
```
Referência visual para os joins https://joins.spathon.com/

* **Consultas com agregações:** as agregações são usadas para calcular valores de grupos de dados. Elas podem ser usadas para criar consultas mais informativas, como a consulta de estatísticas sobre um conjunto de dados.

Por exemplo, a seguinte consulta usa agregações para retornar o número de clientes, o valor total de compras e a média de valor de compra:

```sql
SELECT COUNT(*) AS total_clientes,
       SUM(valor) AS valor_total,
        AVG(valor) AS media_valor
FROM compras;
```

* **Consultas com funções:** as funções são usadas para realizar operações matemáticas, lógicas ou de string. Elas podem ser usadas para criar consultas mais flexíveis, como a consulta de dados com base em critérios personalizados.

Por exemplo, a seguinte consulta usa uma função para retornar os nomes dos clientes que vivem em São Paulo:

```sql
SELECT nome
FROM clientes
WHERE cidade = 'São Paulo';
```

Esses são apenas alguns exemplos de consultas avançadas em MySQL. Existem muitas outras possibilidades, dependendo das necessidades específicas do aplicativo.

Aqui estão algumas dicas para escrever consultas avançadas em MySQL:

* Use a documentação do MySQL para aprender sobre os recursos disponíveis.
* Teste suas consultas cuidadosamente para garantir que elas retornem os resultados esperados.
* Otimize suas consultas para melhorar o desempenho.

Com um pouco de prática, você será capaz de escrever consultas avançadas em MySQL que atenderão às suas necessidades.