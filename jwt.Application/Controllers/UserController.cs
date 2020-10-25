using jwt.Domain.Constants;
using jwt.Domain.Entities;
using jwt.Domain.Interfaces;
using jwt.Domain.Models;
using jwt.Services.Helper;
using jwt.Services.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace jwt.Application.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromServices] IUserRepository userRepository, [FromBody] User user)
        {
            try
            {
                var userExists = await userRepository.ExistsEmailOrUsername(user);

                if (userExists)
                {
                    return BadRequest(new ErrorModel
                    {
                        Message = "O usuário já existe"
                    });
                }

                user.Created = user.Updated = DateTime.Now;

                user.Password = GeneratorHelper.GeneratePassword(user.Password);

                await userRepository.Insert(user);

                return Ok(new SuccessModel
                {
                    Message = Constants.SUCCESS_CREATE_DATA,
                    Result = user.CreateToken()
                });
            }
            catch
            {
                return BadRequest(new ErrorModel
                {
                    Message = Constants.ERROR_CREATE_DATA
                });
            }
        }
    }
}
