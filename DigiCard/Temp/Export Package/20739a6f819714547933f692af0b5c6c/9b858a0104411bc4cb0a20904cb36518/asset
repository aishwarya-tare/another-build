using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadKnife : MonoBehaviour
{

    [SerializeField]
    private GameObject eventFlagHolder;

    [SerializeField]
    private GameObject knifePrefab;

    private GameObject spawnedKnife;

    [SerializeField]
    private GameObject main;

    private GameObject painting, scratches;

    float speed = 1.0f;

    float step;


    // Start is called before the first frame update
    void Start()
    {

        



    }

    void Awake()
    {
        GameObject knifeWhoosh = spawnedKnife.transform.GetChild(0).gameObject;
        knifeWhoosh.GetComponent<AudioSource>().Play();
    }


    // Update is called once per frame
    void Update()
    {
        if (eventFlagHolder.GetComponent<EventFlags>().getSSoundFlag() == true)
        {
            painting = main.GetComponent<LoadPainting>().getPainting();
            scratches = main.GetComponent<LoadScratches>().getScratches();
            if (eventFlagHolder.GetComponent<EventFlags>().getKnifeFlag() == false)
            {
                Invoke("spawnKnife", 2.0f);
            }
            step = speed * Time.deltaTime;
            spawnedKnife.transform.position = Vector3.MoveTowards(spawnedKnife.transform.position, painting.transform.position, step);
            if(Vector3.Distance(spawnedKnife.transform.position, painting.transform.position) < 0.001f)
            {
                GameObject knifeThud = spawnedKnife.transform.GetChild(1).gameObject;
                knifeThud.GetComponent<AudioSource>().Play();
            }

        }
    }

    void spawnKnife()
    {
        spawnedKnife = Instantiate(knifePrefab);
        spawnedKnife.SetActive(true);
        spawnedKnife.transform.position = scratches.transform.position;
        spawnedKnife.transform.rotation = scratches.transform.rotation;
        eventFlagHolder.GetComponent<EventFlags>().setKnifeFlag(true);
    }


}
