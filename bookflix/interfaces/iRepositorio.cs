using System.Collections.Generic;
namespace bookflix.interfaces
{
    public interface iRepositorio<T>
    {
         
         List <T> lista();
         T RetornaPorId(int Id);
         void Insere(T entidade);
         void Exclui(int Id);
         void Atualiza(int Id, T entidade);
         int ProximoId();
    }
}