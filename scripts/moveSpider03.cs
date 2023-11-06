using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderC : MonoBehaviour
{
    public float jumpHeight = 250.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Ground") {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
        }
    }
}