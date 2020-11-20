using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public List<GameObject> cyclableObjs;
    public void Start()
    {
        foreach (GameObject obj in cyclableObjs) //Resets each cyclable object
        {
            HideAllChildren(obj);
            ShowChildAtIndex(obj, 0);
        }
    }

    //Changes game to the Title Screen
    public void GoToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    //Changes game to the Controls Screen
    public void GoToControls()
    {
        SceneManager.LoadScene("ControlsScene");
    }

    //Changes game to the Credits Screen
    public void GoToCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    //Changes game to the Bedroom Screen
    public void GoToLevelSelect()
    {
        SceneManager.LoadScene("CoreyScene");
    }

    //Pauses the game
    public void Pause()
    {
        //To Do: Add connections to pausing in level controller
    }

    //Closes the game
    public void ExitGame()
    {
        Application.Quit();
    }

    //Hides all children of the passed GameObject
    private void HideAllChildren(GameObject obj)
    {
        foreach (Transform child in obj.transform) //Hides all children of object
        {
            child.gameObject.SetActive(false); //Hides child
        }
    }

    //Shows the child at the specificed index of the passed GameObject
    private void ShowChildAtIndex(GameObject obj, int index)
    {
        List<GameObject> children = new List<GameObject>();

        foreach (Transform child in obj.transform) //Adds all children of object to the list
        {
            children.Add(child.gameObject); //Adds child to list
        }

        if (index >= 0 && index < children.Count)
            children[index].SetActive(true);
    }

    //Returns the index of the first active child of the passed object
    private int GetFirstActiveChild(GameObject obj)
    {
        int currentChild = 0;
        int activeChild = -1;
        foreach (Transform transform in obj.transform) //Adds all children to list
        {
            if (transform.gameObject.activeInHierarchy) //Sets the first active child
            {
                activeChild = currentChild;
                break;
            }
            currentChild++; //Update current child
        }
        return activeChild; //Returns index of first active child
    }

    //Returns the index of the first active child of the passed object
    private int GetLastActiveChild(GameObject obj)
    {
        int currentChild = 0;
        int activeChild = -1;
        foreach (Transform transform in obj.transform) //Adds all children to list
        {
            if (transform.gameObject.activeInHierarchy) //Sets the first active child
            {
                activeChild = currentChild;
            }
            currentChild++; //Update current child
        }
        return activeChild; //Returns index of first active child
    }

    //Shows the previous child of the passed cyclable object
    public void ShowPreviousChild(GameObject obj)
    {
        int activeChild = GetFirstActiveChild(obj); //Get current active child

        if (activeChild >= 0 && activeChild < obj.transform.childCount) 
        {
            HideAllChildren(obj); //Hide all children

            if (activeChild == 0) //Active child is first child
                ShowChildAtIndex(obj, obj.transform.childCount - 1);
            else //Active child is not first child
                ShowChildAtIndex(obj, activeChild - 1);
        }
    }

    //Shows the next child of the passed cyclable object
    public void ShowNextChild(GameObject obj)
    {
        int activeChild = GetLastActiveChild(obj); //Get current active child

        if (activeChild >= 0 && activeChild < obj.transform.childCount)
        {
            HideAllChildren(obj); //Hide all children

            if (activeChild == obj.transform.childCount - 1) //Active child is last child
                ShowChildAtIndex(obj, 0);
            else //Active child is not last child
                ShowChildAtIndex(obj, activeChild + 1);
        }
    }
}

