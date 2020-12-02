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
        levels.Add(new LevelObject(INGREDIENT_TAG.BasicBland, "Well, there isn't much to do today, and I'm bored. Let's just blend some stuff together, and make a blending potion!"));
        levels.Add(new LevelObject(INGREDIENT_TAG.Potent, "You've got a werewolf on your tail, and you want my advice?? Fine, make, uhhh, something to disrupt its senses! Then it can't track you."));
        levels.Add(new LevelObject(INGREDIENT_TAG.RemediesRough, "You'll be going up against a Naga this mission. They're like a werewolf, but instead of a wolf they turn into a snake. Make sure you don't get poisoned, I don't want to be left in this basement forever."));
        levels.Add(new LevelObject(INGREDIENT_TAG.Clear, "I can't really think of any way to beat a demon, so you might want to have a good way to escape instead of fighting this time."));
        levels.Add(new LevelObject(INGREDIENT_TAG.FloatLight, "I'll admit you don't have the best shot against a vampire, but hey, the ability to fly certainly couldn't hurt!"));

        activeLevel = levels[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
