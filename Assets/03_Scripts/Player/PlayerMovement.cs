using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigid2D;
    CapsuleCollider2D coll2D;
    public float tempMoveSpeed = 5.0f;
    public float tempJumpPower = 5.0f;

    public Rigidbody2D Rigid2D => rigid2D;
    public bool IsGrounded { get { return Physics2D.OverlapCapsule(rigid2D.position + coll2D.offset, coll2D.size, CapsuleDirection2D.Vertical, 0.0f, LayerMask.GetMask("Ground"));  } }

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        coll2D = GetComponent<CapsuleCollider2D>();
    }

    public enum Direction
    {
        Left = -1,
        Right = 1
    }

    public void MoveHorizontal(float horizontalInput)
    {
        rigid2D.velocity = new Vector2(horizontalInput * tempMoveSpeed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        rigid2D.AddForce(Vector2.up * tempJumpPower, ForceMode2D.Impulse);
    }

}
