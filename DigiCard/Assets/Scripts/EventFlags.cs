using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFlags : MonoBehaviour
{
    private bool planesPlaced;
    private bool paintingFlag;
    private bool scratchingFlag;
    private bool knifeFlag;
    private bool paintingGoneFlag;
    private bool scratchingGoneFlag;
    private bool scratchSoundFlag;
    private bool vaseFlag;
    private bool vaseBreakFlag;
    private bool ashFlag;


    void Start()
    {
        planesPlaced = false;
        paintingFlag = false;
        scratchingFlag = false;
        knifeFlag = false;
        paintingGoneFlag = false;
        scratchingGoneFlag = false;
        scratchSoundFlag = false;
        vaseFlag = false;
        vaseBreakFlag = false;
        ashFlag = false;
    }


    public bool getSGoneFlag()
    {
        return scratchingGoneFlag;
    }

    public void setSGoneFlag(bool state)
    {
        scratchingGoneFlag = state;
    }


    public bool getPGoneFlag()
    {
        return paintingGoneFlag;
    }

    public void setPGoneFlag(bool state)
    {
        paintingGoneFlag = state;
    }

    public bool getPlanesFlag()
    {
        return planesPlaced;
    }

    public void setPlanesFlag(bool state)
    {
        planesPlaced = state;
    }

    public bool getPaintingFlag()
    {
        return paintingFlag;
    }

    public bool getScratchingFlag()
    {
        return scratchingFlag;
    }

    public bool getKnifeFlag()
    {
        return knifeFlag;
    }


    public void setPaintingFlag(bool state)
    {
        paintingFlag = state;
    }

    public void setScratchingFlag(bool state)
    {
        scratchingFlag = state;
    }

    public void setKnifeFlag(bool state)
    {
        knifeFlag = state;
    }

    public bool getSSoundFlag()
    {
        return scratchSoundFlag;
    }

    public void setSSoundFlag(bool state)
    {
        scratchSoundFlag = state;
    }

    public bool getVaseFlag()
    {
        return vaseFlag;
    }

    public void setVaseFlag(bool state)
    {
        vaseFlag = state;
    }

    public bool getVaseBreakFlag()
    {
        return vaseBreakFlag;
    }

    public void setVaseBreakFlag(bool state)
    {
        vaseBreakFlag = state;
    }

    public bool getAshFlag()
    {
        return ashFlag;
    }

    public void setAshFlag(bool state)
    {
        ashFlag = state;
    }



}
