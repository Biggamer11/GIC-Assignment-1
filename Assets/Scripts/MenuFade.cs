using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFade : MonoBehaviour
{
    public GameObject MenuObject;
    public bool transition = true;
    public float delta;
    public string loadScene;
    int FadeDirection = 1;
    float fade = 0.0f;
    public float IntermediateFadeTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transition == true && FadeDirection == 1)
        {
            fade = fade + delta * Time.deltaTime;
            MenuObject.GetComponent<CanvasGroup>().alpha = fade;

        }

        if (fade >= 1.0f + IntermediateFadeTime)
        {
            FadeDirection = -1;

        }

        if (fade <= 0.0f && FadeDirection == -1)
        {
            SceneManager.LoadScene(sceneName: loadScene);
        }

        if (transition == true && FadeDirection == -1)
        {
            fade = fade - delta * Time.deltaTime;
            MenuObject.GetComponent<CanvasGroup>().alpha = fade;

        }
    }



}
