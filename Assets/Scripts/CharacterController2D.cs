using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    private const float MOVE_SPEED = 10f;
    private const float JUMP_FORCE = 15f;

    [SerializeField] private LayerMask blocksLayerMask;
    private Rigidbody2D rigidbodyy2D;
    private BoxCollider2D boxCollider2D;
    private Vector2 moveDirection;

    private void Awake()
    {
        rigidbodyy2D = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        float moveX = 0f;
        float jump = 0f;
        
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
        if(isGrounded() && Input.GetKey(KeyCode.Space))
        {
            jump = JUMP_FORCE;
        }

        moveDirection = new Vector2(moveX, jump);
    }
    private void FixedUpdate()
    {
        rigidbodyy2D.AddForce(moveDirection, ForceMode2D.Impulse);
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, blocksLayerMask);
        return raycastHit2D.collider != null;
    }
}
