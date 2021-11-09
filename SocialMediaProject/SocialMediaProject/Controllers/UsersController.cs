using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialMediaProject.Data;
using SocialMediaProject.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMediaProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly SocialMediaProjectDataContext _socialMediaProjectDataContext;

        public UsersController(SocialMediaProjectDataContext socialMediaProjectDataContext)
        {
            _socialMediaProjectDataContext = socialMediaProjectDataContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _socialMediaProjectDataContext.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int? id)
        {
            return await _socialMediaProjectDataContext.Users.FindAsync(id);
        }
    }
}
