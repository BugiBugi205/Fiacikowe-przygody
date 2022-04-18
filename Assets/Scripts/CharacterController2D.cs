using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    private const float MOVE_SPEED = 30f;

    private Rigidbody2D rigidbodyy2D;
    private Vector3 moveDirection;

    private void Awake()
    {
        rigidbodyy2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float moveX = 0f;
        
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            moveX += 1f;
        }
        if(Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            moveX -= 1f;
        }

        moveDirection = new Vector3(moveX, 0).normalized;
    }
    private void FixedUpdate()
    {
        rigidbodyy2D.velocity = moveDirection * MOVE_SPEED;           
    }
}
