# Manipulação de Valores em C# e Técnicas Especiais para DateTime

## Introdução

Este repositório contém códigos em C# que exemplificam técnicas de manipulação de valores, com atenção especial na classe DateTime. Além disso, são demonstrados conceitos de propriedades, métodos e construtores em C#, visando a construção de um modelo simples de Pessoa e Curso.

## Sobre a Classe Pessoa

A classe `Pessoa` representa um indivíduo e inclui propriedades como `Nome`, `Sobrenome` e `Idade`. Destacam-se algumas técnicas de manipulação de valores, como:

- **Propriedades Automáticas:** Uso de propriedades para encapsular o acesso aos membros privados, garantindo validações e manipulações específicas.

- **Validação de Entrada:** Utilização de exceções para validar entradas, por exemplo, garantindo que o campo `Nome` não seja vazio e que a `Idade` não seja um valor negativo.

- **Interpolação de Strings:** A classe faz uso extensivo de interpolação de strings para criar mensagens formatadas e legíveis.

- **Método de Apresentação:** O método `Apresentar()` exibe informações formatadas sobre a pessoa.

## Sobre a Classe Curso

A classe `Curso` gerencia informações sobre um curso, incluindo um nome e uma lista de alunos. Destacam-se algumas técnicas de manipulação de valores, como:

- **Uso de List:** A classe utiliza uma lista de objetos do tipo `Pessoa` para armazenar os alunos matriculados.

- **Métodos de Manipulação de Lista:** Métodos como `AdicionarAluno`, `RemoverAluno` e `ListarAlunos` demonstram operações comuns em listas.

## Manipulação de DateTime

No trecho adicional do código, é abordada a manipulação da classe `DateTime`. Destacam-se as seguintes técnicas:

- **TryParseExact:** Utilização do método `DateTime.TryParseExact` para converter uma string em um objeto `DateTime`, garantindo controle sobre o formato esperado.

- **Formatação de Data e Hora:** Exemplos de formatação de data e hora, mostrando diferentes formas de apresentar informações temporais.

- **Manipulação de Cultura:** Demonstração de como a cultura local pode influenciar a formatação de valores, com a possibilidade de especificar culturas específicas.

## Observações Importantes

- É recomendável explorar e adaptar o código de acordo com os requisitos específicos do seu projeto.
  
- Sempre considere boas práticas de programação, como encapsulamento, tratamento de exceções e legibilidade do código.

- Este código serve como um ponto de partida e pode ser expandido para atender a requisitos mais complexos.

Sinta-se à vontade para explorar, adaptar e contribuir para este repositório!
