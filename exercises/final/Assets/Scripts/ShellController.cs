using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShellController : MonoBehaviour
{
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("evils"))
        {
            other.gameObject.SetActive(false);
            
        }

    }
}
