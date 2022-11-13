﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.Core;
using Recipes.Repos.Dto;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Repos
{

    public class UsersRepository
    {
        private readonly RecipesContext _ctx;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsersRepository(RecipesContext ctx,
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager, IHttpContextAccessor httpContextAccessor)
        {
            _ctx = ctx;
            this.userManager = userManager;
            this.roleManager = roleManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<User> CreateUserAsync(string? firstName, string? lastName, string? password, string? email)
        {
            var newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                UserName = email,
                NormalizedEmail = email.ToUpper(),
                NormalizedUserName = email.ToUpper(),
                EmailConfirmed = true
            };

            await userManager.CreateAsync(newUser, password);

            return await _ctx.Users.FirstAsync(x => x.Email == email);
        }

        [HttpGet]
        [Authorize]
        public async Task<User> GetCurrentUser()
        {
            var current_user = _httpContextAccessor.HttpContext.User.Identity.Name;
            var user = await userManager.FindByNameAsync(current_user);
            return user;

        }
        public async Task DeleteUserAsync(string id)
        {
            var user = _ctx.Users.Find(id);

            if ((await userManager.GetRolesAsync(user)).Any())
            {
                await userManager.RemoveFromRolesAsync(user, await userManager.GetRolesAsync(user));
            }
            await userManager.DeleteAsync(user);
        }

        public async Task<IEnumerable<IdentityRole>> GetRolesAsync()
        {
            return await _ctx.Roles.ToListAsync();
        }

        public async Task<UserReadDto> GetUserAsync(string id)
        {
            var u = await _ctx.Users.FirstAsync(x => x.Id == id);

            var userDto = new UserReadDto
            {
                Id = u.Id,
                Email = u.Email,
                FirstName = u.FirstName,
                LastName = u.LastName,
                IsConfirmed = u.EmailConfirmed,
                Roles = new List<IdentityRole>()
            };

            foreach (var role in await userManager.GetRolesAsync(u))
            {
                userDto.Roles.Add(await _ctx.Roles.FirstAsync(x => x.Name.ToLower() == role.ToLower()));
            }

            return userDto;
        }

        public async Task<IEnumerable<UserReadDto>> GetUsersAsync()
        {
            var users = new List<UserReadDto>();

            foreach (var u in _ctx.Users.ToList())
            {
                var userDto = new UserReadDto
                {
                    Id = u.Id,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    IsConfirmed = u.EmailConfirmed,
                    Roles = new List<IdentityRole>()
                };

                foreach (var role in await userManager.GetRolesAsync(u))
                {
                    userDto.Roles.Add(await _ctx.Roles.FirstAsync(x => x.Name.ToLower() == role.ToLower()));
                }

                users.Add(userDto);
            }
            return users;
        }

        public async Task UpdateAsync(UserReadDto model, string[] roles)
        {
            var user = _ctx.Users.Find(model.Id);

            if (user.Email != model.Email)
            {
                user.Email = model.Email;
                user.UserName = model.Email;
                user.NormalizedUserName = model.Email.ToUpper();
                user.NormalizedEmail = model.Email.ToUpper();
            }

            if (user.FirstName != model.FirstName)
                user.FirstName = model.FirstName;

            if (user.LastName != model.LastName)
                user.LastName = model.LastName;
            if (user.EmailConfirmed != model.IsConfirmed)
                user.EmailConfirmed = model.IsConfirmed;

            //var admRole = await roleManager.FindByNameAsync("Admin");
            if ((await userManager.GetRolesAsync(user)).Any())
            {
                await userManager.RemoveFromRolesAsync(user, await userManager.GetRolesAsync(user));
            }

            if (roles.Any())
            {
                await userManager.AddToRolesAsync(user, roles.ToList());
            }
        }
    }
}
