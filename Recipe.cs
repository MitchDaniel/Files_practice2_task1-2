using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Recipe
    {
        public Recipe(string name, string kitchen, string ingridients, TimeOnly cookingTime, string descriptionCooking)
        {
            Name = name;
            Kitchen = kitchen;
            Ingredients = ingridients;
            DescriptionCooking = descriptionCooking;
            CookingTime = cookingTime;
        }
        public string Name { get; set; }

        public string Kitchen { get ; set; }

        public string Ingredients {  get; set; }

        public TimeOnly CookingTime { get; set; }
        
        public string DescriptionCooking { get; set; }
    }

}

//Задание 1:
//Создайте приложение для работы с коллекцией рецептов. Рецепт содержит такие данные:
// Название рецепта
// Название кухни, откуда родом рецепт (Например, итальянская или японская)
// Названия ингредиентов
// Время готовки
// Описание процесса готовки по шагам