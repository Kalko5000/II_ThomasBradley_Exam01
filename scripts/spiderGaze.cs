using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gazeAtSpider : MonoBehaviour
{
    public Text percentageText;
    public int maxCounter = 2000;
    
    private bool count = false;
    private int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count) {
            counter++;
            percentageText.text = gameObject.name + ": " + ((int)(((float)counter / maxCounter) * 100)).ToString() + "%";
        }
        if(counter > maxCounter) {
            OnPointerEnter();
            transform.position = new Vector3(0.0f, -50.0f, 0.0f);
        }
    }

    public void OnPointerEnter()
    {
        count = true;
    }

    public void OnPointerExit() {
        count = false;
        if(counter > maxCounter) {
            Destroy(gameObject);
            percentageText.text = "X_X";
        }
    }
}