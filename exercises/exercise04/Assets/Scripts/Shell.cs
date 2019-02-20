using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {




    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Archers"))
        {
            other.gameObject.SetActive(false);
    
        }
    }

}
