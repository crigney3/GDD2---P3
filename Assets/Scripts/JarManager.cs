using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class JarManager : MonoBehaviour
{
    public int itemValue;
    public Transform ingredient;
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
        Instantiate(ingredient, Input.mousePosition, quaternion.identity);
    }
}
