﻿using ChattingApp.Domain.Models;
using ChattingApp.Resource.User;
using System.Linq;

namespace ChattingApp.Persistence.IRepositories
{
    public interface IUserRepository
    {
        Task<IQueryable<AppUsers>> GetUsersAsync();
        Task<UserResponseDto> GetUserByIdAsync(string Id);
        Task<AppUsers> GetUserByNameAsync(string UserName);
        void UpdateUserAsync(string Id, AppUsers appUsers);
        void DeleteUserAsync(string Id);
        Task<bool> SaveChangesAsync();


    }
}
