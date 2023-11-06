using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gazeSpiderA : MonoBehaviour
{
    public delegate void message();
    public event message spiderTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        spiderTime();
    }
}
