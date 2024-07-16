namespace API_Login.Models.ModelResponse
{
    public class Response
    {
        public bool ResponseStatus { get; set; }
        public string ResponseMessage { get; set; } = string.Empty;
        public object ResponseObject { get; set; } = new object();
        public int RoleId { get; set; }
    }
}
