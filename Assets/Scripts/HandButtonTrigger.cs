using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandButtonTrigger : MonoBehaviour
{
    bool hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<HandButton>().Press();
    }
}
