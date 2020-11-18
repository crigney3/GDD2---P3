using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum State { Title, lvlSelect, Encyclopedia, Ingredients, Brewing, Pause, Fail, Clear};

    private static GameManager _instance;

    public State currentState;
    public State prevState;

    public GameObject background;
    public GameObject encyclopedia;
    public GameObject brewingObjs;
    public GameObject lvlObjs;

    LevelManager lvlManager;

    public static GameManager Instance { get { return _instance; } }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("BrewingBackground");
        encyclopedia = GameObject.Find("EncyclopediaCover");
        brewingObjs = GameObject.Find("BrewingObjects");
        lvlObjs = GameObject.Find("LevelSelectObjects");

        lvlManager = LevelManager.Instance;

        currentState = ChangeGameState(State.lvlSelect);
        prevState = State.Title;


    }

    // Update is called once per frame
    void Update()
    {


        prevState = currentState;
    }

    public State ChangeGameState(State state)
    {
        Debug.Log(state);
        switch (state)
        {
            case State.Title:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                switchScene("TitleScene");
                break;
            case State.lvlSelect:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(true);
                break;
            case State.Encyclopedia:
                encyclopedia.SetActive(true);
                background.SetActive(true);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                break;
            case State.Ingredients:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                break;
            case State.Brewing:
                encyclopedia.SetActive(false);
                background.SetActive(true);
                brewingObjs.SetActive(true);
                lvlObjs.SetActive(false);
                break;
            case State.Pause:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                break;
            case State.Clear:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                break;
            case State.Fail:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                break;
            default:
                break;
        }
        return state;
    }

    void ButtonGameState(string stateName)
    {
        switch (stateName)
        {
            case "Title":
                currentState = ChangeGameState(State.Title);
                break;
            case "lvlSelect":
                currentState = ChangeGameState(State.lvlSelect);
                break;
            case "Encyclopedia":
                currentState = ChangeGameState(State.Encyclopedia);
                break;
            case "Brewing":
                currentState = ChangeGameState(State.Brewing);
                break;
            case "Ingredients":
                currentState = ChangeGameState(State.Ingredients);
                break;
            case "Pause":
                currentState = ChangeGameState(State.Pause);
                break;
            case "Fail":
                currentState = ChangeGameState(State.Fail);
                break;
            case "Clear":
                currentState = ChangeGameState(State.Clear);
                break;
            default:
                break;
        }
    }

    public void switchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
