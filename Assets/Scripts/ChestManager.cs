using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public int itemValue;
    public Transform ingredient;
    public Sprite noHover;
    public Sprite hover;
    // Start is called before the first frame update
    void Start()
    {

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

    public void MakeIngredient(int index)
    {
        ingredient = Instantiate(ingredient, Input.mousePosition, Quaternion.identity);
        ingredient.GetComponent<IngredientManager>().ingredientType = index;
    }
}
