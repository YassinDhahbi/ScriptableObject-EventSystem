using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    Rigidbody playerRb;

    void MovePlayer()
    {
        var verticalMovement = Input.GetAxis("Vertical");
        var horizontalMovement = Input.GetAxis("Horizontal");
        var movementDirection = new Vector3(horizontalMovement, verticalMovement, 0);
        playerRb.velocity += movementDirection.normalized * moveSpeed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
}
