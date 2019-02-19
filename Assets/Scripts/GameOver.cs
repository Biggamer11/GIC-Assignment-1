using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject TransitionObject;
    public GameObject UIGameOver;
    public GameObject UIScore;
    public Text Score;
    public AudioSource Music;
    bool transition = false;
    public string loadScene;
    public float delta;
    float fade;

    // Start is called before the first frame update
    void Start()
    {
        //black.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (transition == true)
        {
            fade = fade + delta * Time.deltaTime;
            Music.pitch -= delta * Time.deltaTime;
            TransitionObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, fade);

        }

        if (fade >= 2.0f)
        {
            transition = false;
            UIGameOver.SetActive(true);
            UIScore.SetActive(true);
            Score.text = GameManager.instance.GetScore().ToString();

        }

        if (Input.GetKeyDown(KeyCode.Return) && transition == false)
        {
            SceneManager.LoadScene(sceneName: loadScene);
        }
    }

    public void begin()
    {
        Debug.Log("gameover being called");
        TransitionObject.SetActive(true);
        transition = true;
    }
}
