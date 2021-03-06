using Cabana.BLL.Usuario.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabana.BLL.Usuario.Mappers
{
    internal static class UsuarioMappers
    {
        public static UsuarioDto ToDto(DAL.Models.Usuario entity)
        {
            return new UsuarioDto
            {
                UsuarioModificacion = entity.UsuarioModificacion,
                UsuarioId = entity.UsuarioId,
                UsuarioCreacion = entity.UsuarioCreacion,
                NombreUsuario = entity.NombreUsuario,
                FechaModificacion = entity.FechaModificacion,
                FechaCreacion = entity.FechaCreacion,
                NombreCompleto = entity.NombreCompleto,
                Correo = entity.Correo
            };
        }

        public static DAL.Models.Usuario ToEntity(UsuarioDto dto)
        {
            return new DAL.Models.Usuario
            {
                UsuarioModificacion = dto.UsuarioModificacion,
                UsuarioId = dto.UsuarioId,
                UsuarioCreacion = dto.UsuarioCreacion,
                NombreUsuario = dto.NombreUsuario,
                FechaModificacion = dto.FechaModificacion,
                FechaCreacion = dto.FechaCreacion,
                NombreCompleto = dto.NombreCompleto,
                Correo = dto.Correo,
                Clave = dto.Clave
            };
        }
    }
}
