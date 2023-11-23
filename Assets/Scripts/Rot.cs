using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rot : MonoBehaviour
{

    public Sprite spriteW, spriteB;
    private SpriteRenderer sr;
    private Collider player;
    private bool rotten;
    public static int rotCount;

    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = spriteW;
        rotCount = 0;
        rotten = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !rotten)
        {
            sr.sprite = spriteB;
            rotCount++;
            rotten = true;
        }
    }
    public void Unrot(){
        sr.sprite = spriteW;
        rotCount = 0;
        rotten = false;
    }
}