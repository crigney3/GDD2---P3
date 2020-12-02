using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public GameObject dialogueBox;
    public GameObject lvlObjs;
    public GameObject pauseObjs;
    public GameObject ingredientsObjs;
    public GameObject clearObjs;
    public GameObject failObjs;

    private Button pauseBtn;
    private bool blockButtons;

    LevelManager lvlManager;
    public AudioManager audioManager;

    public static GameManager Instance { get { return _instance; } }
    public bool BlockButtons
    {
        get { return blockButtons; }
    }

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
        background = GameObject.Find("Background");
        encyclopedia = GameObject.Find("EncyclopediaCover");
        brewingObjs = GameObject.Find("BrewingObjects");
        dialogueBox = GameObject.Find("Dialogue Box");
        lvlObjs = GameObject.Find("LevelSelectObjects");
        pauseObjs = GameObject.Find("PauseObjects");
        ingredientsObjs = GameObject.Find("Ingredients");
        //gameOverObjs = GameObject.Find("GameOverObjects");
        pauseBtn = GameObject.Find("PauseButton").GetComponent<Button>();
        clearObjs = GameObject.Find("ClearScreen");
        failObjs = GameObject.Find("FailScreen");

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
                //background.SetActive(false);
                brewingObjs.SetActive(false);
                dialogueBox.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                clearObjs.SetActive(false);
                failObjs.SetActive(false);
                switchScene("TitleScene");
                blockButtons = true;
                break;
            case State.lvlSelect:
                encyclopedia.SetActive(false);
                //background.SetActive(false);
                brewingObjs.SetActive(false);
                dialogueBox.SetActive(false);
                lvlObjs.SetActive(true);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                clearObjs.SetActive(false);
                failObjs.SetActive(false);
                blockButtons = true;
                audioManager.SetBGMVolume(0.06f);
                audioManager.PlayBGM(1);
                break;
            case State.Encyclopedia:
                encyclopedia.SetActive(true);
                //background.SetActive(true);
                brewingObjs.SetActive(true);
                dialogueBox.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                clearObjs.SetActive(false);
                failObjs.SetActive(false);
                blockButtons = true;
                pauseBtn.interactable = true;
                audioManager.PlayFX(5);
                break;
            case State.Ingredients:
                encyclopedia.SetActive(false);
                //background.SetActive(true);
                brewingObjs.SetActive(false);
                dialogueBox.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.GetComponentInChildren<IngredientPage>().Reload();
                ingredientsObjs.SetActive(true);
                clearObjs.SetActive(false);
                failObjs.SetActive(false);
                blockButtons = true;
                pauseBtn.interactable = true;
                audioManager.PlayFX(7);
                break;
            case State.Brewing:
                encyclopedia.SetActive(false);
                //background.SetActive(true);
                brewingObjs.SetActive(true);
                dialogueBox.SetActive(true);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                clearObjs.SetActive(false);
                failObjs.SetActive(false);
                blockButtons = false;
                pauseBtn.interactable = true;
                if (prevState == State.lvlSelect)
                {
                    audioManager.SetBGMVolume(0.1f);
                    audioManager.PlayBGM(0);
                }
                break;
            case State.Pause:
                encyclopedia.SetActive(false);
                //background.SetActive(false);
                brewingObjs.SetActive(true);
                dialogueBox.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(true);
                ingredientsObjs.SetActive(false);
                clearObjs.SetActive(false);
                failObjs.SetActive(false);
                blockButtons = true;
                pauseBtn.interactable = false;
                prePauseState = currentState;
                break;
            case State.PotionCheck:
                encyclopedia.SetActive(false);
                background.SetActive(false);
                brewingObjs.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                //gameOverObjs.SetActive(true);
                break;
            case State.Clear:
                encyclopedia.SetActive(false);
                //background.SetActive(false);
                brewingObjs.SetActive(false);
                dialogueBox.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                clearObjs.SetActive(true);
                failObjs.SetActive(false);
                blockButtons = true;
                pauseBtn.interactable = false;
                audioManager.SetBGMVolume(0.1f);
                audioManager.PlayBGM(2);
                break;
            case State.Fail:
                encyclopedia.SetActive(false);
                //background.SetActive(false);
                brewingObjs.SetActive(false);
                dialogueBox.SetActive(false);
                lvlObjs.SetActive(false);
                pauseObjs.SetActive(false);
                ingredientsObjs.SetActive(false);
                clearObjs.SetActive(false);
                failObjs.SetActive(true);
                blockButtons = true;
                pauseBtn.interactable = false;
                audioManager.SetBGMVolume(0.1f);
                audioManager.PlayBGM(3);
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
        GameObject.Find("DialogueBoxText").GetComponent<Text>().text = lvlManager.activeLevel.LevelText;
        
    }

    public void switchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
