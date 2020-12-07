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
        levels.Add(new LevelObject(INGREDIENT_TAG.BasicBland,
            "Well, there isn't much to do today, and I'm bored. Let's just blend some stuff together, and make a blending potion!",
            "You messed it up, huh? Don't worry, the only thing you lost was the cost of the ingredients. Which was your rent money for this month!",
            "Nice job out there! I mean, there was nothing to face, but that potion looks great on your shelf."));
        levels.Add(new LevelObject(INGREDIENT_TAG.Potent,
            "You've got a werewolf on your tail, and you want my advice?? Fine, make, uhhh, something to disrupt its senses! Then it can't track you.",
            "Hey, you're back! ...And you're a werewolf now. Potion didn't work, huh?",
            "Wow, you smell like a wet dog. But you aren't one, so looks like my advice was perfect as ever!"));
        levels.Add(new LevelObject(INGREDIENT_TAG.RemediesRough,
            "You'll be going up against a Naga this mission. They're like a werewolf, but instead of a wolf they turn into a snake. Make sure you don't get poisoned, I don't want to be left in this basement forever.",
            "I'm gonna assume that the black veins spreading throughout your body mean you made the wrong potion. You mind freeing me before you die?",
            "Wow, Naga heads made really good decorations!"));
        levels.Add(new LevelObject(INGREDIENT_TAG.Travel,
            "I can't really think of any way to beat a demon, so you might want to have a good way to escape instead of fighting this time.",
            "Dresden? Hellooooo, anyone there? Crap, if he's dead I'm stuck here forever.",
            "Hey, looks like you got away! Please tell me it didn't track you here. I definitely can't fight a demon."));
        levels.Add(new LevelObject(INGREDIENT_TAG.FloatLight,
            "I'll admit you don't have the best shot against a vampire, but hey, the ability to fly certainly couldn't hurt!",
            "So you're a bloodsucker now, huh? Well you can't have any of mine. Because I don't have any.",
            "You know, I'm kinda surprised that helped. Don't give me that look, my knowledge of how to make potions doesn't mean I'm a genius in their application."));

        activeLevel = levels[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
