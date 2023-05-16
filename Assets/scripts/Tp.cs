using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
    if (other.CompareTag("Player")) {
        // Teleport the player to a new location
        other.transform.position = new Vector3(65.4f, 2.6f, 0.02f);
    }
}

}
