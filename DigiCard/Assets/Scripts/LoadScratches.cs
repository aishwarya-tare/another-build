using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class LoadScratches : MonoBehaviour
{

    [SerializeField]
    private GameObject planeC;

    [SerializeField]
    private GameObject eventFlagHolder;

    [SerializeField]
    private GameObject scratchPrefab;

    private GameObject spawnedScratch;

    private bool hasSpawned, hasDespawned;


    // Start is called before the first frame update
    void Start()
    {

        hasSpawned = false;
        hasDespawned = false;


    }

    // Update is called once per frame
    void Update()
    {
        
        if(eventFlagHolder.GetComponent<EventFlags>().getPaintingFlag() == true && hasSpawned == false)
        {
            Invoke("spawnScratch", 7.0f);
            hasSpawned = true;
        }
        
        if(eventFlagHolder.GetComponent<EventFlags>().getSGoneFlag() == true && hasDespawned == false)
        {
            despawnScratch();
            hasDespawned = true;
        }



    }


    void spawnScratch()
    {
        spawnedScratch = Instantiate(scratchPrefab);
        spawnedScratch.SetActive(true);
        spawnedScratch.transform.position = planeC.transform.position;
        spawnedScratch.transform.rotation = planeC.transform.rotation;

        eventFlagHolder.GetComponent<EventFlags>().setScratchingFlag(true);

    }

    void despawnScratch()
    {
        spawnedScratch.SetActive(false);
    }

    public GameObject getScratches()
    {
        return spawnedScratch;
    }

}
