using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassDetection : MonoBehaviour
{
    int randomnumber;

    private void Start()
    {
        Debug.Log("started");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Exited");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Entered");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.attachedRigidbody.velocity.x != 0 || collision.attachedRigidbody.velocity.y != 0)
            {

                randomnumber = Random.Range(1, 500);
                if (randomnumber < 300)
                {
                    Debug.Log("Wild pokemon encounter");
                }
            }

        }
    }



}
