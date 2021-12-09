using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
	if (Input.GetAxis("Horizontal") != 0F) {
		float angle = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		Vector3 axis = Vector3.forward;
		rb.MoveRotation(rb.rotation * Quaternion.AngleAxis(angle, axis));
	}	
    }
}
