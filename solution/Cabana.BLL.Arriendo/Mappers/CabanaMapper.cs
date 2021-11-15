using Cabana.BLL.Arriendo.DataTransferObject;

namespace Cabana.BLL.Arriendo.Mappers
{
    internal static class CabanaMapper
    {
        public static DAL.Models.Cabana ToEntity(CabanaDto dto)
        {
            return new DAL.Models.Cabana
            {
                FechaCreacion = DateTime.Now,
                UsuarioCreacion = dto.UsuarioCreacion,
                ModeloCabanaId = dto.ModeloCabanaId,
                NumeroCabana = dto.NumeroCabana
            };
        }

        public static CabanaDto ToDto(DAL.Models.Cabana entity)
        {
            return new CabanaDto
            {
                FechaCreacion = entity.FechaCreacion,
                UsuarioCreacion = entity.UsuarioCreacion,
                ModeloCabanaId = entity.ModeloCabanaId,
                NumeroCabana = entity.NumeroCabana,
                CabanaId = entity.CabanaId
            };
        }
    }
}