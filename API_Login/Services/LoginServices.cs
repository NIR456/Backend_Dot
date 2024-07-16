using API_Login.Database;
using API_Login.IServices;
using API_Login.Models;
using API_Login.Models.ModelResponse;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace API_Login.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly DbContextClass _dbContext;

        public LoginServices(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Response> GetUserKey(string username)
        {
            Response response = new();

            try
            {
                LoginUser_mdl userlogin = await _dbContext.LoginUser.FirstOrDefaultAsync(x => x.UserName == username).ConfigureAwait(false);

                if (userlogin != null)
                {
                    response.ResponseStatus = true;
                    response.ResponseMessage = "Success";
                    response.RoleId = userlogin.RoleId;
                    response.ResponseObject = userlogin; // Optionally include the user object
                }
                else
                {
                    response.ResponseStatus = false;
                    response.ResponseMessage = "User Not Exist";
                    response.RoleId = 0; // Or another appropriate default value
                }
            }
            catch (Exception ex)
            {
                response.ResponseStatus = false;
                response.ResponseMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                response.RoleId = 0; // Or another appropriate default value
            }

            return response;
        }
    }
}
