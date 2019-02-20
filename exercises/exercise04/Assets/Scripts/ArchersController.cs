using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchersController : MonoBehaviour {

    public Transform player;
    public float speed;
    public float rotspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetdir = player.position - transform.position;
        float step = rotspeed * Time.deltaTime;
        Vector3 newdir = Vector3.RotateTowards(transform.forward, targetdir, step, 0.0F);
        transform.rotation = Quaternion.LookRotation(newdir);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

	}
}
