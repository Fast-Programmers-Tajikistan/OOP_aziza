namespace ООП_1.Responses
{
    public class BaseResponse<T>
    {
            public T Data { get; set; }
            public string Message { get; set; }
            public ResponseStatus Status { get; set; }
        }
    }

