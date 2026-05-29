using SenacGames.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<GameDto>> GetAllAsync();
        Task<GameDto?> GetByIdAsync(int id);
        Task<IEnumerable<GameDto>> GetFeaturedAsync();
        Task <IEnumerable<GameDto>> GetByCategoryAsync(int categoryId);
        Task<GameDto> CreateAsync(CreateGameDto dto);
        Task<GameDto?> UpdateAsync(UpdateGameDto dto); 
        Task<GameDto?> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
