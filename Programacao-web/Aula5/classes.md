Para declarar uma classe em JavaScript, você deve usar a palavra-chave `class` seguida pelo nome da classe. Por exemplo:

```javascript
class Retangulo {
}
```

Esta declaração cria uma classe chamada `Retangulo`. A classe não tem nenhum atributo ou método, então ela é basicamente um objeto vazio.

Para adicionar atributos a uma classe, você pode usar a palavra-chave `constructor`. O construtor é um método especial que é executado quando uma nova instância da classe é criada. O construtor pode ser usado para inicializar os atributos da instância. Por exemplo:

```javascript
class Retangulo {
  constructor(largura, altura) {
    this.largura = largura;
    this.altura = altura;
  }
}
```

Esta declaração cria uma classe `Retangulo` com dois atributos: `largura` e `altura`. O construtor da classe inicializa os atributos `largura` e `altura` com os valores passados como parâmetros.

Para adicionar métodos a uma classe, você pode usar a palavra-chave `function`. Os métodos são funções que são associadas a uma classe. Por exemplo:

```javascript
class Retangulo {
  constructor(largura, altura) {
    this.largura = largura;
    this.altura = altura;
  }

  area() {
    return this.largura * this.altura;
  }
}
```

Esta declaração cria uma classe `Retangulo` com um método chamado `area()`. O método `area()` calcula a área do retângulo.

Aqui está um exemplo completo de como declarar uma classe em JavaScript:

```javascript
class Retangulo {
  constructor(largura, altura) {
    this.largura = largura;
    this.altura = altura;
  }

  area() {
    return this.largura * this.altura;
  }
}

const retangulo = new Retangulo(10, 20);

console.log(retangulo.area()); // 200
```

Este código cria uma instância da classe `Retangulo` com largura 10 e altura 20. Em seguida, o código imprime a área do retângulo, que é 200.

**Herança**

As classes em JavaScript também permitem a herança. A herança permite que você crie uma nova classe que herda os atributos e métodos de outra classe. Para herdar de outra classe, você usa a palavra-chave `extends`. Por exemplo:

```javascript
class Quadrado extends Retangulo {
}
```

Esta declaração cria uma classe `Quadrado` que herda de `Retangulo`. A classe `Quadrado` tem todos os atributos e métodos da classe `Retangulo`.

**Expressões de classe**

As classes em JavaScript também podem ser declaradas usando expressões de classe. As expressões de classe são uma forma concisa de declarar classes. Por exemplo:

```javascript
const Retangulo = class {
  constructor(largura, altura) {
    this.largura = largura;
    this.altura = altura;
  }

  area() {
    return this.largura * this.altura;
  }
};
```

Esta declaração é equivalente à declaração de classe anterior.