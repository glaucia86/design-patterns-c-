# Abstract Factory #

### Intenção: ###

Fornecer uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

### Descrição: ###

Nesse padrão, a fábrica (conhecida como Factory) recebe solicitações por objetos concretos a partir de um cliente. Este padrão pode ser utilizado quando um sistema de software precisa ser independente de como classes concretas (produtos) são criadas, compostas ou representadas. No padrão, uma fábrica fica responsável por encapsular a criação de uma família de produtos. Nesse caso, um cliente precisa conhecer somente as interfaces desses produtos, não a sua implementação, aumentando o encapsulamento e abstração.

### Benefícios: ###

A aplicação deste padrão traz como benefício principal o isolamento de classes concretas. Se for necessário trocar uma família inteira de produtos, esse processo se torna menos impactante nas demais partes do sistema, pois as classes-produto ficam isoladas e não expõem sua implementação a classes clientes, diminuindo o acoplamento.

### Participantes: ###

- **Abstract Factory:** declara uma interface para operações que criam objetos-produtos abstratos.
- **Concrete Factory:** implementa as operações que criam objetos-produtos concretos.
- **Abstract Product:** declara uma interface para um tipo de objeto-produto.
- **Concrete Product:** define um objeto-produto a ser criado pela correspondente fábrica concreta. Implementa a interface de Abstract Product.
- **Cliente:** usa somente as interfaces declaradas pelas classes Abstract Factory e Abstract Product.

### Exemplo: ###

Acessar o link para verificar um código exemplo sobre o pattern em questão: Leia Mais - [Abstract Factory em C#] (http://www.dotnet-tricks.com/Tutorial/designpatterns/4EJN020613-Abstract-Factory-Design-Pattern---C)
