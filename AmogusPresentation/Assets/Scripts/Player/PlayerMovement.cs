using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_Rigidbody2D;

    [SerializeField]
    private Animator m_animator;

    [SerializeField]
    private float moveSpeed = 5f;

    private bool m_FacingRight = true;  // For determining which way the player is currently facing.

    public void Move(Vector2 move)
    {
        m_animator.SetBool("IsMoving", move != Vector2.zero);

        // Apply move speed
        move *= moveSpeed;

        // And then smoothing it out and applying it to the character
        m_Rigidbody2D.velocity = move;

        // If the input is moving the player right and the player is facing left...
        if (move.x > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (move.x < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
