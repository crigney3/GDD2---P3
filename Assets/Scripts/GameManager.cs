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
        currentState = ChangeGameState(State.lvlSelect);
        prevState = ChangeGameState(State.Title);
    }

    // Update is called once per frame
    void Update()
    {


        prevState = currentState;
    }

    State ChangeGameState(State state)
    {
        switch (state)
        {
            case State.Title:
                switchScene("TitleScene");
                break;
            case State.lvlSelect:

                break;
            case State.Encyclopedia:

                break;
            case State.Ingredients:

                break;
            case State.Brewing:

                break;
            case State.Pause:

                break;
            case State.Clear:

                break;
            case State.Fail:

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

    void switchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
