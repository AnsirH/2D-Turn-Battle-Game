using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteManager : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    public SpriteRenderer SpriteRenderer => spriteRenderer;
    public Animator Anim => anim;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
}
