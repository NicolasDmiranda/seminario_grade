namespace Cabana.BLL.Arriendo.DataTransferObject
{
    public  class CabanaDto
    {
        public int CabanaId { get; set; }
        public int ModeloCabanaId { get; set; }
        public int NumeroCabana { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}