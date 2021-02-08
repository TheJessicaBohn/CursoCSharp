## .NET

- O **.NET** veio com o ideal de resolver a questão da questão de reescrita e adaptações de uma linguagem para outra através de um arcabouço como base, que possui uma psudoliguagem e uma maquina virtual. 
- Arquitetura:
	- MSIL (Microsoft Intermediate Language): é um conjunto de instruções que são independentes de plataforma e são geradas pelo compilador específico da linguagem a partir do código-fonte. O mesmo independente de plataforma e, consequentemente, pode ser executado em qualquer um dos ambientes suportados pela Common Language Infrastructure, como o tempo de execução do Windows .NET .
Ele é convertido em um código de máquina específico do ambiente de computador particular pelo compilador JIT . Isso é feito antes que o MSIL possa ser executado. Além disso, o MSIL é convertido em código de máquina com base nos requisitos, ou seja, o compilador JIT compila o MSIL conforme necessário, em vez de todo ele.
	- CLR (Common Language Runtime): É o ambiente de execução das aplicações .NET. O CLR cuidará do gerenciamento de memória de uma forma que torna o programa menos propício a erros. 
	- CTS (Common Type System): É a definição de tipos de dados onde tudo é um objeto e deriva da classe System.Object, que é o núcleo do sistema de tipos.E por isso o .NET é organizado de duas formas:
		-  Tipos Valor: variáveis deste tipo são alocadas na pilha e têm como classe base System.ValueType, que por sua vez deriva da System.Object.
		-  Tipos Referência: variáveis deste tipo são alocadas na memória heap e têm a classe System.Object como classe base.
	- CLS (Common Language Specification - Especificação comum de dados): Define um conjunto de regras que as linguagens que implementam a .NET devem seguir para que a CLR possa gerar a IL. No momento da compilação é gerado um código único intermediário (IL) e todas essas linguagens suportadas pela .NET seguem as regras da CLS, para que depois de gerado a IL, ela seja interpretada corretamente pela CLR.
	- BCL (Base Classe Library - Biblioteca de Classe Base): Na biblioteca de classe base você encontra sistema de janelas, biblioteca de entrada/saída de dados, sockets, gerenciamento de memória, etc. Esta biblioteca é organizada em uma estrutura conhecida como namespace, ou seja, imagine que você precise atribuir um nome ao seu componente para que o mesmo possa ser referenciado a partir de outro programa.





















## Fontes:
- https://www.geeksforgeeks.org/cil-or-msil-microsoft-intermediate-language-or-common-intermediate-language/
- http://www.linhadecodigo.com.br/artigo/120/arquitetura-net-msil-clr-cts-cls-blc-jit.aspx