using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    public int ingredientType;
    public bool carried = true;

    private GameObject ingredientList;
    private GameObject cauldron;
    private CauldronManager cauldronScript;
    private GameObject brazier;
    private AudioManager audioManager;
    private Vector3 mousePos;


    public IngredientPage ingredientPage;
    static GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        ingredientList = GameObject.Find("Ingredient List Manager"); //So, ALWAYS NAME THE INGREDIENT LIST MANAGER "IngredientListManager" FOR THIS TO WORK!
        cauldron = GameObject.Find("Cauldron"); //So, ALWAYS NAME THE CAULDRON "Cauldron" FOR THIS TO WORK!
        cauldronScript = cauldron.GetComponent<CauldronManager>();
        brazier = GameObject.Find("Brazier"); //So, ALWAYS NAME THE BRAZIER "Brazier" FOR THIS TO WORK!
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        gm = GameManager.Instance;
        //Set sprite.
        SpriteRenderer spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.sprite = ingredientList.GetComponent<IngredientList>().getSprite(ingredientType);
        spriteRend.sortingOrder = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (carried)
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            transform.position = new Vector3(mousePos.x, mousePos.y, 650.0f);

            if (Input.GetMouseButtonDown(0))
            {
                checkCollision();
            }
        }
    }

    public void checkCollision()
    {
        if (cauldron.GetComponent<BoxCollider2D>().OverlapPoint(mousePos) && !cauldronScript.Filled && !gm.BlockButtons) //Put ingredient in cauldron.
        {
            carried = false;
            cauldron.GetComponent<CauldronManager>().AddIngredient(gameObject);
            GetComponent<SpriteRenderer>().enabled = false; //Hides Ingredient
        }
        else if(brazier.GetComponent<BoxCollider2D>().OverlapPoint(mousePos) && !gm.BlockButtons) //Destroy object.
        {
            audioManager.PlayFX(4);
            carried = false;
            ingredientPage.removeIngredient(ingredientType);
            Destroy(gameObject);
        }
    }
}
