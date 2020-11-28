using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCheck : MonoBehaviour
{
    private bool success;
    private GameObject potion;
    private GameObject ingredientList;
    private INGREDIENT_TAG potionType;

    // Start is called before the first frame update
    void Start()
    {
        potion = GameObject.Find("Potion");
        ingredientList = GameObject.Find("IngredientListManager");
        potionType = ingredientList.GetComponent<IngredientList>().mixPotion(potion.GetComponent<PotionManager>().getIngredientIndexes());

        success = LevelManager.Instance.activeLevel.checkWin(potionType);

        if(success)
        {
            GameObject.Find("PotionCheckText").GetComponent<UnityEngine.UI.Text>().text = "Success!";
        }
        else
        {
            GameObject.Find("PotionCheckText").GetComponent<UnityEngine.UI.Text>().text = "Failure...";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPotion()
    {
        potion = GameObject.Find("Potion");
        ingredientList = GameObject.Find("IngredientListManager");
        potionType = ingredientList.GetComponent<IngredientList>().mixPotion(potion.GetComponent<PotionManager>().getIngredientIndexes());

        success = LevelManager.Instance.activeLevel.checkWin(potionType);

        if (success)
        {
            GameObject.Find("PotionCheckText").GetComponent<UnityEngine.UI.Text>().text = "Success!";
        }
        else
        {
            GameObject.Find("PotionCheckText").GetComponent<UnityEngine.UI.Text>().text = "Failure...";
        }
    }
}
