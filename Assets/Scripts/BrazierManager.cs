using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrazierManager : MonoBehaviour
{
    public Sprite noHover;
    public Sprite hover;
    static GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.BlockButtons && GetComponent<SpriteRenderer>().sprite != noHover)
            GetComponent<SpriteRenderer>().sprite = noHover;
    }

    private void OnMouseEnter()
    {
        if (!gm.BlockButtons)
            GetComponent<SpriteRenderer>().sprite = hover;
    }

    private void OnMouseExit()
    {
        if (!gm.BlockButtons)
            GetComponent<SpriteRenderer>().sprite = noHover;
    }
}
