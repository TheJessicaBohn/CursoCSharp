# CursoCSharp

## O que é o C#:
-

## Algumas caracteristicas da linguagem:
- Linguagem case-sensitive;
- Terminador de comandos: ";";
- Nomes de arquivos não tem relação obrigatória com o nome das classes

## Declaração e atribuição:

- **Formas Básicas:**
	- Tipo nome;
	- Tipo nome = valor;

- ** Exemplos:**
	- Int codigo;
	- String nome = "Jéssica Bohn";
		
## Tipos:

- **Simples**
	-** Numericos:**
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
	
- ** Tipos mais comuns**
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
 	
	
	
## Como seguir:
- Framework
- Primeiro Projeto
- exercicios

# Fontes:
- http://www.elfutec.com
