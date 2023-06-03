using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    // This initializer class is the one that calls the instance of the event manager or any kind of scritpable object that
    private void Awake()
    {
        EventManager.Instance.Enable();
    }
}
