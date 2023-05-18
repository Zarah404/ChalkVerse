using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_level : MonoBehaviour
{
    public float minYPosition = -10f; // Define the minimum y position to trigger level restart

    private bool isFalling = false;
    private Coroutine restartCoroutine;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Water") || (collision.gameObject.CompareTag("Spike")))
        {
            
            isFalling = true;
            restartCoroutine = StartCoroutine(CheckFalling());
        }
        else
        {
           
            isFalling = false;
            if (restartCoroutine != null)
            {
                StopCoroutine(restartCoroutine);
            }
        }
    }

    private IEnumerator CheckFalling()
    {
        yield return new WaitForSeconds(0.0f); // wait for 2 seconds before checking if the player is still falling
        if (isFalling)
        {
            Debug.Log("Player fell off the platform!");
            yield return new WaitForSeconds(0.0f); // wait for 1 second before restarting the game
            Debug.Log("Restarting game...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("Player landed on a platform.");
        }
    }

    private void Update()
    {
        if (transform.position.y < minYPosition)
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
