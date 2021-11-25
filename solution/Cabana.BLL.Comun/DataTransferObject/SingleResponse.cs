namespace Cabana.BLL.Comun.DataTransferObject
{
    public class SingleResponse<T>:RespuestaBase
    {
        public T Model { get; set; }
    }
}
