using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    
    private bool sceneLoaded = false;

    void OnTriggerEnter2D(Collider2D other) {
        if (!sceneLoaded && other.CompareTag("Player")) {
            sceneLoaded = true;
            SceneManager.LoadScene("MiniGame");
        }
    }

    /*private AudioSource finishSound;

    private void Start()
    {
      //  finishSound =GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "player")
        {
            //finishSound.Play();
            Invoke("completeLevel", 1f);
        }
    }

    private void completeLevel()
    {
        SceneManager.LoadScene("MiniGame");
    }*/

}
