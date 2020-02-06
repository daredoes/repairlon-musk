using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o2bar : MonoBehaviour
{
    float o2 = 1f;

    public float degradationRate;

    Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(
            startScale.x * o2,
            startScale.y,
            startScale.z
            );

        o2 -= Time.deltaTime / 200f;
    }
}
