using System;
using System.Collections.Generic;
using bookflix.interfaces;

namespace bookflix
{

public class BooksRepositorio : iRepositorio<Books>
 {
    private List<Books> Listabooks = new List<Books>();
    public void Atualiza(int Id, Books objeto)
    {
        Listabooks[Id] = objeto;
    }

    public void Exclui(int Id)
        {
        Listabooks[Id].Excluir();
        }
        public void Insere(Books objeto)
        {
            Listabooks.Add(objeto);
        }

        public List<Books> lista()
        {
            return Listabooks;
        }

        public int ProximoId()
        {
            return Listabooks.Count;
        }

        public Books RetornaPorId(int Id)
        {
            return Listabooks[Id];
        }
    }

       
    
}