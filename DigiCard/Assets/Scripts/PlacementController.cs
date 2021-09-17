using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;



public class PlacementController : MonoBehaviour
{


    public GameObject paintingprefab;

    private GameObject paintingSpawned;

    private ARRaycastManager raycastManager;

    private Vector2 touchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    [SerializeField]
    private GameObject eventFlagHolder;

    [SerializeField]
    private GameObject planeA, planeB, planeC, planeD;

    [SerializeField]
    private GameObject cube;

    private GameObject cubeA, cubeB, cubeC, cubeD;


    private List<GameObject> planeList = new List<GameObject>();





    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        planeList.Add(planeA);
        planeList.Add(planeB);
        planeList.Add(planeC);
        planeList.Add(planeD);

    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }


    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
        {
            return;
        }
        if(Input.touchCount > 0)
        {
            Touch tap = Input.GetTouch(0);
            if(tap.phase == TouchPhase.Began)
            {
                if (raycastManager.Raycast(tap.position, hits, TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;

                    if (planeList.Count != 0)
                    {
                        planeList[0].transform.position = hitPose.position;
                        planeList[0].SetActive(true);
                        planeList.RemoveAt(0);
                    }
                }
        }
        

            


        }
        if (planeList.Count == 0)
        {
           
            eventFlagHolder.GetComponent<EventFlags>().setPlanesFlag(true);
        }



    }
}
