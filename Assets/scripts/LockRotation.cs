using UnityEngine;

public class LockRotation : MonoBehaviour
{
    private Quaternion initialRotation;

    private void Start()
    {
        initialRotation = transform.rotation;
    }

    private void FixedUpdate()
    {
        transform.rotation = initialRotation;
    }
}

