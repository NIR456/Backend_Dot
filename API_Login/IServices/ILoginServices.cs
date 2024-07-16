using API_Login.Models.ModelResponse;
using Microsoft.AspNetCore.Mvc;

namespace API_Login.IServices
{
    public interface ILoginServices
    {
        public Task<Response> GetUserKey(string username);
    }
}
