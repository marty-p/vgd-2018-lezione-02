using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;

    [Header("Gameplay")]
    public float speedMove = 10f;
    public float speedJump = 100f;
    public bool canJump = false;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (canJump)
        {
            float movementJ = Input.GetAxis("Jump") * speedJump;
            canJump = false;
            Vector3 vJ = new Vector3(0, movementJ, 0);
            rb.AddForce(vJ, ForceMode.Impulse);
        }
        float movementH = Input.GetAxis("Horizontal") * speedMove;
        float movementV = Input.GetAxis("Vertical") * speedMove;
        Vector3 vHV = new Vector3(movementH, 0, movementV);
        rb.AddForce(vHV, ForceMode.Force);
	}
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter: " + other.name);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("OnCollisionEnter: " + collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (!canJump)
            canJump = true;
        //Debug.Log("OnCollisionStay");
    }
    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("OnCollisionExit: " + collision.gameObject.name);
    }
}
