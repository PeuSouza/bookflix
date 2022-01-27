using System; 
 
namespace bookflix
{

class Program
   {
      static BooksRepositorio repositorio = new BooksRepositorio();
       static void Main(string[] args)
      {
         String opcaodoUsuario = ObterOpcaodoUsuario();
         while(opcaodoUsuario.ToUpper() !="x")
         {
            switch(opcaodoUsuario)
            {
               case "1":
               ListarBooks();
               break;
                case "2":
               InserirBooks();
               break;
                case "3":
               AtualizarBooks();
               break;
                case "4":
               ExcluirBooks();
               break;
                case "5":
               VisualizarBooks();
               break;
                case "c":
               Console.Clear();
               break;
               default:
               throw new ArgumentOutOfRangeException();
            }
          opcaodoUsuario = ObterOpcaodoUsuario();
         }
       
       Console.WriteLine("Obrigado por utilizar nossos serviços!");
       Console.ReadLine();

   }
       private static void ListarBooks()
       {
          Console.WriteLine("Listar Books:");
          var lista= repositorio.lista(); 
          if(lista.Count==0)
           {
             Console.WriteLine("nenhum Book cadastrado!");
             return;
           }
          foreach(var Books in lista)
           {
             Console.WriteLine("#Id{0} - {1}:", Books.retornaId(), Books.retornaTitulo());
           }
       }
      private static void InserirBooks()
       {
             Console.WriteLine("Inserir novo book!");

         foreach(int i in Enum.GetValues(typeof(Genero)))
           {
             Console.WriteLine("{0} - {1}:", i, Enum.GetName(typeof(Genero), i));
           }
             Console.Write("Digite o gênero entre as opções acima: ");
			   int entradaGenero = int.Parse(Console.ReadLine());

		   	Console.Write("Digite o Título do Book: ");
		    	string entradaTitulo = Console.ReadLine();

			   Console.Write("Digite o Ano de publicação do Book: ");
			   string entradaAno = (Console.ReadLine());
 
			   Console.Write("Digite a Descrição do Book: ");
		   	string entradaDescricao = Console.ReadLine();

            Console.Write("Digite os Autores do Book: ");
		   	string entradaAutores = Console.ReadLine();


		   	Books novoBooks = new Books(Id: repositorio.ProximoId(),
										Genero: (Genero)entradaGenero,
										Titulo: entradaTitulo,
                              Ano: entradaAno,
										Descricao: entradaDescricao,
                              Autores: entradaAutores);

		   	repositorio.Insere(novoBooks);
       
      }
      private static void AtualizarBooks()
		 {
			Console.Write("Digite o id do Book: ");
			int indiceBooks = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Book: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de publicação do Book ");
			string entradaAno = (Console.ReadLine());

			Console.Write("Digite a Descrição do Book: ");
			string entradaDescricao = Console.ReadLine();
         
         Console.Write("Digite os Autores do Book: ");
		   string entradaAutores = Console.ReadLine();


			Books atualizaBooks = new Books(Id: indiceBooks,
										Genero: (Genero)entradaGenero,
										Titulo: entradaTitulo,
										Ano: entradaAno,
										Descricao: entradaDescricao,
                              Autores: entradaAutores);

			repositorio.Atualiza(indiceBooks, atualizaBooks);
		}
      private static void ExcluirBooks()
		{
			Console.Write("Digite o id do Book: ");
			int indiceBooks = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceBooks);
		}
       private static void VisualizarBooks()
		{
			Console.Write("Digite o id do Book: ");
			int indiceBooks = int.Parse(Console.ReadLine());

			var books = repositorio.RetornaPorId(indiceBooks);

			Console.WriteLine(books);
		}

    private static string ObterOpcaodoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("Bookflix ao seu dispor!");
        Console.WriteLine("Informe a opção desejada: ");
        Console.WriteLine("1- Listar books");
        Console.WriteLine("2- Inserir novos books");
        Console.WriteLine("3- Atualizar books");
        Console.WriteLine("4- excluir books");
        Console.WriteLine("c- visualizar books");
        Console.WriteLine("x- Limpar tela");
        Console.WriteLine();

        String opcaodoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaodoUsuario;
    }
}
}
   
