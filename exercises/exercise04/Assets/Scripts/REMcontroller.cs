using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REMcontroller : MonoBehaviour
{

    public float speed;
    public float rotspeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
        }



    }
}
