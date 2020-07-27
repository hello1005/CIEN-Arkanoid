﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D BallRb;

    void Start()
    {
        speed = 200;
        //speed = GameManagement.ballSpeed;

        BallRb = GetComponent<Rigidbody2D>();
        BallRb.isKinematic = false;
        BallRb.AddForce(new Vector2(0, speed));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "ButtomWall")
        {
            GameObject.Find("GameManager").GetComponent<Life>().playerLife--;
            GameObject.Find("GameManager").GetComponent<Life>().LifeIcon[GameObject.Find("GameManager").GetComponent<Life>().playerLife].SetActive(false);
        } 
    }
}
