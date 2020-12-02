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
    public GameObject chest;

    private bool[] usedIngredients;

    // Start is called before the first frame update
    void Start()
    {
        usedIngredients = new bool[8]; //init bool array to false, since nothing has been used at the start
        ingredientList = GameObject.Find("Ingredient List Manager").GetComponent<IngredientList>();

        SetPageActive(0);
        for (int i = 0; i < buttonList.Count; i++)
        {
            int page = i;
            buttonList[page].onClick.AddListener(() => SetPageActive(page));
        }
        
    }

    public void Reload()
    {
        SetPageActive(0);
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

        GameObject pageObj = pages[page];
        Text text = pageObj.GetComponentInChildren<Text>();
        Transform ingredientSlots = transform.Find("Ingredient Slots");

        Button[] buttons = ingredientSlots.GetComponentsInChildren<Button>();

        //sets the buttons that can be clicked
        if (usedIngredients[page])
        {
            //has been used already
            text.text = "You have already used an ingredient of this type.";
            text.fontStyle = FontStyle.Bold;
            foreach(Button button in buttons)
            {
                button.interactable = false;
                button.gameObject.GetComponent<Image>().color = button.colors.disabledColor;
            }
        }
        else
        {
            //hasn't been used yet
            text.text = ((INGREDIENT_CATEGORY)page).ToString();
            text.fontStyle = FontStyle.Normal;
            foreach (Button button in buttons)
            {
                button.interactable = true;
                button.gameObject.GetComponent<Image>().color = button.colors.normalColor;
            }
        }

        pageObj.SetActive(true);

        //gets the sprite images set up
        ingredientList.setUISprites(page, ingredientSlots);

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

        //set bool to true now that you used that type of ingredient
        usedIngredients[ingredientList.getCategoryInt(index)] = true;

        chest.GetComponent<ChestManager>().MakeIngredient(index, this);
        GameManager.Instance.currentState = GameManager.Instance.ChangeGameState(GameManager.State.Brewing);
    }

    public void removeIngredient(int index)
    {
        //set bool to true now that you used that type of ingredient
        usedIngredients[ingredientList.getCategoryInt(index)] = false;
    }

    public void CloseEncyclopedia()
    {
        //TODO: Add connection to game manager to close the potion encyclopedia
        GameManager.Instance.currentState = GameManager.Instance.ChangeGameState(GameManager.State.Brewing);
    }
}
