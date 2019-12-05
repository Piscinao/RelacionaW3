using System.Collections.Generic;

namespace Repositorio.Interfaces
{
    // Interface responsável pelas operações genéricas
    public interface IRepositorio<TEntidade>
        where TEntidade: class
    {
        // Create e Update
        void Create(TEntidade Entity);
        // Retorna um registro
        TEntidade Read(int id);
        // Deleta um registro
        void Delete(int id);

        // Listagem de vários registros
        IEnumerable<TEntidade> Read();

    }
}
