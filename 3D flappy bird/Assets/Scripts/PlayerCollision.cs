﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movementScript;
    public CameraFollow cameraFollowScript;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles")
        {
            movementScript.enabled = false;
            FindObjectOfType<GameManager>().gameOver();
        }
    }
}
