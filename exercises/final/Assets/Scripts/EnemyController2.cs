using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyController2 : MonoBehaviour
{
    public Text loseText2;
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        loseText2.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.name == "Player")
        {
            Debug.Log("Destory" + other.gameObject.name);
            Destroy(other.gameObject);
            setloseText();


        }

        void setloseText()
        {
            loseText2.text = "OMGGGGG";
            playerPrefab.gameObject.SetActive(false);
            SceneManager.LoadScene("Killed By Beauty");
        }

    }
}
