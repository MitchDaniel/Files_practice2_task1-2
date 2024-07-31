using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    enum TypeRecipe
    {
        Salad,
        First, 
        Second,
        Appetizer,
        Dessert
    }
    internal class Recipe
    {
        public Recipe(string name, string kitchen, string ingridients, TimeOnly cookingTime, string descriptionCooking, TypeRecipe typeRecipe, int calories)
        {
            Name = name;
            Kitchen = kitchen;
            Ingredients = ingridients;
            DescriptionCooking = descriptionCooking;
            CookingTime = cookingTime;
            TypeRecipe = typeRecipe;
            Calories = calories;
        }
        public string Name { get; set; }

        public string Kitchen { get ; set; }

        public string Ingredients {  get; set; }

        public TimeOnly CookingTime { get; set; }
        
        public string DescriptionCooking { get; set; }

        public TypeRecipe TypeRecipe { get; set; }

        public int Calories { get; set; }
    }

}

//Задание 1:
//Создайте приложение для работы с коллекцией рецептов. Рецепт содержит такие данные:
// Название рецепта
// Название кухни, откуда родом рецепт (Например, итальянская или японская)
// Названия ингредиентов
// Время готовки
// Описание процесса готовки по шагам

//Задание 3:
//Добавьте к приложению из первого задания дополнительные характеристики:
// Калории ингредиентов
// Тип блюда: салат, первое, второе, закуска, десерт
//Создайте дополнительные отчёты:
// По сумме калорий
// По типу блюда
// По комбинации типов блюд. Например, отчёт, который генерирует комбинацию блюд: з