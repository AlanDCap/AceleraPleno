
Aqui está uma query para adicionar a tabela `alunos` uma coluna para armazenar senhas, de modo que a senha fique criptografada na base:

```sql
ALTER TABLE alunos
ADD COLUMN senha VARCHAR(255) NOT NULL;
```

Essa query adiciona uma coluna chamada `senha` à tabela `alunos`. A coluna `senha` é do tipo `VARCHAR` com tamanho máximo de 255 caracteres. O valor da coluna `senha` deve ser preenchido obrigatoriamente.

Para criptografar a senha antes de armazená-la na base, você pode usar uma função de criptografia, como a função `MD5()` ou a função `SHA256()`. Por exemplo, a seguinte query criptografa a senha usando a função `MD5()`:

```sql
UPDATE alunos
SET senha = MD5(senha);
```

Essa query atualiza todos os registros da tabela `alunos` para criptografar a coluna `senha`.

Se você quiser criptografar a senha apenas nos novos registros, você pode usar a seguinte query:

```sql
ALTER TABLE alunos
ADD COLUMN senha VARCHAR(255) NOT NULL AFTER matricula;
```

Essa query adiciona a coluna `senha` após a coluna `matricula`. A coluna `senha` é do tipo `VARCHAR` com tamanho máximo de 255 caracteres. O valor da coluna `senha` deve ser preenchido obrigatoriamente.

A seguir, você pode usar a função `MD5()` ou a função `SHA256()` para criptografar a senha antes de inserir um novo registro na tabela:

```sql
INSERT INTO alunos (disciplina, matricula, nome, data_nascimento, sexo, email, telefone, endereco, cidade, estado, senha)
VALUES ('Matemática', 123456, 'Fulano de Tal', '1990-01-01', 'M', 'fulano@tal.com', '(11) 1234-5678', 'Rua da Paz, 123, São Paulo, SP', 'São Paulo', 'SP', MD5('senha123'));
```

Essa query insere um novo registro na tabela `alunos` com a senha criptografada usando a função `MD5()`.