namespace bookflix
{
    public class Books : EntidadeBase
    {
        // Atributos 
         
         private Genero Genero {get; set;}
         private String Titulo { get; set;}
         private String Descricao {get; set;}
         private String Ano{get; set;}
         private String Autores {get; set;}
         private bool Excluido {get; set;}

      // metodos 
    public Books (int Id, Genero Genero, String Titulo, String Descricao, string  Ano, String Autores)
    {
        this.Id= Id;
        this.Genero= Genero;
        this.Titulo = Titulo;
        this.Descricao = Descricao;
        this.Ano= Ano;
        this.Autores= Autores;
        this.Excluido= false;
    }
        public override string ToString()
        {
            String retorno= "";
            retorno+= "Gênero: "+ this.Genero+ Environment.NewLine;
            retorno+= "Título: "+ this.Titulo+ Environment.NewLine;
            retorno+= "Descrição: "+ this.Descricao+ Environment.NewLine;
            retorno+= "Ano: "+ this.Ano+ Environment.NewLine;
            retorno+= "Autores:"+ this.Autores + Environment.NewLine;
            return retorno;

        }

        public String retornaTitulo()
        {
          return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
          this.Excluido= true;
        }
    }
}