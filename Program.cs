﻿using propriedades_metodos.Models;
using System.Globalization;

using Newtonsoft.Json;


/*POO abstração

Nada mais é do que abstrair um objeto do mundo real para um contexto especifico
considerando apenas os atributos importantes, ou
abstrair um objeto do mundo real e transformar em uma representação (classe) para um 
contexto especifico. obter algo  do mundo real e abstrair no seu sistema.



















/* POO

É uma representação de algo do mundo real onde eu coloco as suas características e
um objeto nada mais é do que uma implementação dessa classe.

Paradigmas 

Um modelo de técnicas 
conjunto de regras 
Uma linguagem de programação implementa um ou mais paradigmas.

Programação Orientada a objetos 
''Estruturada
''Imperativa 
''procedural 
''orientada a eventos
''lógica






/*
Ao declarar um tipo de dado, o seu tipo não pode mais pode ser alterado, contudo, há uma exceção para isso. E
ssa exceção é conhecida como:
r: tipo dynamic

Para criarmos uma classe genérica, precisamos passar um tipo entre dois símbolos. 
A correta criação de uma classe genérica é:
r: class NomeDaCLasse<T>

Ao desserializar uma informação, nem sempre temos a certeza que virá um determinado valor, 
ou seja, ele pode vir nulo e retornar uma exceção caso seu programa não esteja esperando. Para 
evitar isso, podemos usar:
r: Tipo de referência nulo

Por muitas vezes queremos que nosso código seja flexível e reaproveitável para vários tipos de dados, 
não dependendo de um tipo específico na sua construção. Esse conceito é conhecido como:
r: Genérico

Para representarmos um tipo de dado que pode ser nulo, ou seja, pode 
epresentar o seu próprio tipo e o valor nulo, usamos o símbolo:
r: ?

Existe um tipo de dado que pode agrupar outros tipos de dados, sendo apenas leitura, não 
sendo possível alterar seus dados após a sua declaração. Esse tipo é conhecido como:
r: Tipos anônimos



links Lucas

extension-methods
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/extension-methods

nullable-value-types
https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/nullable-value-types

dynamic-type
https://www.tutorialsteacher.com/csharp/csharp-dynamic-type

anonymous-type
https://www.tutorialsteacher.com/csharp/csharp-anonymous-type

generic1.htm
https://www.macoratti.net/16/10/c_generic1.htm

using-generics-with-C-Sharp/
https://www.c-sharpcorner.com/UploadFile/84c85b/using-generics-with-C-Sharp/

Métodos de extensão 
https://www.tutorialsteacher.com/csharp/csharp-extension-method













int numero = 15;
bool par = false;

par = numero.EhPar();
string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "impar");


Console.WriteLine(mensagem);


















//classe generica
/*
NewArray<int> arrayInteiro = new NewArray<int>();
arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);


NewArray<string> arrayString = new NewArray<string>();
arrayString.AdicionarElementoArray("jucc");

Console.WriteLine(arrayString[0]);


*/

/*

dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");


variavelDinamica = "Texto";

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");







*/












/*o ?: Significa que além de receber os valores que ele já aceita normalmente 'verdadeiro ou falso' 
ele vai aceitar um outro tipo de valor adicional que é o nulo */

bool? desejaReceberEmail = null; 
            //Hasvalue verificar se é != de nulo,. Value = tem valor
if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail.");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
}









/*



https://docs.microsoft.com/pt-br/cpp/mfc/memory-management

https://www.c-sharpcorner.com/article/stack-vs-heap-memory-c-sharp

https://dotnettutorials.net/lesson/stack-and-heap-dotnet

https://www.codeproject.com/Articles/76153/Six-Important-NET-Concepts-Stack-Heap-Value-Types

O tipo de referência armazena dados dinâmicos e complexos, e por esse motivo ele é armazenado em uma memória específica. 
Qual é essa memória?
r: Heap

A limpeza da memória Heap não é feita de maneira tradicional, sendo assim, ela 
depende de outro processo para realizar a sua limpeza. Qual é o nome do 
processo que realiza essa limpeza?
r: Garbage Collector

O .NET trabalha com dois tipos de memória, onde um armazena dados estáticos e o outro armazena dados dinâmicos. E
sses tipos de memória são conhecidos como:
r: Stack e Heap 








Repositório do módulo:
https://github.com/leonardo-buta/trilha-net-exemplo-explorando-a-linguagem
https://github.com/digitalinnovationone/trilha-net-exemplo-explorando-a-linguagem


Documentação oficial da Microsoft:
https://docs.microsoft.com/pt-br/dotnet/csharp











/*


Pessoa p1 = new Pessoa("Denis", "Hara");

Pessoa p2 = p1;
p2.Nome = "Jose"
dotnet run = 
= Jose
= Jose
armazenam na memória stack e na heap. conta como ref. e aponta para um objeto 
Porque valores de ref. mudam, já valores primitivos alteram

int a = 10;

int b = a;
b = 60; 

dotnet run =
a = 10
b = 60

tipos primitivos 













Garbage:

Terminou o método ele vai fazer a limpeza de memória, vai  finalizar de cima pra baixo LIFO, limpar a memória. na stack.
na Heap é diferente, quem vai limpar é o Garbage Collector GC ->
Vai limpar todos os dados da memória heap que estão sem referência 
para uma variável em uso.

Todo objeto da memória heap que nao tiver mais ref. nenhuma para a memória stack
vai entrar no GC





/*
Stack e Heap

Stack ultimo a entrar é o primeiro a sair LIFO.

void Metodo()
{                                                                                                 Tipos complexos ficam na memória heap
                                                                    p1(ref)       --------->         p1
int a = 5;     = tipos de valor                                                   b = 10                        (Objeto)
int b = 10;    = tipos de valor                                                  a = 5

Pessoa p1 = new Pessoa();= tipo de referência                                        Stack                          Heap
}                                                           Tipo simples somente na Stack/  Já Objetos, classes interfaces e outros tipos
                                                                                            complexos vão ser armazenados na Stack como
                                                                                            referência e o objeto de verdade vai ficar na heap





















/* Links Buta->

https://docs.microsoft.com/pt-br/nuget/what-is-nuget

https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/serialization

https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Objects/JSON

https://codebeautify.org/jsonviewer



Podemos atribuir metadados para as classes e propriedades, passando valores ou alterando seu comportamento. Isso é conhecido como:
r: Atributos

Podemos atribuir metadados para as classes e propriedades, passando valores ou alterando seu comportamento. Isso é conhecido como:
r: Serialização

Podemos compartilhar nosso código como uma solução ou melhoria em comum com outras pessoas, para 
que elas usem em seus projetos e se beneficie dessa solução, visando o reaproveitamento de código. 
Quando fazemos isso, estamos montando um(a):
r: Pacote ou biblioteca.

Para instalar um pacote, podemos fazer visualmente ou pela linha de comando no terminal. Pela linha de comando,
 para instalar um pacote pelo .NET CLI devemos executar o:
 r: dotnet add package nome_do_pacote




/*Lidar com atributos em json:

Na classe adicione:

Na parte de cima

Using Newtonsoft.json;

Exemplo nome: "Nome_Produto": "Material de escritório",
                [JsonProperty("Nome_Produto")]  adicionando metadata. uma instrução 
Resp:      transformado = public string Produto { get; set; }
                 errado = public string Nome_Produto { get; set; }





*/




/* Deserialização:
Começar mapeando o conteudo desse arquivo em uma classe.
DataVenda pertence ao formato ISO8601


string conteudoArquivo = File.ReadAllText("../Arquivos/vendas.json"); //Leitura do Arquivo e armazenado na variavel conteudoArquivo.

List<Venda2> listaVenda2 = JsonConvert.DeserializeObject<List<Venda2>>(conteudoArquivo);

foreach (Venda2 venda in listaVenda2)
{

    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" + 
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}










/*
//testar json file : https://codebeautify.org/jsonviewer

DateTime dataAtual = DateTime.Now;


List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 75.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v1);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
//Serializar mais de 1 componente. uma coleção 

Console.WriteLine(serializado);


File.WriteAllText("../Arquivos/vendas.json", serializado);







//string serializado = JsonConvert.SerializeObject(v1); 
// R = dotnet run
//{"Id":1,"Produto":"Material de escritório","Preco":25.00}

//Sempre ler a documentação para saber como funciona o pacote 
/*
//Adicionando na string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented); = 

dotnet run
{
  "Id": 1,
  "Produto": "Material de escritório",
  "Preco": 25.00
}










// dotnet add package Newtonsoft.Json < instala sempre a ultima versão






/* Serialização de dados:
Se quiser transmitir esses dados para outras aplicações, ou armazenar esse estado desse objeto tem que fazer esse
processo de serialização, que nada mais é do que vc transformar esse objeto em algo mais proximo do que
vc deseja armazenar como: OBJETO--->BYTES---->FILE/DATABASE/MEMORY

transformar objetos em um fluxo de bytes pra armazenar ou transmitir esse dado. é 
vc tirar algo do objeto da programação e representar ele de uma outra forma pra algum
outro destino que vc queira.

Json->

JavaScript Notation Object transmitir dados entre aplicações 

























/*
Links Leonardo

https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/value-tuples

https://www.macoratti.net/20/06/c_deconstr1.htm

https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/conditional-operator

https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/functional/deconstruct


*/

//if ternário:

// int numero = 15;
// bool ehPar = false;

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));







// int numero = 20;

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número é par");
// }
// else
// {
//     Console.WriteLine($"O número é impar");
// }













// Descontrutor: Uma ação inversa ao contrutor, separar de volta.

// Pessoa p1 = new Pessoa("Denis", "Hara");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

//nome e sobrenome em variáveis separadas do tipo string.






//Descarte _ : var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("../Arquivos/ArquivoLeitura.txt");

// LeituraArquivo arquivo = new LeituraArquivo();
// //var = acha sozinho a variável 
// var (sucesso, linhasArquivo, QuantidadeLinhas) = arquivo.LerArquivo("../Arquivos/ArquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("quantidade linhas do arquivo:" + QuantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//      Console.WriteLine(linha);
//     }
//     }
//     else
//     {
//     Console.WriteLine("não foi possivel ler o arquivo");
//     }







//tupla

/*
//recomendada:legibilidade e nomeação de dados.
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Denis", "Hara", 1.70M);

//ambas não tem como especificar variáveis.
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Denis", "Hara", 1.70M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Denis", "Hara", 1.70M);


Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");





*/



// -------------------------------------------------------------------------------------------------















/*

ex:

Para lançarmos uma exception e interromper o fluxo de nosso código, usamos uma palavra reservada, conhecida como:
R: Throw 

A chave deve ser única, caso contrario lançara uma exceção 

Para lermos todas as linhas de um arquivo e retornar uma coleção de strings, podemos usar a classe File, e o seu método:
R: File.ReadAllLines

Uma coleção do tipo fila (queue) implementa uma regra específica para inserção e remoção de elementos, na qual o primeiro a entrar também é o primeiro a sair. Essa ordem é conhecida como: 
r: FIFO first in firt out


STACK
LIFO
LAST IN FIRST OUT


Para prevermos uma exceção, usamos duas palavras reservadas, uma na qual define o escopo de execução, e a 
outra que trata a exceção retornada. Essas palavras são:

r:try/catch










links Lucas B.

https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/collections

https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.dictionary-2

https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/exceptions



//obter um valor que já existe:

/*


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "SÃO PAULO");
estados.Add("BA", "BAHIA");
estados.Add("MG", "MINAS GERAIS");

Console.WriteLine(estados["MG"]);

//R = dotnet run
MINAS GERAIS

*/




//verificar se uma chave já foi adicionada: Containskey()

/*
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "SÃO PAULO");
estados.Add("BA", "BAHIA");
estados.Add("MG", "MINAS GERAIS");




string chave = "BA";
{
    Console.WriteLine($"verificando o elemento: {chave}");
}

if (estados.ContainsKey(chave))

{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor inexistente. É seguro adicionar {chave}");
}


*/





//dictionary = ele serve para quando vc tem uma chave composta e que vc precisa que
// esses elementos sejam unicos e caso eles não sejam unicos ele adiciona uma exceção.-> não podem ser duplicados.

//  <tipo 1 chave, tipo 2 valor>

/*
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "SÃO PAULO");
estados.Add("BA", "BAHIA");
estados.Add("MG", "MINAS GERAIS");

foreach(var item in estados)
{
    Console.WriteLine($"chave: {item.Key}, Valor: {item.Value}");
}
//Valores podem ser alterados, chaves não.
//remover valores existentes:
Console.WriteLine("-----------");
estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"chave: {item.Key}, Valor: {item.Value}");
}

*/

/*
dotnet run
chave: SP, Valor: SAO PAULO
chave: BA, Valor: BAHIA
chave: MG, Valor: MINAS GERAIS
-----------
chave: SP, Valor: SAO PAULO
chave: MG, Valor: MINAS GERAIS


*/




// -------------------------------Pilhas stack-------------------------------

// stack obedece a ordem LIFO LAST IN FIRST OUT. Contrário de fila
/*

Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);
pilha.Push(5);
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);
foreach(int item in pilha)
{
    Console.WriteLine(item);
}

/*
dotnet run
Removendo o elemento do topo: 5
4
3
2
1
Removendo o elemento do topo: 4
20
3
2
1

*/


// Queue<int> fila = new Queue<int>();  

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

/* = dotnet run
2
3
4
5
*/


//remover elemento

// Console.WriteLine($"removendo o elemento: {fila.Dequeue()}");


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

/* = removendo o elemento: 2
3
4
5

*/

//OBS: Primiro que entrar sera o primeiro a sair e o ultimo que entrar sera adicionado ao final da fileira. FIFO FIRST IN FIRST OUT




















// ---------------------------try catch -----------------------------

/*
Usar exceções somente em casos que fogem do padrão
fogem de uma validação conveniente


try
{
    string[] linhas = File.ReadAllLines("../Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. "
    + ex.Message); //Obs: concatenação
}



catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}finally
{
    Console.WriteLine("Chegou aqui");
}


*/


// ---------------------------------------------------------------------------------------------------



/* links Lucas B.

https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/tokens/interpolated

https://docs.microsoft.com/pt-br/dotnet/standard/base-types/custom-numeric-format-strings

https://docs.microsoft.com/pt-br/dotnet/api/system.datetime

https://riptutorial.com/csharp/example/19285/datetime-tryparseexact-string--string--iformatprovider--datetimestyles--datetime-




Existe um outro meio de concatenar strings, em que usamos o sinal de "$". Essa concatenação é chamada de:
R-> interpolação juntar-> ("$ {data}");


concatenar strings = +  

Podemos alterar a localização (ou cultura) do programa para que seja trabalhado dados específicos de uma cultura (por exemplo, símbolo da moeda, casas decimais, etc). Para isso, usamos a classe:
R-> CultureInfo

Para formatar um valor decimal, ou seja, colocar o símbolo de moeda, é correto usarmos o caractere:
R-> :C


interface: using System.Globalization;




// DateTime tryparse -----------------------------------------

// maneira segura de conversão

// string dataString = "2022-13-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, out DateTime data);

                     


// if (sucesso) {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}"); = Conversão com sucesso! Data: 17/12/2022 18:00:00
// }
// else {
//     Console.WriteLine($"Error Data: {data}"); = Error Data: 01/01/0001 00:00:00
// }



// -------------------------------------DateTime



/*
//método para que mesmo se der erro ele funcione = 01/01/0001 00:00:00
string dataString = "2022-13-17 18:00";

DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime data);

                        Console.WriteLine(data);


*/



// DateTime data = DateTime.Parse("17/04/2022 18:00"); = 17/04/2022 18:00:00 conversão de numero para string


// Console.WriteLine(data);



// ----------------------------

// using System.Globalization;

// DateTime data = DateTime.Now;    


// Console.WriteLine(data.ToShortTimeString()); = 16:07

// Console.WriteLine(data.ToShortDateString()); = 03/01/2023

//MM:Mês  HH ->Hora. mm->Minuto. OBS: hh minúsculo formato de 12h. 
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); = 03/01/2023 16:00


























// ---------------------------------------------------------------------------
/*
//modificar cultura do sistema. \/
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 84.40M;
                                 //:C = Currence
// Console.WriteLine($"{valorMonetario:C}"); 

//abaixo usar outra cultura atropelando a cultura do sistema
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); 

//C-> CURRENCE/ 8-> CASAS DECIMAIS = 84,40000000
Console.WriteLine(valorMonetario.ToString("C8")); 

//Porcentagem \/ = 12,34%
double porcentagem = .1234;
Console.WriteLine(porcentagem.ToString("P"));


//resultado = 34-21-35
int numero = 341235;
Console.WriteLine(numero.ToString("##-##-##"));

*/




























/*
Pessoa p1 = new Pessoa(nome: "Denis", sobrenome: "Hara");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Massuda");


 cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
Curso
cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.ListarAlunos();
*/

/*
construtor: atribuir valores para um objeto
Get obtendo valor armazenado nessa propriedade como ex:{Idade}. Set = setando/ atribuindo valor ex. = 25.

Quando queremos proteger uma variável de modificações externas, isto é, 
impedir que ela seja alterada a não ser pela própria classe, usamos o modificador: private


 EX: Temos a possibilidade de implementar uma propriedade que apenas retorna um valor, não sendo possível atribuir ou modificar o valor retornado. 
Esse tipo de propriedade é conhecida como: Propriedade somente leitura, onde implementa apenas o GET.

EX2: Existem dois tipos de ações de propriedades: GET e SET. 
Eles podem manipular variáveis ou ser auto implementadas, e suas funções são: 
= GET: Obter o valor da propriedade; SET: Atribuir o valor da propriedade.
*/



//guia Lucas 
/*
propriedades:
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties

métodos:
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/methods

construtores:
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/constructors



construtores estaticos: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/static-constructors

*/
