# CursoCSharp

## O que é o C#:
- É uma linguagem orientada a objetos

## O que é POO
- Programação orientada a objetos: 
 - Criada por Alan Kay, em 1970, que juntou a biologia e a matemática para criá-la;
- O que é um objeto:
	- É algo material ou abstrato que pode ser percebido  pelos sentidos  e descrita  por meio das suas caracteristicas, comportamentos e estado atual;
	- Classe (Define os atributos e métodos comuns que serão compartilhados  por um objeto) Caneta:
		- Atributo (Coisas que eu tenho): modelo, cor, ponta, carga, tampada;  
		- Método (Coisas que eu faço): escrever, rabiscar, pintar, tampar, destampar;
		- Estado (Como estou agora): nesse momento está com metade da carga, ponta está fina, azul, destampada, e escrevendo;
		- **Exemplo:**
		```
		Classe Caneta
			modelo: string;
			cor: string;
			ponta: float;
			carga: int;
			tampada: bool;
			
			Método rabiscar()
				if(tampada){
				escreva("ERRO")
				}else{
				escreva("RABISCO)}
			FimMétodo
			
			Método tampar()
				tampada = verdadeiro
			FimMétodo
		FimClasse	
		```
	- Quanto temos uma classe e queremos transforma-la em um objeto(instancia de uma classe), eu chamo de **instanciar**, ou seja, gero um objeto a partir de uma classe;
		-**Exemplo: de instancia**
		```
		c1 = new Caneta;
		c1.cor = "Azul";
		c1.ponta = 0.5;
		c1.tampada = falso;
		c1.rabiscar();
		
		c2 = new Caneta;
		c2.cor = "Vermelho";
		c1.ponta = 1.0;
		c1.tampada = falso;
		c1.tampar();
		```
	- Abstração:
		- Uma classe do tipo pessoa, possui os mesmos atributos, porém com estados diferentes, então a ideia é definir quais os atributos relevantes para o meu tipo de projeto
- Vantagens:
	- Confiabiliadade: pois isola as partes gerando assim um software seguro, porque ao alterar uma parte nenhuma outra será alterada;
	- Oportuno: como é dividida em partes várias delas podem ser desenvolvidas em paralelo;
	- Manutenabilidade: maior facilidade de atualização do software, e uma pequena modificação vai beneficiar todas as partes que utilizarem o objeto;
	- Extensibilidade: se o software não cresce, ele vira legado e deixa de ser utíl;	
	- Reutizabilidade: pode-se utilizar um objeto de um sistema que criamos em um outro sistema parecido futuramente
	- Natural: maior compreenção do código, podendo manter o foco  mais na funcionalidade do que nos detalhes da implementação

## Algumas caracteristicas da linguagem:
- Linguagem case-sensitive;
- Terminador de comandos: ";";
- Nomes de arquivos não tem relação obrigatória com o nome das classes

## Declaração e atribuição:

- **Formas Básicas:**
	- Tipo nome;
	- Tipo nome = valor;

- **Exemplos:**
	- Int codigo;
	- String nome = "Jéssica Bohn";
		
## Tipos:

- **Simples**
	- **Numericos:**
		- **Integer Types**
		- Inteiro com sinal: sbyte, short, int, long;
		- Inteiro sem sinal: byte, ushort, uint, ulong;
		- **Floating Point Types**
		- Ponto flutuante binário de IEEE: float, double;
		- Ponto flutuante decimal de alta precisão: decimal;
		
	- Caracteres Unicode: char;
	- Booleano: bool;

- **Por referência**
	- Classe base definitiva de todos os outros tipos: object;
	- Cadeia de caracteres Unicode: string;
	- Tipos definidos pelo usuário. Ex: class C{...};
	- Tipos definidos pelo usuário. Ex: interface I{...};
	- Tipos de matriz unidimencional e multidimencional. Ex: int[] e int[,];
	- Delegates. Ex: delegate int D(...);
	
- **Tipos mais comuns**
	- int -> 4 bytes;
	- long -> 8 bytes;
	- float -> 4 bytes;
	- double -> 8 bytes;
	- bool -> 1 bytes;
	- char -> 2 bytes;
	- string -> 2 bytes por caractere;
	
## Regras de nome de variavel:
- Pode conter letras, digítos  e o "_";
- Deve sempre começar com uma letra;
- Não pode conter espaço em branco;
- São diferenciadas por maiúscuas e minúsculas;
- Não se pode utilizar as palavras reservadas da linguagem( ver em https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/);

## Constantes:
- São como as variáveis, porém não alteram seu conteúdo;
- Mesmas regras de nome que as variáveis;
- Valor atribuído na declaração;
- Exemplo: const euler = 2,718281; 

## Concatenação:
- Junção de strings por literais e ou variáveis
	- Operadores:
		- **+**;
		- $ (>= C# 6.0).
	- Métodos:
		- Concat (utilizado: -1000 strings);
		- Format;
		- Join(um pouco mais lento que o concat).
	- Classe:
		- Stringbuilder (utilizado: +1000 strings).

## Comentários:
- são trechos do código que o compilador ignora
	- Geram documentação;
	- Sumarios/ explicação;
	- ToDos, list;
- // linha //;
- /* bloco */;
- /// documentação ;
- Documentação: **TODO, HACK, UNDONE**;

## Conversão de tipos:
- Type Casting é a atribuição de um valor ou dado para outro tipo do mesmo;
- Existem dois tipos de atribuição:
	- Implicit Casting: Transformação de um menor para um maior:
		- char < int < long < float < double
	- Explicit Casting: Transformação de um maior para um menor:		
		- double > float > long > int > char
## Classe Convert:
- Converte um tipo de dados para outro, e pode ser acessada diretamente, podendo conter 5 possíveis resultados:
	- **Não conversão:** Quando há tentativa de conversão frustrada;
	- ** InvalidCastException:** 
	- 
- ToInt16;
- ToInt32;
- ToInt64;
- ToSingle;
- ToBoolean;
- ToByte;
- ToChar;
- ToString;
- ToDateTime;
- ToDecimal;
- ToDouble.
- ToDouble.

## Operadores:
- Aritméticos:
	- `+` soma;
	- `-` subtração;
	- `*` multiplicação 
	- `/` divisão;
	- `%` resto da divisão;
	- `++` incremento de um; 
	- `--` decremento de um;
- Atribuição:
	- `=` atribuição simples;
	- `+=` atribuição com soma;	
	- `-=` atribuição com subtração;
	- `*=` atribuição com multiplicação;
	- `/=` atribuição com divisão;
	- `%=` atribuição com resto da divisão;
- Comparação:
	- `==` igualdade;
	- `!=` diferença;	
	- `>` maior;
	- `<` menor;
	- `>=` maior ou igual;
	- `<=` menor ou igual;	
- Comparação:
	- `&&` AND (E);
	- `||` OR(OU);	
	- `!` NOT(NEGAÇÂO);	
	
	
## Como seguir:
- **Framework**
- **Primeiro Projeto**
- **[Exercicios](https://github.com/TheJessicaBohn/CursoCSharp/tree/main/exercicios)**

# Fontes:
- http://www.elfutec.com
- https://www.youtube.com/watch?v=KlIL63MeyMY&list=PLHz_AreHm4dkqe2aR0tQK74m8SFe-aGsY&ab_channel=CursoemV%C3%ADdeo
