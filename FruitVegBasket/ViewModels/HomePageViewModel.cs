﻿using FruitVegBasket.Models;
using Services;
using System.Collections.ObjectModel;

namespace FruitVegBasket.ViewModels
{
    public partial class HomePageViewModel
    {
        private readonly CategoryService _categoryService;

        public HomePageViewModel(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ObservableCollection<Category> Categories { get; set; } = new();

        public async Task InitializeAsync()
        {
            foreach (var category in await _categoryService.GetMainCategoriesAsync())
            {
                Categories.Add(category);
            }
        }
    }
}
