using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HandButton : MonoBehaviour
{
    public UnityEvent action;
    
    public void Press()
    {
        action.Invoke();
    }
}
