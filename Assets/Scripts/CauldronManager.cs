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
    private GameObject potion;
    static GameManager gm;
    public GameObject audioManager;
    private AudioManager audioScript;
    public GameObject potionBtns;
    public GameObject ingredientPage;

    public bool Filled
    {
        get { return filled; }
    }

    // Start is called before the first frame update
    void Start()
    {
        ingredients = new GameObject[8]; //Can only have a max of 8 ingredients.
        filled = false;
        potion = GameObject.Find("Potion");
        gm = GameManager.Instance;
        audioScript = audioManager.GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(filled)
            //FillPotion();

        if (gm.BlockButtons && GetComponent<SpriteRenderer>().sprite != noHover)
            GetComponent<SpriteRenderer>().sprite = noHover;

        if (filled && !potionBtns.activeInHierarchy) //Shows buttons when potion has been made
            potionBtns.SetActive(true);
        else if (!filled && potionBtns.activeInHierarchy) //Hides buttons when potion has not been made
            potionBtns.SetActive(false);

        if (gm.currentState == GameManager.State.Clear || gm.currentState == GameManager.State.Fail) //Empties the cauldron after finishing the level
            EmptyCauldron();
    }

    public void EmptyCauldron()
    {
        ingredients = new GameObject[8]; //Just refresh the cauldron.
        filled = false;
        ingredientPage.GetComponent<IngredientPage>().Restart();
    }

    public void AddIngredient(GameObject ingredient)
    {
        for(int a = 0; a < 8; a++)
        {
            if(ingredients[a] == null) //Add ingredient to first empty slot in list.
            {
                audioScript.PlayFX(9);
                ingredients[a] = ingredient;
                if(a == 7) //Check to see if cauldron is full.
                {
                    filled = true;
                    FillPotion();
                }
                break; //Exit for loop when ingredient is added.
            }
        }
    }

    private void FillPotion()
    {
        audioScript.PlayFX(11);
        potion.GetComponent<PotionManager>().fillPotion(ingredients);
    }

    private void OnMouseEnter()
    {
        if (!gm.BlockButtons)
            GetComponent<SpriteRenderer>().sprite = hover;
    }

    private void OnMouseExit()
    {
        if (!gm.BlockButtons)
            GetComponent<SpriteRenderer>().sprite = noHover;
    }
}
