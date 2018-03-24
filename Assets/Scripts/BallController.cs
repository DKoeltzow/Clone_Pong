using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Vector2 pos;

    Vector2 boundMin;
    Vector2 boundMax;

    public Vector2 Dir;

    public float Movespeed;

    private Vector2 startDir;
    
    // Use this for initialization

    void Start ()
    {
        pos = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,0,0)).x, Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height/2, 0)).y);
        boundMin = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y);
        boundMax = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y);
        this.transform.position = pos;
        startMove();
    }

    

    // Update is called once per frame
    void Update ()
    {  
        Move();
	}

    private void startMove()
    {
        float xDir = UnityEngine.Random.Range(0.45f, 1f);
        float yDir = UnityEngine.Random.Range(0, 0.45f);

        startDir = new Vector2(xDir, yDir);
        startDir.Normalize();

        Dir = startDir;
    }

    private void Move()
    {

        // Ball below screen or above screen-- Change x dir
        if (transform.position.x <= boundMin.x || transform.position.x >= boundMax.x)
        {
            Dir = new Vector2(-Dir.x, Dir.y);
        }
        if (transform.position.y < boundMin.y || transform.position.y >= boundMax.y)
        {
            Dir = new Vector2(Dir.x, -Dir.y);
        }

        this.transform.Translate(Dir*Movespeed *Time.deltaTime);
    }
}
