using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spiderCollision : MonoBehaviour
{
    // Ahora esta en Player
    private int counter = 0;
    public Text score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Stomp Points: " + counter.ToString(); // UI para 16:9 Landscape
    }

    void OnTriggerEnter(Collider other) { // Cambio por OnTrigger para que funcione al saltar encima de
        if(other.gameObject.tag == "Spider") {
            counter += 10;
        }
    }
}
