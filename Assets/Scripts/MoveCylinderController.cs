using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCylinderController : MonoBehaviour
{
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3f;

        transform.Translate(x, 0, z);
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
    }
}
