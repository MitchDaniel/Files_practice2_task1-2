using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Task1
{
    internal static class RecipleManager
    {
        public static void Save(RecipeCollections recipes, string parth)
        {
            if (recipes == null) throw new ArgumentNullException($"{nameof(recipes)} is null");
            if(parth == null) throw new ArgumentNullException("Parth is null");
            using(StreamWriter swriter = new StreamWriter(parth))
            {
                foreach (Recipe recipe in recipes)
                {
                    swriter.WriteLine(recipe.Name);
                    swriter.WriteLine(recipe.Kitchen);
                    swriter.WriteLine(recipe.DescriptionCooking);
                    swriter.WriteLine(recipe.CookingTime.ToString());
                    swriter.WriteLine(recipe.Ingredients);
                }
            }
        }

        public static RecipeCollections Load(string path)
        {
            if (path is null)
            {
                throw new ArgumentNullException("Path is null");
            }
            RecipeCollections recipes = new RecipeCollections();
            using (StreamReader sreader = new StreamReader(path))
            {
                while (!sreader.EndOfStream)
                {
                    string name = sreader.ReadLine();
                    string kitchen = sreader.ReadLine();
                    string descriptionCooking = sreader.ReadLine();
                    string cookingTimeStr = sreader.ReadLine();
                    string ingredients = sreader.ReadLine();
                    if (TimeOnly.TryParse(cookingTimeStr, out TimeOnly cookingTime))
                    {
                        Recipe recipe = new Recipe(name, kitchen, ingredients, cookingTime, descriptionCooking);
                        recipes.Add(recipe);
                    }
                }
            }
            return recipes;
        }
    }
}

//Приложение должно позволять:
// Добавлять рецепты
// Удалять рецепты
// Изменять рецепты
// Искать рецепты по разным характеристикам
// Сохранять рецепты в файл
// Загружать рецепты из файла