using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public GameObject Music;
    private AudioSource IMusic;
    public Slider MusicSlider;

    void Start()
    {
        // cited https://docs.unity3d.com/ScriptReference/AudioSource-volume.html
        //Initiate the Slider value to half way

        //Fetch the AudioSource from the GameObject
        IMusic = Music.GetComponent<AudioSource>();
        MusicSlider.value = IMusic.volume;
        //Play the AudioClip attached to the AudioSource on startup


    }

    private void OnGUI()
    {
        IMusic.volume = MusicSlider.value;
    }
}
