using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghoulMovement : MonoBehaviour
{
    public bool restrictInputs = true;
    public float speed = 1.0f;
    public float rotateSpeed = 3.0f;
    public float jumpHeight = 50.0f;

    private bool canJump = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) && restrictInputs) {
            transform.Translate(transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime, Space.World);
        } else if (!restrictInputs) {
            transform.Translate(transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime, Space.World);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) && restrictInputs) {
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);
        } else if (!restrictInputs) {
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space) && canJump) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Ground") {
            canJump = true;
        }
    }
}
