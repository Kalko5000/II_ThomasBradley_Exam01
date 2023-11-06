using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growSpiderB : MonoBehaviour
{
    public gazeSpiderA spider;
    public float growSize = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        spider.spiderTime += grow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void grow() {
        transform.localScale += new Vector3(growSize, growSize, growSize);
    }
}
