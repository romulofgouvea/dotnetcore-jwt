namespace jwt.Domain.Models
{
    public class ResponseModel
    {
        public string Message { get; set; }
    }

    public class ErrorModel : ResponseModel
    {
    }

    public class SuccessModel : ResponseModel
    {
        public object Result { get; set; }
    }
}
