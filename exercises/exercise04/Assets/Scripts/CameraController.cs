using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    Vector3 offset;


    void Awake()
    {
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        Vector3 targetcampos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetcampos, speed * Time.deltaTime);
    }
}