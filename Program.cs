﻿using System.Formats.Asn1;
using Task1;

namespace CSharp_Practice_modul_12_part_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RecipeCollections recipes = new RecipeCollections();
            //recipes.Add(new Recipe("Борщ", "Украинская", "Вода, соль, буряк", new TimeOnly(2, 30), "Закипетить воду, посолить, нарезать буряк"),
            //            new Recipe("Плов", "Узбекская", "Рис, мясо, морковь, лук, специи", new TimeOnly(1, 45), "Обжарить мясо, добавить лук и морковь, затем рис и специи"),
            //            new Recipe("Пицца Маргарита", "Итальянская", "Тесто, томатный соус, сыр, базилик", new TimeOnly(0, 25), "Раскатать тесто, смазать томатным соусом, добавить сыр и базилик, запечь в духовке"),
            //            new Recipe("Суши", "Японская", "Рис, рыба, водоросли, соевый соус", new TimeOnly(1, 0), "Приготовить рис, нарезать рыбу, свернуть суши в водорослях, подавать с соевым соусом"),
            //            new Recipe("Том Ям", "Тайская", "Креветки, кокосовое молоко, лимонник, галангал, лайм", new TimeOnly(0, 40), "Кипятить кокосовое молоко, добавить креветки и специи, варить до готовности"),
            //            new Recipe("Рататуй", "Французская", "Кабачки, баклажаны, помидоры, перец, лук, чеснок, зелень", new TimeOnly(1, 15), "Нарезать овощи, обжарить, запекать в духовке, посыпать зеленью перед подачей"));
            //foreach (Recipe recipe in recipes)
            //{
            //    Console.WriteLine(recipe.Name);
            //    Console.WriteLine(recipe.Kitchen);
            //    Console.WriteLine(recipe.DescriptionCooking);
            //    Console.WriteLine(recipe.CookingTime.ToString());
            //    Console.WriteLine(recipe.Ingredients);
            //    Console.WriteLine();
            //}
            //recipes.Delete(new Recipe("Том Ям", "Тайская", "Креветки, кокосовое молоко, лимонник, галангал, лайм", new TimeOnly(0, 40), "Кипятить кокосовое молоко, добавить креветки и специи, варить до готовности"));
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Recipe borsh = new Recipe("", "", "",new TimeOnly(0,0), "" );
            //foreach (Recipe recipe in recipes)
            //{
            //    Console.WriteLine(recipe.Name);
            //    Console.WriteLine(recipe.Kitchen);
            //    Console.WriteLine(recipe.DescriptionCooking);
            //    Console.WriteLine(recipe.CookingTime.ToString());
            //    Console.WriteLine(recipe.Ingredients);
            //    Console.WriteLine();
            //    if(recipe.Name == "Борщ")
            //    {
            //        borsh = recipe;
            //    }
            //}

            //recipes.Edit(borsh, new Recipe("Чили кон карне", "Мексиканская", "Фарш, фасоль, томаты, лук, чеснок, чили, специи", new TimeOnly(1, 30), "Обжарить фарш с луком и чесноком, добавить фасоль, томаты и специи, тушить до готовности"));
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (Recipe recipe in recipes)
            //{
            //    Console.WriteLine(recipe.Name);
            //    Console.WriteLine(recipe.Kitchen);
            //    Console.WriteLine(recipe.DescriptionCooking);
            //    Console.WriteLine(recipe.CookingTime.ToString());
            //    Console.WriteLine(recipe.Ingredients);
            //    Console.WriteLine();
            //}

            //RecipleManager.Save(recipes, @"C:\Users\Brill\Desktop\Source.txt");

            RecipeCollections MommysRecipes = RecipleManager.Load(@"C:\Users\Brill\Desktop\Source.txt");
            foreach (var recipe in MommysRecipes)
            {
                Console.WriteLine(recipe.Name);
                Console.WriteLine(recipe.Kitchen);
                Console.WriteLine(recipe.DescriptionCooking);
                Console.WriteLine(recipe.CookingTime.ToString());
                Console.WriteLine(recipe.Ingredients);
                Console.WriteLine();
            }
        }
    }
}

//Задание 1:
//Создайте приложение для работы с коллекцией рецептов. Рецепт содержит такие данные:
// Название рецепта
// Название кухни, откуда родом рецепт (Например, итальянская или японская)
// Названия ингредиентов
// Время готовки
// Описание процесса готовки по шагам
//Приложение должно позволять:
// Добавлять рецепты
// Удалять рецепты
// Изменять рецепты
// Искать рецепты по разным характеристикам
// Сохранять рецепты в файл
// Загружать рецепты из файла