using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientPage : MonoBehaviour
{
    public List<Button> buttonList;
    public List<GameObject> pages;

    private IngredientList ingredientList;
    private int activePage;
    private GameObject chest;

    // Start is called before the first frame update
    void Start()
    {
        chest = GameObject.Find("Chest");
        ingredientList = GameObject.Find("Ingredient List Manager").GetComponent<IngredientList>();

        SetPageActive(0);
        for (int i = 0; i < buttonList.Count; i++)
        {
            int page = i;
            buttonList[page].onClick.AddListener(() => SetPageActive(page));
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void HideAllPages()
    {
        for (int i = 0; i < pages.Count; i++)
        {
            pages[i].SetActive(false);
        }
        Debug.Log("Pages Hidden");
    }

    public void SetPageActive(int page)
    {
        activePage = page;
        HideAllPages();
        pages[page].SetActive(true);

        //gets the sprite images set up
        ingredientList.setUISprites(page, transform.Find("Ingredient Slots"));

        Debug.Log("You have clicked button # " + page);
    }

    public void SetPrevPageActive()
    {
        if (activePage == 0) //Active page is last page
            SetPageActive(pages.Count - 1);
        else if (activePage >= 0) //Active page is not last page
            SetPageActive(activePage - 1);
    }

    public void SetNextPageActive()
    {
        if (activePage == pages.Count - 1) //Active page is last page
            SetPageActive(0);
        else if (activePage >= 0) //Active page is not last page
            SetPageActive(activePage + 1);
    }

    //sends the chosen ingredient
    public void ingredientClick(int index)
    {
        //the index in the ingredient list of the ingredient that is clicked
        index = ingredientList.getIndexFromCategory(activePage, index);

        chest.GetComponent<ChestManager>().MakeIngredient(index);
        Debug.Log(index);
    }

    public void CloseEncyclopedia()
    {
        //TODO: Add connection to game manager to close the potion encyclopedia
    }
}
