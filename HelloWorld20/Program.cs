using System;
using System.Collections.Generic; // namespace para a Class 'List'.

namespace HelloWorld20
{
    class Program
    {
        //Listas: É uma estrutura de dados 
        // - Homogênea (dados do mesmo tipo)
        // - Ordenada (elementos acessados por meios de posições) // { 0, 1, 2, 3... }
        // - Inicia vazia, e seus elementos são alocados sob demanda 
        // - Cada elemento ocupa um 'nó' (ou nodo) da lista
        // - É uma Class chamada 'List' do namespace: System.Collections.Generic

        static void Main(string[] args)
        {
            // Vantagens: Tamanho variável e Facilidade para realizar inserções e deleções.
            // Desvantagens: Acessos sequencial aos elementos. (percorre nodo(nó) por nodo até chegar no elemento desejado, sendo mais lento, mas podendo ser adaptável).

            List<string> list = new List<string>(); // Criando a lista vazia já instanciando com o tipo 'string'.
            List<string> list2 = new List<string> { "Maria", "Alex", "João" }; // Criando a lista com valores já instanciando.

            list.Add("Maria"); // '.Add' Comando para adicionar valores ao final da lista instanciada.
            list.Add("Ailto");
            list.Add("Ana");
            list.Add("Joao");
            list.Add("Gabs");
            list.Add("Davi");
            list.Add("Pedrinho");

            list.Insert(2, "Bob"); // '.Insert' comando para inserir o valor na posição desejada da lista, nesse caso posição '2',

            Console.WriteLine("Lista: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------------------------\nTamanho da lista: ");
            Console.WriteLine("List count: " + list.Count); // '.Count' comando para mostrar o tamanho da lista.

            // Expressôes Lambda/predicado.
            // => - tal que
            // Expressão lambda: '(x => x[0] == 'A')', funciona como uma função simplificada que retorna verdadeiro ou falso dependendo dos parâmetros. // 'x' é declarado automaticamente como string.
            // Parâmetro: ('x' tal que x na posição [0] seja igual a 'A') sendo 'x[0]' o primeiro caractere do string.
            string s1 = list.Find(x => x[0] == 'A'); // '.Find' comando para encontrar o primeiro elemento pela lista que satisfaça o predicado (lambda).
            string s2 = list.FindLast(x => x[0] == 'A'); // '.Findlast' comando para encontrar a último elemento pela lista que satisfaça o predicado.
            Console.WriteLine("------------------------------------------------------\nBuscas da lista: ");

            Console.WriteLine("First 'A': " + s1);
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); // '.FindIndex' comando para encontrar a posição do primeiro elemento da lista que satisfaça o predicado.
            Console.WriteLine("First Position: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // '.FindLastIndex' comando para encontrar a posição do último elemento da lista que satisfaça o predicado.
            Console.WriteLine("Last Position: " + pos2);

            List<string> listResult = list.FindAll(x => x.Length == 5); // '.FindAll' comando para encontrar os elementos que satisfaça o predicado, nesse caso filtrar a lista criando uma nova com as condições da lambda.
            // Parâmetro: ('x' tal que o tamanho de 'x' seja igual a '5').
            Console.WriteLine("------------------------------------------------------\nNome com 5 caracteres: ");
            foreach (string obj in listResult)
            {
                Console.WriteLine(obj);
            }


            //---------------------- Deleções nas listas: -------------------------------

            list.Remove("Maria"); // '.Remove' comando para remover o elemento que satisfaça o parametro, nesse caso um 'string'.
            Console.WriteLine("------------------------------------------------------\nLista com um elemento removido: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'A'); // '.RemoveAll' comando para remover todos os elementos que satisfaçam o predicado.
            Console.WriteLine("------------------------------------------------------\nLista com os elementos que começam com a letra 'A' removidos: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(0); // '.RemoveAt' comando para remover o elemento na posição indicada no parâmetro.
            Console.WriteLine("------------------------------------------------------\nLista com o elemento '0' removido: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(1, 2); // '.RemoveRage' comando para remove a partir de uma posição junto à uma quantidade // Parâmetro: (A partir da posição '0', remover '2' elementos).
            Console.WriteLine("------------------------------------------------------\nLista sem '2' elementos a partir da posição '1': ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
