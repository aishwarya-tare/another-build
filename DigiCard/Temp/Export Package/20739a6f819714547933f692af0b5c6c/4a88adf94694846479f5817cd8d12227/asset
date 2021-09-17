using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFade : MonoBehaviour
{

  
    public GameObject eventFlagHolder;

    
    public GameObject text;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(eventFlagHolder.GetComponent<EventFlags>().getPlanesFlag() == true)
        {
            text.SetActive(false);
        }
    }
}
