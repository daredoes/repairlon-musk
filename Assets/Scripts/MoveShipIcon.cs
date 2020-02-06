using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipIcon : MonoBehaviour
{
    public GameObject landOnMarsButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x < .007f)
        {
        transform.localPosition += new Vector3(.00005f,0,0) * Time.deltaTime;
            
        if (transform.localPosition.x >= .007f)
            {
                landOnMarsButton.SetActive(true);
            }
        }
    }
}
