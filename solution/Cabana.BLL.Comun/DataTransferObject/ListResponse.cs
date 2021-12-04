namespace Cabana.BLL.Comun.DataTransferObject
{
    public class ListResponse<T> : RespuestaBase
    {
        public ListResponse()
        {
            ResultList = new List<T>();
        }

        public List<T> ResultList { get; set; }
    }
}