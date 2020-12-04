using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public int itemValue;
    public Transform ingredientT;
    public Transform ingredient;
    public Sprite noHover;
    public Sprite hover;
    private GameObject ingStorage;
    static GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        ingStorage = GameObject.Find("IngredientsStorage");
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.BlockButtons && GetComponent<SpriteRenderer>().sprite != noHover)
            GetComponent<SpriteRenderer>().sprite = noHover;
    }

    private void OnMouseDown()
    {
        //Open ingredient screen here.
        if (!gm.BlockButtons)
            gm.ButtonGameState("Ingredients");
        //ingredient = Instantiate(ingredient, Input.mousePosition, Quaternion.identity);
        //ingredient.GetComponent<IngredientManager>().ingredientType = itemValue;
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

    public void MakeIngredient(int index, IngredientPage ingredientPage, int ingredientNum)
    {
        ingredient = Instantiate(ingredientT, Input.mousePosition, Quaternion.identity);
        IngredientManager im = ingredient.GetComponent<IngredientManager>();
        im.ingredientType = index;
        im.ingredientPage = ingredientPage;
        ingredient.transform.parent = ingStorage.transform;

        SpriteRenderer rend = ingredient.GetComponent<SpriteRenderer>();
        rend.sortingOrder = ingredientNum + 1;
    }
}
