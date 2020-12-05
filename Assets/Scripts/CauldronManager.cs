using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CauldronManager : MonoBehaviour
{
    public GameObject[] ingredients;
    public Sprite noHoverEmpty;
    public Sprite hoverEmpty;
    public Sprite noHoverMid;
    public Sprite hoverMid;
    public Sprite noHoverFull;
    public Sprite hoverFull;

    private bool filled;
    private GameObject potion;
    static GameManager gm;
    public GameObject audioManager;
    private AudioManager audioScript;
    
    public GameObject cauldronBtns;
    public GameObject fillBtn;
    public GameObject ingredientPage;
    private bool hasIngredients;

    public bool Filled
    {
        get { return filled; }
    }

    // Start is called before the first frame update
    void Start()
    {
        ingredients = new GameObject[8]; //Can only have a max of 8 ingredients.
        filled = false;
        hasIngredients = false;
        potion = GameObject.Find("Potion");
        gm = GameManager.Instance;
        audioScript = audioManager.GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(filled)
        //FillPotion();

        if (gm.BlockButtons)
        {
            if (filled && GetComponent<SpriteRenderer>().sprite != noHoverFull)
                GetComponent<SpriteRenderer>().sprite = noHoverFull;
            else if (!filled && hasIngredients && GetComponent<SpriteRenderer>().sprite != noHoverMid)
                GetComponent<SpriteRenderer>().sprite = noHoverMid;
            else if (!filled && !hasIngredients && GetComponent<SpriteRenderer>().sprite != noHoverEmpty)
                GetComponent<SpriteRenderer>().sprite = noHoverEmpty;
        }

        if (filled && GetComponent<SpriteRenderer>().sprite != noHoverFull && GetComponent<SpriteRenderer>().sprite != hoverFull)
            GetComponent<SpriteRenderer>().sprite = noHoverFull;
        else if (!filled && hasIngredients && GetComponent<SpriteRenderer>().sprite != noHoverFull && GetComponent<SpriteRenderer>().sprite != hoverMid)
            GetComponent<SpriteRenderer>().sprite = noHoverMid;
        else if (!filled && !hasIngredients && GetComponent<SpriteRenderer>().sprite != noHoverEmpty && GetComponent<SpriteRenderer>().sprite != hoverEmpty)
            GetComponent<SpriteRenderer>().sprite = noHoverEmpty;


        if (hasIngredients && gm.currentState == GameManager.State.Brewing && !cauldronBtns.activeInHierarchy) //Shows buttons when ingredients have been added
            cauldronBtns.SetActive(true);
        else if ((!hasIngredients || gm.currentState != GameManager.State.Brewing) && cauldronBtns.activeInHierarchy) //Hides buttons when ingredients have not been added or when in a different state
            cauldronBtns.SetActive(false);

        if (filled && cauldronBtns.activeInHierarchy) //Shows button when cauldron is full
            fillBtn.SetActive(true);
        else if (!filled || !cauldronBtns.activeInHierarchy) //Hides button when cauldron is not full
            fillBtn.SetActive(false);
    }

    public void EmptyCauldron()
    {
        ingredients = new GameObject[8]; //Just refresh the cauldron.
        filled = false;
        hasIngredients = false;
        ingredientPage.GetComponent<IngredientPage>().Restart();
    }

    public void AddIngredient(GameObject ingredient)
    {
        for(int a = 0; a < 8; a++)
        {
            if(ingredients[a] == null) //Add ingredient to first empty slot in list.
            {
                if (!hasIngredients)
                    hasIngredients = true;
                audioScript.PlayFX(9);
                ingredients[a] = ingredient;
                if(a == 7) //Check to see if cauldron is full.
                {
                    filled = true;
                    //FillPotion();
                }
                break; //Exit for loop when ingredient is added.
            }
        }
    }

    public void FillPotion()
    {
        potion.GetComponent<PotionManager>().fillPotion(ingredients);
    }

    private void OnMouseEnter()
    {
        if (!gm.BlockButtons)
        {
            if (filled)
                GetComponent<SpriteRenderer>().sprite = hoverFull;
            else if (hasIngredients)
                GetComponent<SpriteRenderer>().sprite = hoverMid;
            else
                GetComponent<SpriteRenderer>().sprite = hoverEmpty;
        }
    }

    private void OnMouseExit()
    {
        if (!gm.BlockButtons)
        {
            if (filled)
                GetComponent<SpriteRenderer>().sprite = noHoverFull;
            else if (hasIngredients)
                GetComponent<SpriteRenderer>().sprite = noHoverMid;
            else
                GetComponent<SpriteRenderer>().sprite = noHoverEmpty;
        }
    }
}
