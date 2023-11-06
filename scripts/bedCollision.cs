using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedCollision : MonoBehaviour
{
    public delegate void message();
    public event message bedTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Bed") {
            bedTime();
        }
    }
}
