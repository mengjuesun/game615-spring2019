using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ending2 : MonoBehaviour
{

    public GameObject playerPrefab;

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {

            SceneManager.LoadScene("Ending2");

        }
    }
}
