using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Quantidade de games nesta categoria
        /// util para mostrar no dashbord e na listagem
        /// </summary>
        public int GameCount { get; set; }
    }

    /// <summary>
    /// DTO para criação de uma nova categoria 
    /// </summary>
    public class CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }

    /// <summary>
    /// Dto para atualização de uma categoria existente
    /// </summary>
    public class UpdateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
