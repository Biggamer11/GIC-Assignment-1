using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject Player;
    public GameObject UIWin;
    public GameObject UIScore;
    public Text Score;
    bool transition = false;
    public string loadScene;

    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(true);
        //black.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.GetScore() >= 10)
        {
            transition = true;
            UIWin.SetActive(true);
            UIScore.SetActive(true);
            Player.SetActive(false);
            Score.text = GameManager.instance.GetScore().ToString();
        }

        if (Input.GetKeyDown(KeyCode.Return) && transition == false)
        {
            SceneManager.LoadScene(sceneName: loadScene);
        }
    }
}

