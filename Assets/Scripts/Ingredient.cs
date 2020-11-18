using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    private int ID = 0;
    private string ingredientName = "none";
    private INGREDIENT_CATEGORY category = INGREDIENT_CATEGORY.Base;
    private List<INGREDIENT_TAG> tags;

    //accessors
    public List<INGREDIENT_TAG> Tags => tags;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Init(int newID, string newIngredientName, INGREDIENT_CATEGORY newCategory, List<INGREDIENT_TAG> newTags)
    {
        //sets the values for this particular ingredient
        ID = newID;
        ingredientName = newIngredientName;
        category = newCategory;
        tags = newTags;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
