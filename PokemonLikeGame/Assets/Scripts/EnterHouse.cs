using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouse : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] Transform teleportPos;

    private void Start()
    {
        Debug.Log("it starts atleast");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Started the method");
        if (collision.CompareTag("Player"))
        {
            Debug.Log("tag is player");
            player.transform.position = teleportPos.position;
        }
    }
}
