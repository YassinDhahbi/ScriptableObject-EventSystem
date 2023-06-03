using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CollisionCounter : MonoBehaviour
{
    // This class takes in the TextMeshPro UI and binds it with the counter that we have in here
    [SerializeField]
    int counter;
    [SerializeField]
    TextMeshProUGUI collisionCounterTMP;
    public void UpdateCounter()
    {
        counter++;
        collisionCounterTMP.text = counter.ToString();
    }
}
