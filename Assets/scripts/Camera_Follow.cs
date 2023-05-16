using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
   public Transform target; // The target to follow (the player)
    public float smoothTime = 0.3f; // The time it takes for the camera to catch up with the target
    public Vector3 offset; // The offset of the camera from the target

    private Vector3 velocity = Vector3.zero; // The current velocity of the camera

    void LateUpdate()
    {
        // Calculate the position the camera should move towards
        Vector3 targetPosition = target.position + offset;

        // Smoothly move the camera towards the target position using a dampening effect
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
