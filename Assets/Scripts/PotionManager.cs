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
    // Start is called before the first frame update
    void Start()
    {
        filled = false;
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.BlockButtons)
        {
            if (filled && GetComponent<SpriteRenderer>().sprite != noHoverFull)
                GetComponent<SpriteRenderer>().sprite = noHoverFull;
            else if (!filled && GetComponent<SpriteRenderer>().sprite != noHoverEmpty)
                GetComponent<SpriteRenderer>().sprite = noHoverEmpty;
        }
    }
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

    public void fillPotion(GameObject[] ingredients)
    {
        this.ingredients = ingredients;
        filled = true;
        GetComponent<SpriteRenderer>().sprite = noHoverFull;
        //GameObject.Find("AdvanceButton").SetActive(true); //Enable potion checking button.
        //GameObject.Find("ResetPotion").SetActive(true); //Enable potion dumping button.
    }

    public int[] getIngredientIndexes()
    {
        int[] returner = new int[8];
        for(int a = 0; a < 8; a++)
        {
            returner[a] = ingredients[a].GetComponent<IngredientManager>().ingredientType;
        }
        return returner;
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
    }
}
