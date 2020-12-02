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
    // Start is called before the first frame update
    void Start()
    {
        ingStorage = GameObject.Find("IngredientsStorage");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        //Open ingredient screen here.
        GameManager.Instance.currentState = GameManager.Instance.ChangeGameState(GameManager.State.Ingredients);
        //ingredient = Instantiate(ingredient, Input.mousePosition, Quaternion.identity);
        //ingredient.GetComponent<IngredientManager>().ingredientType = itemValue;
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().sprite = hover;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = noHover;
    }

    public void MakeIngredient(int index, IngredientPage ingredientPage)
    {
        ingredient = Instantiate(ingredientT, Input.mousePosition, Quaternion.identity);
        IngredientManager im = ingredient.GetComponent<IngredientManager>();
        im.ingredientType = index;
        im.ingredientPage = ingredientPage;
        ingredient.transform.parent = ingStorage.transform;
    }
}
