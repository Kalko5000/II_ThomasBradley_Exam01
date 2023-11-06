using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportToBed : MonoBehaviour
{
    public gazeSpiderA spider;
    public Transform bed;
    
    // Start is called before the first frame update
    void Start()
    {
        spider.spiderTime += teleport;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void teleport() {
        transform.position = new Vector3(bed.transform.position.x, bed.transform.position.y + 2, bed.transform.position.z);
    }
}
