using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rd;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rd = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rd.AddForce(new Vector2(-1, 0) * speed);
    }

    private void Update()
    {
        if (transform.position.x < -13)
        {
            rd.velocity = new Vector2(0, 0);
            gameObject.SetActive(false);
        }
        if (rd.rotation > 91f || rd.rotation < 89)
        {
            rd.rotation = -90f;
        }

        
    }
}
