﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Cocktails.Domain.Models;
using Cocktails.WebApi.Resources;
using ConsoleApp;

namespace ApiClientConsoleApp
{
    public interface IIngredientsProcess
    {
        Task<RawIngredientsList> LoadIngredients();
        List<SaveIngredientResource> ProcessIngredientData(RawIngredientsList rawIngredientsList);
        void SaveIngredients(List<SaveIngredientResource> ingredients);
        Task<IEnumerable<Ingredient>> GetAllIngredients();
    }
}