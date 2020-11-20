using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobManager : MonoBehaviour
{
    public Sprite noHover;
    public Sprite hover;
    public bool overBob;

    static GameManager gm = GameManager.Instance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Open encyclopedia here.
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().sprite = hover;
        overBob = true;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = noHover;
        overBob = false;
    }

    private void OnMouseDown()
    {
        if (overBob)
        {
            GameManager.Instance.ButtonGameState("Encyclopedia");
        }
    }
}
