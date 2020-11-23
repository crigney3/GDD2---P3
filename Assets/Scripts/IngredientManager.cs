using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    public int ingredientType;
    public bool carried = true;

    private GameObject ingredientList;
    private GameObject cauldron;
    private GameObject brazier;
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        ingredientList = GameObject.Find("IngredientListManager"); //So, ALWAYS NAME THE INGREDIENT LIST MANAGER "IngredientListManager" FOR THIS TO WORK!
        cauldron = GameObject.Find("Cauldron"); //So, ALWAYS NAME THE CAULDRON "Cauldron" FOR THIS TO WORK!
        brazier = GameObject.Find("Brazier"); //So, ALWAYS NAME THE BRAZIER "brazier" FOR THIS TO WORK!
        //Set sprite.
        GetComponent<SpriteRenderer>().sprite = ingredientList.GetComponent<IngredientList>().getSprite(ingredientType);
    }

    // Update is called once per frame
    void Update()
    {
        if (carried)
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            transform.position = new Vector3(mousePos.x, mousePos.y, -2.0f);
        }
    }

    public void OnMouseDown()
    {
        if (carried)
        {
            if(cauldron.GetComponent<BoxCollider2D>().OverlapPoint(mousePos)) //Put ingredient in cauldron.
            {
                carried = false;
                cauldron.GetComponent<CauldronManager>().AddIngredient(gameObject);
            }
            else if(brazier.GetComponent<BoxCollider2D>().OverlapPoint(mousePos)) //Destroy object.
            {
                carried = false;
                Destroy(gameObject);
            }
        }
    }
}
