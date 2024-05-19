using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float tempMoveSpeed = 5.0f;

    private void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    public enum Direction
    {
        Left = -1,
        Right = 1
    }

    public void Move(Direction direction)
    {
        rigid2D.MovePosition(rigid2D.position + Vector2.right * (int)direction * 5 * Time.deltaTime);
    }
}
