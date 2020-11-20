using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    private static LevelManager _instance;

    public LevelObject activeLevel;

    public static LevelManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public List<LevelObject> levels;

    // Start is called before the first frame update
    void Start()
    {
        levels = new List<LevelObject>();
        levels.Add(new LevelObject(INGREDIENT_TAG.BasicBland));
        levels.Add(new LevelObject(INGREDIENT_TAG.Clear));
        levels.Add(new LevelObject(INGREDIENT_TAG.DarkHoly));
        levels.Add(new LevelObject(INGREDIENT_TAG.FloatLight));
        levels.Add(new LevelObject(INGREDIENT_TAG.Morning));

        activeLevel = levels[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
