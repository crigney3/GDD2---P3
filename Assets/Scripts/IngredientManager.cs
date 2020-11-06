using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    public int ingredientType;
    public bool carried = true;
    // Start is called before the first frame update
    void Start()
    {
        //TODO: Once there is art for different ingredients, change the sprite here.
    }

    // Update is called once per frame
    void Update()
    {
        if (carried)
        {
            transform.position = Input.mousePosition;
        }
    }

    public void OnMouseDown()
    {
        if (carried)
        {
            carried = false;
        }
    }
}
