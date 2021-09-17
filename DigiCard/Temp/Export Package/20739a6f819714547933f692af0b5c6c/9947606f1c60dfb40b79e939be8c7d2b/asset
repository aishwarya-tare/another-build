using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class soundcontroller : MonoBehaviour
{
  
    private AudioSource childsound;
    private AudioSource scratching;

    [SerializeField]
    private Camera camera;

    [SerializeField]
    private GameObject BaseSession;

    [SerializeField]
    private GameObject eventFlagHolder;

    private GameObject painting, scratches;

    

    // Start is called before the first frame update
    void Start()
    {

        painting = BaseSession.GetComponent<LoadPainting>().getPainting();
        scratches = BaseSession.GetComponent<LoadScratches>().getScratches();


        childsound = painting.GetComponent<AudioSource>();
        scratching = scratches.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //paintingPressed();

        if(childsound.isPlaying == false)
        {
            eventFlagHolder.GetComponent<EventFlags>().setPGoneFlag(true);

        }

        if(eventFlagHolder.GetComponent<EventFlags>().getPGoneFlag() == true)
        {
            scratching.Play();
            eventFlagHolder.GetComponent<EventFlags>().setSSoundFlag(true);
        }

    }




}
