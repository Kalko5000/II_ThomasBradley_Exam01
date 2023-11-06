using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpChair : MonoBehaviour
{
    public bedCollision bed;
    public float jumpHeight = 250.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        bed.bedTime += jumpTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void jumpTime() {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
    }
}
