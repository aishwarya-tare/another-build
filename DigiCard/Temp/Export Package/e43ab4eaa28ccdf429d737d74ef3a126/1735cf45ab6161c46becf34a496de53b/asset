using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class LoadPainting : MonoBehaviour
{
    [SerializeField]
    private GameObject planeA;

    [SerializeField]
    private GameObject eventFlagHolder;

    [SerializeField]
    private GameObject paintingPrefab;

    [SerializeField]
    private GameObject mainCam;

    [SerializeField]
    private GameObject knifePrefab;

    private GameObject spawnedKnife;

    [SerializeField]
    private GameObject PlaneC;

    [SerializeField]
    private GameObject PlaneB;

    [SerializeField]
    private GameObject vasePrefab;

    [SerializeField]
    private GameObject vaseBreakPrefab;


    [SerializeField]
    private GameObject scratchPrefab;

    private GameObject spawnedScratch;

    [SerializeField]
    private GameObject ashPrefab;

    private GameObject spawnedVase, spawnedVaseBreak, spawnedAsh;

    private GameObject spawnedPainting, spawnedScratches, paintingSource;

    [SerializeField]
    private ARPlaneManager aRPlaneManager;

    private bool hasSpawned;
    private bool hasDespawned;
    private bool scratchSpawn, knifeSpawn, vaseSpawn, vaseBreakSpawn, ashSpawn, readyForKnife;



    void Start() {

        hasSpawned = false;
        hasDespawned = false;
        scratchSpawn = false;
        knifeSpawn = false;
        vaseSpawn = false;
        vaseBreakSpawn = false;
        ashSpawn = false;
        readyForKnife = false;

    }

    void Update()
    {
        

        if (eventFlagHolder.GetComponent<EventFlags>().getPlanesFlag() == true && hasSpawned == false)
        {
            Invoke("setPaintingActive", 3.0f);
            hasSpawned = true;
            paintingSource = spawnedPainting.transform.GetChild(1).gameObject;
            aRPlaneManager.enabled = !aRPlaneManager.enabled;
            foreach (var plane in aRPlaneManager.trackables)
            {
                plane.gameObject.SetActive(false);
            }

        }

        if (eventFlagHolder.GetComponent<EventFlags>().getPaintingFlag() == true && scratchSpawn == false)
        {
            Invoke("spawnScratch", 7.0f);
            scratchSpawn = true;
            readyForKnife = true;
            eventFlagHolder.GetComponent<EventFlags>().setKnifeFlag(true);
        }

        if (eventFlagHolder.GetComponent<EventFlags>().getPGoneFlag() == true && hasDespawned == false)
        {
            setPaintingInactive();
            hasDespawned = true;
        }



        if (readyForKnife == true && knifeSpawn == false)
        {
            Invoke("setKnife", 7.0f);
            spawnedScratch.SetActive(false);
            knifeSpawn = true;
        }

        if(eventFlagHolder.GetComponent<EventFlags>().getKnifeFlag() == true && vaseSpawn == false)
        {
            setVase();
            vaseSpawn = true;
        }
        if(eventFlagHolder.GetComponent<EventFlags>().getVaseFlag() == true && vaseBreakSpawn == false)
        {
            setVaseBreak();
            vaseBreakSpawn = true;
        }
        if(eventFlagHolder.GetComponent<EventFlags>().getVaseBreakFlag() == true && ashSpawn == false)
        {
            setAsh();
            ashSpawn = true;
        }



    }


    void setPaintingActive()
    {
        spawnedPainting = Instantiate(paintingPrefab);
        
        spawnedPainting.SetActive(true);

        spawnedPainting.transform.position = planeA.transform.position;
        spawnedPainting.transform.rotation = planeA.transform.rotation;
        spawnedPainting.transform.Rotate(0.0f, 90.0f, -90.0f, Space.World);

        eventFlagHolder.GetComponent<EventFlags>().setPaintingFlag(true);

    }

    void setPaintingInactive()
    {
        
        spawnedPainting.SetActive(false);

    }


    public GameObject getPainting()
    {
        return spawnedPainting;
    }


    void setKnife()
    {
        spawnedKnife = Instantiate(knifePrefab);
        
        spawnedKnife.transform.position = PlaneC.transform.position;
        spawnedKnife.transform.rotation = PlaneC.transform.rotation;
        eventFlagHolder.GetComponent<EventFlags>().setKnifeFlag(true);
    }

    void setVase()
    {
        spawnedVase = Instantiate(vasePrefab);
        spawnedVase.SetActive(true);
        spawnedVase.transform.position = PlaneB.transform.position;
        spawnedVase.transform.rotation = PlaneB.transform.rotation;
        eventFlagHolder.GetComponent<EventFlags>().setVaseFlag(true);
    }

    void setVaseBreak()
    {
        spawnedVaseBreak = Instantiate(vaseBreakPrefab);
        spawnedVaseBreak.SetActive(true);
        spawnedVaseBreak.transform.position = PlaneB.transform.position;
        spawnedVaseBreak.transform.rotation = PlaneB.transform.rotation;
        eventFlagHolder.GetComponent<EventFlags>().setVaseBreakFlag(true);
    }

    void setAsh()
    {
        spawnedAsh = Instantiate(ashPrefab);
        spawnedAsh.SetActive(true);
        spawnedAsh.transform.position = PlaneB.transform.position;
        spawnedAsh.transform.rotation= PlaneB.transform.rotation;
        eventFlagHolder.GetComponent<EventFlags>().setAshFlag(true);
    }


    void spawnScratch()
    {
        spawnedScratch = Instantiate(scratchPrefab);
        spawnedScratch.SetActive(true);
        spawnedScratch.transform.position = PlaneC.transform.position;
        spawnedScratch.transform.rotation = PlaneC.transform.rotation;

        eventFlagHolder.GetComponent<EventFlags>().setScratchingFlag(true);

    }

}
