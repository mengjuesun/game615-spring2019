using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{

  
    public Text winText;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winText.text = "";
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            winText.text = "You Win!";
        }

    }
}
