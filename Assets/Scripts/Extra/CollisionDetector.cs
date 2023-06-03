using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    // This is a simple Collision check that raises the event On>PlayerCollision
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EventManager.Instance.OnPlayerCollision.Raise();
        }
    }
}
