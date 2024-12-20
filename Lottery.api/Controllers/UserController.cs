﻿using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LotteryFactory.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    { 
        readonly IUserService _usersService;
        public UserController(IUserService usersService)
        {
            _usersService = usersService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _usersService.GetUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User u = _usersService.GetUserById(id);
            if (u == null)
                return NotFound(u);
            return u;
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] User user)
        {
            if (_usersService.AddUser(user) != null)
                return true;
            return BadRequest(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, [FromBody] User user)
        {
            return _usersService.UpdateUser(id, user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _usersService.RemoveUser(id);
        }


    }
}
