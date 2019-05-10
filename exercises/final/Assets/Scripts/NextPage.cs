using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NextPage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject btnObj = GameObject.Find("NextPageButton");
        Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            this.GoNextScene(btnObj);

        });

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoNextScene(GameObject NScene)
    {
        Application.LoadLevel("NPC2");
    }
}
