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
                    swriter.WriteLine(recipe.TypeRecipe);
                    swriter.WriteLine(recipe.Calories);
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
                    string typeRecipe = sreader.ReadLine();
                    string calories = sreader.ReadLine();
                    if (TimeOnly.TryParse(cookingTimeStr, out TimeOnly cookingTime) && Enum.TryParse(typeRecipe, out TypeRecipe tempTypeRecipe) && int.TryParse(calories, out int tempCalories))
                    {
                        recipes.Add(new Recipe(name, kitchen, ingredients, cookingTime, descriptionCooking, tempTypeRecipe, tempCalories));
                    }
                    else
                    {
                        throw new InvalidCastException();
                    }
                }
            }
            return recipes;
        }

        public static RecipeCollections GetReport(RecipeCollections recipesCollection, Predicate<Recipe> reportPredicate)
        {
            if(recipesCollection is null)
            {
                throw new ArgumentNullException($"{nameof(recipesCollection)} is null");
            }
            if(reportPredicate is null)
            {
                throw new ArgumentNullException($"{nameof(reportPredicate)} is null");
            }
            RecipeCollections report = new RecipeCollections();
            int countOfRecipe = 0;
            foreach(Recipe recipe in recipesCollection)
            {
                if(reportPredicate(recipe))
                {
                    report.Add(recipe);
                    countOfRecipe++;
                }
            }
            if(countOfRecipe == 0)
            {
                throw new Exception("Recipe not found");
            }
            return report;
        }
    }
}

//Задание 2:
//Добавьте к приложению из первого задания возможность генерировать отчёты.
//Отчёт может быть отображён на экран или сохранён в файл. Создайте такие отчёты:
// По типу кухни
// По времени готовки
// По названиям ингредиентов
// По названию рецепта

#region Task1
//Приложение должно позволять:
// Добавлять рецепты
// Удалять рецепты
// Изменять рецепты
// Искать рецепты по разным характеристикам
// Сохранять рецепты в файл
// Загружать рецепты из файла
#endregion