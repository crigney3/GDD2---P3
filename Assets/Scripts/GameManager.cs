using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum State { Title, lvlSelect, Pause, Brewing, PotionCheck, Ingredients, Encyclopedia, Clear, Fail};

    private static GameManager _instance;

    public State currentState;
    public State prevState;
    public State prePauseState;

    public GameObject background;
    public GameObject encyclopedia;
    public GameObject brewingObjs;
    public GameObject lvlObjs;
    public GameObject pauseObjs;
    public GameObject ingredientsObjs;
    public GameObject gameOverObjs;

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
        pauseObjs = GameObject.Find("PauseObjects");
        ingredientsObjs = GameObject.Find("Ingredients");
        gameOverObjs = GameObject.Find("GameOverObjects");

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
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                gameOverObjs.SetActive(false);
                switchScene("TitleScene");
                break;
            case State.lvlSelect:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(true);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                gameOverObjs.SetActive(false);
                break;
            case State.Encyclopedia:
                encyclopedia.SetActive(true);
                background.SetActive(true);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                gameOverObjs.SetActive(false);
                break;
            case State.Ingredients:
                encyclopedia.SetActive(false);
                background.SetActive(true);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(true);
                gameOverObjs.SetActive(false);
                break;
            case State.Brewing:
                encyclopedia.SetActive(false);
                background.SetActive(true);
                brewingObjs.SetActive(true);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                gameOverObjs.SetActive(false);
                break;
            case State.Pause:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(true);
                ingredientsObjs.SetActive(false);
                gameOverObjs.SetActive(false);

                prePauseState = currentState;
                break;
            case State.PotionCheck:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                gameOverObjs.SetActive(true);
                break;
            case State.Clear:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                gameOverObjs.SetActive(true);
                break;
            case State.Fail:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                gameOverObjs.SetActive(true);
                break;
            default:
                break;
        }
        return state;
    }

    public void ButtonGameState(string stateName)
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

    public void ResumeButton()
    {
        currentState = ChangeGameState(prePauseState);
    }

    public void LevelButton(int levelID)
    {
        lvlManager.activeLevel = lvlManager.levels[levelID];
        currentState = ChangeGameState(State.Brewing);
    }

    public void switchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
