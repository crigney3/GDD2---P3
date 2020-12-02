using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCheck : MonoBehaviour
{
    private bool success;
    public GameObject potion;
    public GameObject ingredientList;
    private INGREDIENT_TAG potionType;
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        potion = GameObject.Find("Potion");
        ingredientList = GameObject.Find("Ingredient List Manager");
        potionType = ingredientList.GetComponent<IngredientList>().mixPotion(potion.GetComponent<PotionManager>().getIngredientIndexes());

        //potion = GameObject.Find("Potion");
        //ingredientList = GameObject.Find("IngredientListManager");
        /*potionType = ingredientList.GetComponent<IngredientList>().mixPotion(potion.GetComponent<PotionManager>().getIngredientIndexes());


        success = LevelManager.Instance.activeLevel.checkWin(potionType);

        if(success)
        {
            GameObject.Find("PotionCheckText").GetComponent<UnityEngine.UI.Text>().text = "Mission Cleared";
        }
        else
        {
            GameObject.Find("PotionCheckText").GetComponent<UnityEngine.UI.Text>().text = "Mission Failed";
        }*/
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPotion()
    {
        GameManager.Instance.ChangeGameState(GameManager.State.PotionCheck);

        potionType = ingredientList.GetComponent<IngredientList>().mixPotion(potion.GetComponent<PotionManager>().getIngredientIndexes());
        
        success = LevelManager.Instance.activeLevel.checkWin(potionType);

        if (success)
        {
            //GameObject.Find("PotionCheckText").GetComponent<UnityEngine.UI.Text>().text = "Mission Cleared";
            gm.ButtonGameState("Clear");
        }
        else
        {
            //GameObject.Find("PotionCheckText").GetComponent<UnityEngine.UI.Text>().text = " Mission Failed";
            gm.ButtonGameState("Fail");
        }
    }
}
