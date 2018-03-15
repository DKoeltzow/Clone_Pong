using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Vector2 pos;
    // Use this for initialization
    void Start () {
      pos = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(0,0,0)).x, Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y);
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position= pos;
		
	}
}
