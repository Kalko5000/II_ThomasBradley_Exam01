using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSpider01 : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject table;
    public GameObject chair;

    private bool toChair = true;
    private Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(toChair) {
            transform.LookAt(chair.transform);
            transform.Translate(transform.forward * speed * Time.deltaTime, Space.World); // No hace falta direccion, se mueve hacia delante
        } else {
            transform.LookAt(table.transform);
            transform.Translate(transform.forward * speed * Time.deltaTime, Space.World); // No hace falta direccion, se mueve hacia delante
        }
    }

    void OnCollisionEnter(Collision other) {
        // Quite comentario Debug "Hello"
        if(other.gameObject.tag == "Table") {
            toChair = true;
        } else if (other.gameObject.tag == "Chair") {
            toChair = false;
        }
    }
}
