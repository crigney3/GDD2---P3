using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObject
{
    private INGREDIENT_TAG winIngredientTag;
    public string LevelText;
    public string LevelFailedText;
    public string LevelCompleteText;

    public LevelObject(INGREDIENT_TAG winTag, string text, string failed, string complete)
    {
        winIngredientTag = winTag;
        LevelText = text;
        LevelFailedText = failed;
        LevelCompleteText = complete;
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
