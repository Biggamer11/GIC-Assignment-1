using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionIn : MonoBehaviour
{
    public GameObject TransitionObject;
    public AudioSource Music;
    bool transition = true;
    public float delta;
    float fade = 1.0f;
    float volume;

    // Start is called before the first frame update
    void Start()
    {
        volume = 0;
        transition = true;
        //black.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transition == true)
        {
            fade = fade - delta * Time.deltaTime;
            Music.volume = volume + fade;
            TransitionObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, fade);

        }

        if (fade <= 0)
        {
            transition = false;

        }
    }

}
