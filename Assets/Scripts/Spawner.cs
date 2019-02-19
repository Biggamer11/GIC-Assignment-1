using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject Obj;
    private Pooler pooler;
    GameObject p = null;
    int time;
    public float wait;
    public float waitmin;
    public float waitmax;
    bool spawn = false;
    private bool begin;

    // Start is called before the first frame update
    void Start()
    {
        pooler = Obj.GetComponent<Pooler>();
        
    }
    private void Update()
    {
        //Debug.Log(Time.time);
        if (spawn == true)
        {
            spawn = false;
            time = Mathf.CeilToInt(Time.time);
            Spawn();
            wait = Random.Range(waitmin, waitmax);
        }
        /*
            if (time + wait < Mathf.CeilToInt(Time.time))
            {
                spawn = true;
            }
        */

        if (time + wait < Mathf.CeilToInt(Time.time))
        {
            spawn = true;
        }

        if (begin == true)
        {
            begin = false;
            wait = Random.Range(waitmin, waitmax);
        }

    }

    void Spawn()
    {

        p = pooler.getPooledObject();
        p.transform.position = gameObject.transform.position;
        p.SetActive(true);

    }
}
