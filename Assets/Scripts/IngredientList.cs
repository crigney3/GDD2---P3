﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientList : MonoBehaviour
{
    private List<Ingredient> ingredients;
    private int[] indexOfCategory;
    private int[] endOfCategory;
    private int ingredientCount;

    // Start is called before the first frame update
    void Start()
    {
        indexOfCategory = new int[8];
        ingredients = new List<Ingredient>();
        ingredientCount = 0;

        Ingredient newIngredient;
        INGREDIENT_CATEGORY currentCat = INGREDIENT_CATEGORY.Base;

        //start with adding the bases
        indexOfCategory[(int)currentCat] = ingredientCount;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Cola", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight, INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Tequila", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Romance, INGREDIENT_TAG.Potent, INGREDIENT_TAG.Clear});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Coffee", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.Potent, INGREDIENT_TAG.RemediesRough});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Water", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Clear, INGREDIENT_TAG.BasicBland});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Holy Water", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly, INGREDIENT_TAG.Clear});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Tomato Juice", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.RemediesRough, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Seltzer Water", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight, INGREDIENT_TAG.Clear});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Tang", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.Space, INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Milk", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.BasicBland, INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        //add new ingredients here if we make them (same goes for all other categories

        endOfCategory[(int)currentCat] = ingredientCount;


        //Sight
        currentCat = INGREDIENT_CATEGORY.Sight;
        indexOfCategory[(int)currentCat] = ingredientCount;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Shadow", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly, INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Candlelight", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Romance});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Sunshine", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Plastic Wrap", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Clear, INGREDIENT_TAG.BasicBland});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Magazine Clipping of Meatloaf", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.RemediesRough, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Moonlight", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Space, INGREDIENT_TAG.Romance, INGREDIENT_TAG.DarkHoly});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Photo of Geese", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "The Color Red", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Potent, INGREDIENT_TAG.Romance});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Reflection", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Clear});
        ingredients.Add(newIngredient);
        ingredientCount++;

        endOfCategory[(int)currentCat] = ingredientCount;


        //Sound
        currentCat = INGREDIENT_CATEGORY.Sound;
        indexOfCategory[(int)currentCat] = ingredientCount;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Mouse Scampers", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Sigh", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight, INGREDIENT_TAG.Romance});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Rooster's Crow", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.Potent, INGREDIENT_TAG.RemediesRough});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Rustle of Wind", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Clear, INGREDIENT_TAG.BasicBland});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Singing", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Romance, INGREDIENT_TAG.Morning});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Creaking Floorboards", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Travel, INGREDIENT_TAG.DarkHoly});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Silence", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Clear, INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Wolf Howling", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly, INGREDIENT_TAG.Potent, INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Bird Chirping", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight, INGREDIENT_TAG.Morning});
        ingredients.Add(newIngredient);
        ingredientCount++;

        endOfCategory[(int)currentCat] = ingredientCount;


        //Smell
        currentCat = INGREDIENT_CATEGORY.Smell;
        indexOfCategory[(int)currentCat] = ingredientCount;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Motor Oil", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Perfume", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Romance, INGREDIENT_TAG.FloatLight});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Fresh Soap", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.BasicBland});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Deodorant", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.BasicBland, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Dung", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Burnt Steak", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Air Freshener", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Travel, INGREDIENT_TAG.FloatLight});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Scented Oils", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Clear, INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Skunk Hairs", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.RemediesRough, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        endOfCategory[(int)currentCat] = ingredientCount;


        //Touch
        currentCat = INGREDIENT_CATEGORY.Touch;
        indexOfCategory[(int)currentCat] = ingredientCount;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Bird's Feather", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight, INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Lace", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Romance});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Washcloth", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.RemediesRough});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Plain White Cotton", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.BasicBland, INGREDIENT_TAG.FloatLight});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Sandpaper", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.RemediesRough});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Driftwood", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Bubble Wrap", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Clear});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Rose Thorns", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Cold Iron", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly, INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        endOfCategory[(int)currentCat] = ingredientCount;


        //Taste
        currentCat = INGREDIENT_CATEGORY.Taste;
        indexOfCategory[(int)currentCat] = ingredientCount;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Espresso Beans", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Dark Chocolate", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Romance, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Morning Doughnut", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.Clear});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Leaf of Lettuce", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.BasicBland});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Aspirin", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.RemediesRough});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Basil", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Cotton Candy", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Ice Cream", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Durian", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Potent, INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        endOfCategory[(int)currentCat] = ingredientCount;


        //Mind
        currentCat = INGREDIENT_CATEGORY.Mind;
        indexOfCategory[(int)currentCat] = ingredientCount;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Bus Ticket", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Diamond", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Romance});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "To-do List", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Blank Piece of Paper", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.BasicBland});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Surgeon General's Warning", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.RemediesRough});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Depleted Uranium", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Airplane Catalog", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight, INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Broken Glass", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Clear});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Moondust", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        endOfCategory[(int)currentCat] = ingredientCount;


        //Spirit
        currentCat = INGREDIENT_CATEGORY.Spirit;
        indexOfCategory[(int)currentCat] = ingredientCount;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Small Broken Chain", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Travel, INGREDIENT_TAG.DarkHoly});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Love Letter", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Romance});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Rock Music", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Morning, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Elevator Music", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.BasicBland, INGREDIENT_TAG.Clear});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Incense Smoke", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.RemediesRough, INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Musty Photograph", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Potent});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Travel Brochure", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.FloatLight, INGREDIENT_TAG.Travel});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Dreams", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.Space});
        ingredients.Add(newIngredient);
        ingredientCount++;

        newIngredient = new Ingredient();
        newIngredient.Init(ingredientCount, "Nightmares", currentCat, new List<INGREDIENT_TAG>()
        { INGREDIENT_TAG.DarkHoly});
        ingredients.Add(newIngredient);
        ingredientCount++;

        //end the final category
        endOfCategory[(int)currentCat] = ingredientCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    INGREDIENT_TAG mixPotion(int[] selectedIngredients)
    {
        int[] numberTags = new int[8];

        //loops through every ingredient used, and increases the tags each time the tag is used
        foreach(int index in selectedIngredients)
        {
            List<INGREDIENT_TAG> tags = ingredients[index].Tags;

            //increases each tag's instance
            foreach(INGREDIENT_TAG tag in tags)
            {
                numberTags[(int)tag]++;
            }
        }

        //return the type of tag that there is the most of
        INGREDIENT_TAG returnTag = INGREDIENT_TAG.BasicBland;
        int returnCount = 0;
        for (int i = 0; i < numberTags.Length; i++) 
        {
            //find the new greatest
            if(numberTags[i] > returnCount)
            {
                returnCount = numberTags[i];
                returnTag = (INGREDIENT_TAG)i;
            }
        }
        return returnTag;
    }
}

public enum INGREDIENT_CATEGORY { Base, Sight, Sound, Smell, Touch, Taste, Mind, Spirit};
public enum INGREDIENT_TAG { Travel, Romance, Morning, BasicBland, RemediesRough, Space, Clear, FloatLight, Potent, DarkHoly};