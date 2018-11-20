using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {
    float rotSpeed = 160f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.World);
    }
}
