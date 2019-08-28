using System.Collections.Generic;
using BooksApi.Models.UsersModel;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public ActionResult<List<User>> Get() =>
            _userService.Get();


        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            _userService.Create(user);

            return CreatedAtRoute("GetBook", new { id = user.Id.ToString() }, user);
        }

    }
}