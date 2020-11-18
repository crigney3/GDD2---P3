using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobManager : MonoBehaviour
{
    public Sprite noHover;
    public Sprite hover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().sprite = hover;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = noHover;
    }
}
