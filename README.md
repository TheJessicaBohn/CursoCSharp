# CursoCSharp

## O que é o C#:
-

## Algumas caracteristicas da linguagem:
- Linguagem case-sensitive;
- Terminador de comandos: ";";
- Nomes de arquivos não tem relação obrigatória com o nome das classes

## Declaração e atribuíção:

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
- Type Casting é a atribuíção de um valor ou dado para outro tipo do mesmo;
- Existem dois tipos de atribuíção:
	- Implicit Casting: Transformação de um menor para um maior:
		- char < int < long < float < double
	- Explicit Casting: Transformação de um maior para um menor:		
		- double > float > long > int > char

## Operadores:
- Aritméticos:
	- `+` soma;
	- `-` subtração;
	- `*` multiplicação 
	- `/` divisão;
	- `%` resto da divisão;
	- `++` incremento de um; 
	- `--` decremento de um;
- Atribuíção:
	- `=` atribuíção simples;
	- `+=` atribuíção com soma;	
	- `-=` atribuíção com subtração;
	- `*=` atribuíção com multiplicação;
	- `/=` atribuíção com divisão;
	- `%=` atribuíção com resto da divisão;
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
