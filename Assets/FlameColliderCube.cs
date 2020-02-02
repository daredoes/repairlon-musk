using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameColliderCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("colliding with "+collision.gameObject.name);


        if (gameObject.activeSelf)
        if (collision.gameObject.name.Contains("Hole"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
