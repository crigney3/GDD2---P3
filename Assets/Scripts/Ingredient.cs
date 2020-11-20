using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient
{
    private int ID = 0;
    private string ingredientName = "none";
    private INGREDIENT_CATEGORY category = INGREDIENT_CATEGORY.Base;
    private List<INGREDIENT_TAG> tags;
    private Sprite sprite;

    //accessors
    public List<INGREDIENT_TAG> Tags => tags;
    public Sprite Sprite => sprite;
    public string Name => ingredientName;

    public void Init(int newID, string newIngredientName, INGREDIENT_CATEGORY newCategory, List<INGREDIENT_TAG> newTags)
    {
        //sets the values for this particular ingredient
        ID = newID;
        ingredientName = newIngredientName;
        category = newCategory;
        tags = newTags;
        sprite = Resources.Load<Sprite>(category.ToString() + "/" + ingredientName);
    }
}
