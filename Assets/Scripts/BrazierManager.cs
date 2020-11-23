using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrazierManager : MonoBehaviour
{
    public Sprite noHover;
    public Sprite hover;
    public bool hovering;

    // Start is called before the first frame update
    void Start()
    {
        hovering = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().sprite = hover;
        hovering = true;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = noHover;
        hovering = false;
    }
}
