using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D rd;
    private BoxCollider2D collider;
    public float speed;
    public GameObject exp;
    public AudioSource expsound;
    public GameObject powerup;
    public AudioSource powerupsound;
    // Start is called before the first frame update
    void Start()
    {
        rd = gameObject.GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        expsound = gameObject.GetComponent<AudioSource>();
        powerupsound = powerup.GetComponent<AudioSource>();
        rd.rotation = -90f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // add forces by getkey
        float xSpeed = 0;
        float ySpeed = 0;
        if (Input.GetKey(KeyCode.W))
        {
            ySpeed = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ySpeed = -1;
        }
        rd.velocity = (new Vector2(xSpeed, ySpeed) * speed);
    }

    private void Update()
    {
        if(transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x,-4,0);
        }
        if (transform.position.y > 4)
        {
            transform.position = new Vector3(transform.position.x, 4, 0);
        }

        if (rd.rotation > 91f || rd.rotation < 89)
        {
            rd.rotation = -90f;
        }
    }
    void example1()
    {
        //translate by axis
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        
        transform.Translate(new Vector2(xSpeed, ySpeed) * speed);
    }

    void example2()
    {
        // add firces by axis
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
        rd.AddForce(new Vector2(xSpeed, ySpeed) * speed);
    }

    void example3()
    {
        // add forces by getkey
        float xSpeed = 0;
        float ySpeed = 0;
        if (Input.GetKey(KeyCode.D))
        {
            xSpeed = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            xSpeed = -1;
        }
            rd.AddForce(new Vector2(xSpeed, ySpeed) * speed);
    }

    void example4()
    {
        rd.velocity = new Vector2(0,0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("gg tag was triggered");
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hostile")
        {
            Debug.Log(GameManager.instance.GetLives());
            collision.gameObject.SetActive(false);
            GameManager.instance.DecLives();
            StartCoroutine(Explode());
        }
        if (collision.gameObject.tag == "PowerUp")
        {
            Debug.Log(GameManager.instance.GetScore());
            collision.gameObject.SetActive(false);
            powerupsound.Play();
            GameManager.instance.IncScore();
        }
    }

    IEnumerator Explode()
    {
        expsound.Play();
        exp.SetActive(true);
        yield return new WaitForSeconds(1);
        exp.SetActive(false);
    }

}
