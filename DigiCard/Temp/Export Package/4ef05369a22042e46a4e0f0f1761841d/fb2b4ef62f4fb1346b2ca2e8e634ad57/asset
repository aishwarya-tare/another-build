using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // this namespace makes the magic, tho

public class OnTapOccurs : MonoBehaviour
{

    [SerializeField] UnityEvent anEvent; // puts an easy to setup event in the inspector and anEvent references it so you can .Invoke() it
        
    private void OnMouseDown()
    {
        print("You clicked the cube!");
        anEvent.Invoke(); // Triggers the events you have setup in the inspector
    }

    public void EventClick()
    {
        print("Which also triggered this method as a UnityEvent!");
    }
}