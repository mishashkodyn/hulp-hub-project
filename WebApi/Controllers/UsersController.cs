using Application.DTOs.User;
using AutoMapper;
using Domain.Common;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(ApplicationDbContext context, IMapper maper, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = maper;
            _userManager = userManager;
        }

        [HttpGet("get-user/{id}")]
        [Authorize]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == id);

            if (user == null) throw new Exception();

            var roles = await _userManager.GetRolesAsync(user);

            var mappedUser = _mapper.Map<UserProfileDto>(user);

            mappedUser.Roles = roles;

            return Ok(Response<UserProfileDto>.Success(mappedUser));
        }
    }
}
