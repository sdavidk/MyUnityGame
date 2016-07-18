using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
   public Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Get component of rigidbody.
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical); //Constructor to create vector3

        rb.AddForce(movement * 10);
    }
    
}
