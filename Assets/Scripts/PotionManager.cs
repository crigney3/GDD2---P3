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
    // Start is called before the first frame update
    void Start()
    {
        filled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        if(filled)
        {
            GetComponent<SpriteRenderer>().sprite = hoverFull;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = hoverEmpty;
        }
        
    }

    public void fillPotion(GameObject[] ingredients)
    {
        this.ingredients = ingredients;
        filled = true;
        GameObject.Find("AdvanceButton").SetActive(true); //Enable potion checking button.
    }

    private void OnMouseExit()
    {
        if (filled)
        {
            GetComponent<SpriteRenderer>().sprite = noHoverFull;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = noHoverEmpty;
        }
    }
}
