using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrassDetection : MonoBehaviour
{
    int randomnumber;
    [SerializeField] PlayerData pD;
    [SerializeField] Transform transfo;

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
                if (randomnumber < 15)
                {
                    pD.ChangePlayerPos(transfo.position.x, transfo.position.y);
                    SceneManager.LoadScene("Battle");
                    Debug.Log("Wild pokemon encounter");
                }
            }

        }
    }



}
