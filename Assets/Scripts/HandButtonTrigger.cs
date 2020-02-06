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
        
        //if (!hit)
        //{

        //}
        //    if (other.name == "Land On Mars Button")
        //{
        //    hit = true;
        //    Debug.Log("COLLIDING WITH R CUBE!!!");
        //    SceneManager.LoadSceneAsync("WinScreen");
        //}
    }
}
