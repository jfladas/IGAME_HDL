using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rot : MonoBehaviour
{

    public Sprite spriteW, spriteB;
    private SpriteRenderer sr;
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
        if (collision.gameObject.CompareTag("Player"))
        {
            RotTooth();
        }
    }
    
    public void RotTooth(){
        if(!rotten)
        {
            gameObject.GetComponent<AudioSource>().Play();
            sr.sprite = spriteB;
            rotCount++;
            rotten = true;
        }
    }
    public void UnrotTooth(){
        sr.sprite = spriteW;
        rotten = false;
    }
}
