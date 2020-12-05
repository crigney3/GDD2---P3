using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : MonoBehaviour
{
    public bool filled;
    public Sprite noHoverEmpty;
    public Sprite hoverEmpty;
    public Sprite noHoverFull;
    public Sprite hoverFull;

    private GameObject[] ingredients;
    static GameManager gm;
    public GameObject ingredientPage;
    public GameObject potionBtns;

    // Start is called before the first frame update
    void Start()
    {
        filled = false;
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        //Potion isn't clickable so it doesn't need a highlight
        /*if (gm.BlockButtons)
        {
            if (filled && GetComponent<SpriteRenderer>().sprite != noHoverFull)
                GetComponent<SpriteRenderer>().sprite = noHoverFull;
            else if (!filled && GetComponent<SpriteRenderer>().sprite != noHoverEmpty)
                GetComponent<SpriteRenderer>().sprite = noHoverEmpty;
        }*/

        if (filled && gm.currentState == GameManager.State.Brewing && !potionBtns.activeInHierarchy) //Shows buttons when potion has been made
            potionBtns.SetActive(true);
        else if ((!filled || gm.currentState != GameManager.State.Brewing) && potionBtns.activeInHierarchy) //Hides buttons when potion has not been made orr when in a different state
            potionBtns.SetActive(false);
    }
    /*
    private void OnMouseEnter()
    {
        if (!gm.BlockButtons)
        {
            if (filled)
                GetComponent<SpriteRenderer>().sprite = hoverFull;
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
            else
                GetComponent<SpriteRenderer>().sprite = noHoverEmpty;
        }
    }*/

    public void fillPotion(GameObject[] ingredients)
    {
        this.ingredients = ingredients;
        filled = true;
        GetComponent<SpriteRenderer>().sprite = noHoverFull;
        //GameObject.Find("AdvanceButton").SetActive(true); //Enable potion checking button.
        //GameObject.Find("ResetPotion").SetActive(true); //Enable potion dumping button.
    }

    public void emptyPotion()
    {
        if (ingredients == null) return;
        foreach (GameObject ing in ingredients)
        {
            Destroy(ing);
        }
        ingredients = new GameObject[8];
        filled = false;
        ingredientPage.GetComponent<IngredientPage>().Restart();
        GetComponent<SpriteRenderer>().sprite = noHoverEmpty;
    }

    public int[] getIngredientIndexes()
    {

        int[] returner = new int[8];
        for(int a = 0; a < 8; a++)
        {
            Debug.Log("Index: " + a);
            returner[a] = ingredients[a].GetComponent<IngredientManager>().ingredientType;
        }
        return returner;
    }
}
