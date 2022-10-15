using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    private float driX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    private enum MovmentState {idle, running, jumping, falling }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
   private void Update()
    {
        driX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(driX * moveSpeed,rb.velocity.y );

        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationState();

    }
    private void UpdateAnimationState()
    {
        MovmentState state;

        if (driX > 0f)
        {
            state = MovmentState.running;
            sprite.flipX = false;
        }
        else if (driX < 0f)
        {
            state = MovmentState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovmentState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovmentState.jumping;      
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovmentState.falling;
        }

        anim.SetInteger("state", (int)state);
    }
}
