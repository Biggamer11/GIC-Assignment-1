using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMMove : MonoBehaviour
{
    public float speed;

    private float originx;
    private float originy;
    public float move_X;
    public float move_Y;

    // Start is called before the first frame update
    void Start()
    {
        originx = transform.position.x;
        originy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -originx || transform.position.y < -originy)
        {
            transform.position = new Vector2(originx, originy);
        }
        transform.Translate(new Vector2(-move_X, -move_Y) * speed * Time.deltaTime);
        
    }
}
