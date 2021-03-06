﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncyclopediaScript : MonoBehaviour
{
    public List<Button> buttonList;
    public List<GameObject> pages;

    // Start is called before the first frame update
    void Start()
    {
        SetPageActive(0);
        for(int i = 0; i < buttonList.Count; i++)
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
        for(int i = 0; i < pages.Count; i++)
        {
            pages[i].SetActive(false);
        }
        Debug.Log("Pages Hidden");
    }

    public void SetPageActive(int page)
    {
        HideAllPages();
        pages[page].SetActive(true);
        Debug.Log("You have clicked button # " + page);
    }

    public void SetPrevPageActive()
    {
        int activePage = -1;
        for (int i = 0; i < pages.Count; i++)
        {
            if (pages[i].activeInHierarchy)
            {
                activePage = i;
                break;
            }
        }
    
        if (activePage == 0) //Active page is last page
            SetPageActive(pages.Count - 1);
        else if (activePage >= 0) //Active page is not last page
            SetPageActive(activePage - 1);
    }
    
    public void SetNextPageActive()
    {
        int activePage = -1;
        for (int i = 0; i < pages.Count; i++)
        {
            if (pages[i].activeInHierarchy)
                activePage = i;
        }
    
        if (activePage == pages.Count - 1) //Active page is last page
            SetPageActive(0);
        else if (activePage >= 0) //Active page is not last page
            SetPageActive(activePage + 1);
    }

    public void CloseEncyclopedia()
    {
        //TODO: Add connection to game manager to close the potion encyclopedia
    }
}
