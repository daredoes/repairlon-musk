using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadThingsSpawner : MonoBehaviour
{
    public Transform[] badThings;

    // Start is called before the first frame update
    void Start()
    {
        StartTimer(15f);
    }
    
    void StartTimer(float waitTime)
    {
        IEnumerator timer = Timer(waitTime);
        StartCoroutine(timer);
    }

    IEnumerator Timer(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Do something
        StartTimer(15f);
    }

    void SpawnBadThing()
    {

    }


    
}
