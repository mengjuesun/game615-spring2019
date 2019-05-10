using UnityEngine;
using System.Collections;

public class Door2Open : MonoBehaviour
{


    public float mSpeed = 5F;

    private bool Triggered = false;

    void Update()
    {
        if (Triggered)
        {
            OpenDoorAni();
        }
        else if (!Triggered)
        {
            CloseDoorAni();
        }
    }


    private void OpenDoorAni()
    {
        if (transform.position.x <= 1.8F)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5F);
        }
    }

    private void CloseDoorAni()
    {

        StartCoroutine("Wait");
        if (transform.position.x >= 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5F);
        }
    }

    void OnTriggerEnter(Collider mCollider)
    {
        Debug.Log(mCollider.gameObject.tag);
        if (mCollider.gameObject.tag == "Player")
        {
            Triggered = true;
        }
    }

    void OnTriggerExit(Collider mCollider)
    {
        if (mCollider.gameObject.tag == "Player")
        {
            Triggered = false;
        }
    }


    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1);
    }


}