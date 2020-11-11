using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    public int ingredientType;
    public bool carried = true;

    private GameObject cauldron;
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        cauldron = GameObject.Find("Cauldron"); //So, ALWAYS NAME THE CAULDRON "Cauldron" FOR THIS TO WORK!
        //TODO: Once there is art for different ingredients, change the sprite here.
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
            carried = false;
            if(cauldron.GetComponent<BoxCollider2D>().OverlapPoint(mousePos))
            {
                cauldron.GetComponent<CauldronManager>().AddIngredient(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
