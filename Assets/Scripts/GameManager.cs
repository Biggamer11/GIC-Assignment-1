using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private int score = 0;
    public int lives = 3;
    private int finalscore;
    private bool final;
    private bool transit = false;
    public GameObject player;
    public GameObject gameover;
    private GameOver goscript;

    public static GameManager instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }


    }

    private void Start()
    {
        goscript = gameover.GetComponent<GameOver>();
    }

    public void DecLives()
    {
        lives -= 1;
        if (lives < 0 && final == false)
        {
            transit = true;
            finalscore = score;
            final = true;
            Debug.Log("Final");
            StartCoroutine(End());
            goscript.begin();
            
        }
        if (lives < 0)
        {
            lives = 0;
        }
    }
    public void IncLives()
    {
        lives += 1;
    }

    public int GetLives()
    {
        return lives;
    }

    public void DecScore()
    {
        score -= 1;
    }
    public void IncScore()
    {
        score += 1;
    }

    public int GetScore()
    {
        return score;
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(1);
        player.SetActive(false);
    }
}
