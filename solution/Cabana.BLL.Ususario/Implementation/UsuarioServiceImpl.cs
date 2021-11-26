using Cabana.BLL.Comun.DataTransferObject;
using Cabana.BLL.Usuario.BusinessInteface;
using Cabana.BLL.Usuario.DataTransferObject;
using Cabana.BLL.Usuario.Mappers;
using Cabana.DAL.Implementation;
using Cabana.DAL.Interfaces;

namespace Cabana.BLL.Usuario.BusinessImplement
{
    public class UsuarioServiceImpl : IUsuarioService
    {

        private readonly IGenericRepository<DAL.Models.Usuario> _usuarioDao;

        public UsuarioServiceImpl()
        {
            _usuarioDao = new GenericRepository<DAL.Models.Usuario>();
        }

        public SingleResponse<UsuarioDto> Login(UsuarioDto usuario)
        {
            var usuarioreg = _usuarioDao.GetByCriteria(h => h.NombreUsuario == usuario.NombreUsuario && h.Clave == usuario.Clave).FirstOrDefault();

            if (usuarioreg != null)
            {
                return new SingleResponse<UsuarioDto> { IsValid = true, Model=UsuarioMappers.ToDto(usuarioreg)};
            }
            else
            {
                return new SingleResponse<UsuarioDto> { IsValid = false, Mensaje="no existe boludo" };
            }
        }
        //Registro
        public SingleResponse<UsuarioDto> Insert(UsuarioDto usuario)
        {
            try
            {
                var usuarioreg = _usuarioDao.Insert(UsuarioMappers.ToEntity(usuario));
                _usuarioDao.SaveChanges();
                return new SingleResponse<UsuarioDto> { IsValid = true, Model = UsuarioMappers.ToDto(usuarioreg) };
            }
            catch (Exception ex)
            {
                return new SingleResponse<UsuarioDto> { IsValid = false, Mensaje = "intentelo nuevamente" };
            }
           
        }
    }
}