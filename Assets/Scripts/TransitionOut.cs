using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TransitionOut : MonoBehaviour
{
    public GameObject TransitionObject;
    public AudioSource Music;
    bool transition = false;
    public string loadScene;
    public float delta;
    float fade;
    float volume;

    // Start is called before the first frame update
    void Start()
    {
        volume = Music.volume;
        //black.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transition == true)
        {
            fade = fade + delta * Time.deltaTime;
            Music.volume = volume - fade;
            TransitionObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, fade);
            
        }

        if (fade >= 1.2f)
        {
            transition = false;
            SceneManager.LoadScene(sceneName: loadScene);
            
        }
    }

    public void begin()
    {

        TransitionObject.SetActive(true);
        transition = true;
    }
}
