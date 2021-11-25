using Cabana.BLL.Comun.DataTransferObject;
using Cabana.BLL.Usuario.DataTransferObject;

namespace Cabana.BLL.Usuario.BusinessInteface
{
    public interface IUsuarioService
    {
         SingleResponse<UsuarioDto> Login(UsuarioDto usuario);
    }
}