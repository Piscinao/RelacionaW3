using RelacionaW3.Dominio.Entidades;

namespace Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoUsuario
    {
        bool ValidarLogin(string email, string senha);

        Usuario RetornarDadosUsuario(string email, string senha);
    }
}
