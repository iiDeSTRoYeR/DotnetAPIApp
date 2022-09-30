using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() 
        // public  ActionResult<IEnumerable<AppUser>> GetUsers()          //sync vs async   //IEnumerable is used because it is too simple, lists can be sorted, maniputlated, etc...
        {
            // var users = _context.Users.ToList();                      // ToList() is used to convert the IEnumerable to a list
            // return users;

            return await _context.Users.ToListAsync();
        }


        [Authorize]
        //e.g.,  api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)          
        {
            // var user = _context.Users.Find(id);                 
            // return user;

            return await _context.Users.FindAsync(id);
        }
    }
}