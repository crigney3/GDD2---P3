using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private int startingBGMIndex; //BGM to play at Start
    [SerializeField] private List<AudioClip> bgmClips; //List of Background Music
    [SerializeField] private float bgmVolume; //Volume of Background Music
    [SerializeField] private List<AudioClip> fxClips; //List of Effects
    [SerializeField] private float fxVolume; //Volume of Effects

    private AudioSource bgmSource; //Plays Background Musics
    private AudioSource fxSource; //Plays Effects
    
    private string startingScene; //Name of the scene the Audio Manager is from
    private bool changedScenes; //Whether the scene has changed since this was created

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //Prevents Audio Manager from immediately being destroyed when changing scenes
    }

    // Start is called before the first frame update
    void Start()
    {
        startingScene = SceneManager.GetActiveScene().name; 

        bgmSource = transform.Find("BGM").GetComponent<AudioSource>();
        fxSource = transform.Find("FX").GetComponent<AudioSource>();
        
        if (bgmSource != null) //Initialize BGM
        {
            bgmSource.loop = true;
            SetBGMVolume(bgmVolume);
            PlayBGM(startingBGMIndex);
        }
        
        if (fxSource != null) //Initialize FX
            SetFXVolume(fxVolume);
    }

    //Ensures volume value is within 0-1 range
    private float SanitizeVolume(float volume)
    {
        if (volume < 0)
            return 0;
        else if (volume > 1)
            return 1;
        else
            return volume;
    }

    //Sets the volume of the Background Music
    public void SetBGMVolume (float volume)
    {
        bgmSource.volume = SanitizeVolume(volume);
    }

    //Halves the BGM Volume (Used for Pausing)
    public void HalveBGMVolume()
    {
        bgmSource.volume *= 0.5f;
    }

    //Doubles the BGM Volume (Used for Pausing)
    public void DoubleBGMVolume()
    {
        bgmSource.volume *= 2.0f;
    }

    //Plays Background Music
    public void PlayBGM(int index)
    {
        if (bgmSource != null && index >= 0 && index < bgmClips.Count)
        {
            bgmSource.clip = bgmClips[index];
            bgmSource.Play();
        }
    }
    //Stops any background music
    public void stopBGM()
    {
        if (bgmSource != null && bgmSource.isPlaying)
            bgmSource.Stop();
    }

    //Sets the volume of the Effects
    public void SetFXVolume(float volume)
    {
        fxSource.volume = SanitizeVolume(volume);
    }

    //Plays Effect Clips
    public void PlayFX(int index) 
    {
        if (fxSource != null && index >= 0 && index < fxClips.Count)
            fxSource.PlayOneShot(fxClips[index]);
    }

    //Stops any effects from playing
    public void stopFX()
    {
        if (fxSource != null && fxSource.isPlaying)
            fxSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (bgmSource != null)
        {
            if (bgmSource.volume != SanitizeVolume(bgmVolume)) //Update BGM Volume
                SetBGMVolume(bgmVolume);
        }
        if (fxSource != null)
        {
            if (fxSource.volume != SanitizeVolume(fxVolume)) //Update FX Volume
                SetFXVolume(fxVolume);
        }*/
        if (startingScene != SceneManager.GetActiveScene().name && !changedScenes) //Marks that the scene has changed
            changedScenes = true;


        //Stops background music when changing scenes
        if (changedScenes && bgmSource.isPlaying)
            stopBGM();

        //Waits until effects have finished to delete audio manager after changing scenes
        if (changedScenes && !fxSource.isPlaying) 
            Destroy(gameObject);
    }
}
