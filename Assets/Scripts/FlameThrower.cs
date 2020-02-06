using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public Transform trigger;
    Vector3 triggerStartPosition;

    public GameObject flameCollider;

    bool isHeld;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        triggerStartPosition = trigger.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
            trigger.localPosition = triggerStartPosition + new Vector3(OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) / 1000f, 0, 0);

            if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                particleSystem.Play();
                flameCollider.SetActive(true);
            }
            else
            {
                particleSystem.Stop();
                flameCollider.SetActive(false);
            }
        
    }


}
