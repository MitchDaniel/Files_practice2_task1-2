using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class RecipeCollections : IEnumerable<Recipe>
    {
        List<Recipe> _recipesList = new List<Recipe>();

        public void Add(params Recipe[] recipes)
        {
            if(recipes is null)
            {
                throw new ArgumentNullException();
            }
            _recipesList.AddRange(recipes);
        }

        public void Delete(Recipe recipe)
        {
            if(recipe is null) 
            { 
                throw new ArgumentNullException(); 
            }
            for (int i = 0; i < _recipesList.Count; i++)
            {
                if (_recipesList[i].Name == recipe.Name)
                {
                    _recipesList.Remove(_recipesList[i]);
                }
            }
        }

        public void Edit(Recipe oldRecipe, Recipe newRecipe)
        {
            if(oldRecipe is null || newRecipe is null)
            {
                throw new ArgumentNullException("First argument is null");
            }
            if (newRecipe is null)
            {
                throw new ArgumentNullException("Second argument is null");
            }
            for (int i = 0; i < _recipesList.Count; i++)
            {
                if (_recipesList[i].Name == oldRecipe.Name)
                {
                    _recipesList[i] = newRecipe;
                }
            }
        }

        public List<Recipe> FindRecipes(Predicate<Recipe> findPredicate)
        {
            if (findPredicate is null)
            {
                throw new ArgumentNullException();
            }
            List<Recipe> recipesFound = new List<Recipe>();
            foreach (Recipe recipe in _recipesList) 
            {
                if (findPredicate(recipe))
                {
                    recipesFound.Add(recipe);
                }
            }
            if(recipesFound.Count == 0)
            {
                throw new Exception("Recipes not found");
            }
            return recipesFound;
        }

        #region IEnumerator implementation 
        public IEnumerator<Recipe> GetEnumerator()
        {
            for (int i = 0; i < _recipesList.Count; i++)
            {
                yield return _recipesList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion 
    }
}


//Приложение должно позволять:
// Добавлять рецепты
// Удалять рецепты
// Изменять рецепты
// Искать рецепты по разным характеристикам
// Сохранять рецепты в файл
// Загружать рецепты из файла