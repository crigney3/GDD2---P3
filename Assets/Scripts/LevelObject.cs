using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObject
{
    private INGREDIENT_TAG winIngredientTag;

    public LevelObject(INGREDIENT_TAG winTag)
    {
        winIngredientTag = winTag;
    }

    public INGREDIENT_TAG getWinTag()
    {
        return winIngredientTag;
    }

    public bool checkWin(INGREDIENT_TAG potion)
    {
        if(potion == winIngredientTag)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
