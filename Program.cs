using System.Formats.Asn1;
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
            //foreach (var recipe in MommysRecipes)
            //{
            //    Console.WriteLine(recipe.Name);
            //    Console.WriteLine(recipe.Kitchen);
            //    Console.WriteLine(recipe.DescriptionCooking);
            //    Console.WriteLine(recipe.CookingTime.ToString());
            //    Console.WriteLine(recipe.Ingredients);
            //    Console.WriteLine();
            //}

            MommysRecipes.Add(new Recipe("Вареники с картошкой", "Украинская", "Мука, вода, соль, картофель, лук, масло", new TimeOnly(1, 15), "Замесить тесто, отварить картофель, сделать начинку из картофеля и лука, слепить вареники и отварить их"),
                              new Recipe("Голубцы", "Украинская", "Капуста, мясо, рис, лук, морковь, томатная паста, сметана", new TimeOnly(1, 45), "Отварить капусту, подготовить начинку из мяса, риса и лука, завернуть начинку в капустные листья, тушить с томатной пастой и сметаной"));
            //var temp = MommysRecipes.FindRecipes((x) => x.Kitchen == "Украинская");
            //foreach (var recipe in temp)
            //{
            //    Console.WriteLine(recipe.Name);
            //    Console.WriteLine(recipe.Kitchen);
            //    Console.WriteLine(recipe.DescriptionCooking);
            //    Console.WriteLine(recipe.CookingTime.ToString());
            //    Console.WriteLine(recipe.Ingredients);
            //    Console.WriteLine();
            //}
            ;
            RecipleManager.Save(RecipleManager.GetReport(MommysRecipes, (x) => x.CookingTime < new TimeOnly(1, 0)),
                @"C:\Users\Brill\Desktop\Report.txt");

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

//Задание 2:
//Добавьте к приложению из первого задания возможность генерировать отчёты.
//Отчёт может быть отображён на экран или сохранён в файл. Создайте такие отчёты:
// По типу кухни
// По времени готовки
// По названиям ингредиентов
// По названию рецепта


//Задание 3:
//Добавьте к приложению из первого задания дополнительные характеристики:
// Калории ингредиентов
// Тип блюда: салат, первое, второе, закуска, десерт
//Создайте дополнительные отчёты:
// По сумме калорий
// По типу блюда
// По комбинации типов блюд. Например, отчёт, который генерирует комбинацию блюд: закуска, салат, первое, второе, десерт.