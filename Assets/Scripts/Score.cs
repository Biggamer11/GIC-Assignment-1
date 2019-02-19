using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public Text lives;

    // Start is called before the first frame update
    void Start()
    {
        score.text = GameManager.instance.GetScore().ToString();
        lives.text = GameManager.instance.GetLives().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = GameManager.instance.GetScore().ToString();
        lives.text = GameManager.instance.GetLives().ToString();
    }
}
