using UnityEngine;
using System.Collections;

public class PlayerMovment : MonoBehaviour 
{
    public float movementSpeed = 0.1f;
    private Rigidbody rb2d;
	
	void Start () 
    {
        rb2d = GetComponent<Rigidbody>();
	}
	
	
	void Update () 
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.TransformDirection(new Vector3(horizontal, 0, vertical));

        rb2d.MovePosition(transform.position + movement * movementSpeed);
	
	}
}
