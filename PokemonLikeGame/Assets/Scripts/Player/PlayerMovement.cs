using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] PlayerData pD;
    Vector2 moveDir;
    Transform transfo;


    private void Start()
    {
        transfo = GetComponent<Transform>();
        transfo.position = new Vector2(pD.XPos, pD.YPos);
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;
      
        rb.velocity = new Vector2(moveDir.x * speed, moveDir.y * speed);
    }
}
