using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSpider02 : MonoBehaviour
{
    public Vector3 pointA;
    public Vector3 pointB;
    public float moveSpeed = 2.0f;

    private bool moveA = false;
    
    // Start is called before the first frame update
    void Start()
    {
        pointA = new Vector3(Random.Range(-2.0f, 6.0f), 0.0f, Random.Range(-6.0f, 0.0f));
        pointB = new Vector3(Random.Range(-2.0f, 6.0f), 0.0f, Random.Range(-6.0f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        if(moveA) {
            transform.position = Vector3.MoveTowards(transform.position, pointA, moveSpeed * Time.deltaTime);
        } else {
            transform.position = Vector3.MoveTowards(transform.position, pointB, moveSpeed * Time.deltaTime);
        }
        if(transform.position == pointA) {
            moveA = false;
        } else if (transform.position == pointB) {
            moveA = true;
        }
    }
}
