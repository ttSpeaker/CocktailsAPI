﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cocktails.Domain.Models;
using Cocktails.Domain.Services.Communication;

namespace Cocktails.Domain.Services
{
    public interface ICategoryService
    { 
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id,Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
