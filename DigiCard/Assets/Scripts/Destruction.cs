using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour{

  public GameObject destroyedVase;

  void OnMouseDown()
  {


    Instantiate(destroyedVase, transform.position, transform.rotation);
    Destroy(gameObject);
  }
}
