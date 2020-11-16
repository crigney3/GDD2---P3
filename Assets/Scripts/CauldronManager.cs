using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CauldronManager : MonoBehaviour
{
    public GameObject[] ingredients;
    public Sprite noHover;
    public Sprite hover;

    private bool filled;
    // Start is called before the first frame update
    void Start()
    {
        ingredients = new GameObject[8]; //Can only have a max of 8 ingredients.
        filled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(filled)
        {
            AskToMix();
        }
    }

    private void EmptyCauldron()
    {
        ingredients = new GameObject[8]; //Just refresh the cauldron.
    }

    public void AddIngredient(GameObject ingredient)
    {
        for(int a = 0; a < 8; a++)
        {
            if(ingredients[a] == null) //Add ingredient to first empty slot in list.
            {
                ingredients[a] = ingredient;
                if(a == 7) //Check to see if cauldron is full.
                {
                    filled = true;
                }
            }
        }
    }

    private void AskToMix()
    {
        //Popup a screen asking if the player is ready to mix their potion. If it's not too hard, show what ingredients they have in the cauldron.
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().sprite = hover;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = noHover;
    }
}
