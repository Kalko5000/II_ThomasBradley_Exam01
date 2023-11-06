using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBed : MonoBehaviour
{
    public bedCollision bed;
    public float moveSpeed = 1.0f;

    private bool move = false;
    private bool moveLeft = true;
    private Vector3 leftPoint;
    private Vector3 rightPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        bed.bedTime += enableMovement;
        leftPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
        rightPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(move) {
            if(moveLeft) {
                transform.position = Vector3.MoveTowards(transform.position, leftPoint, moveSpeed * Time.deltaTime);
            } else {
                transform.position = Vector3.MoveTowards(transform.position, rightPoint, moveSpeed * Time.deltaTime);
            }
            if(transform.position == leftPoint) {
                moveLeft = false;
            } else if (transform.position == rightPoint) {
                moveLeft = true;
            }
        }
    }

    void enableMovement() {
        move = true;
    }
}
