using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    //public Animator animator;

    private void Start()
    {
        finishSound =GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "player")
        {
            finishSound.Play();
            //StartCoroutine(AnimateAfterDelay());
            Invoke("completeLevel", 2f);
        }
    }
    /*
    IEnumerator AnimateAfterDelay() 
    {
        yield return new WaitForSeconds(2f);
        animator.SetTrigger("TriggerName");
    }
    */
    private void completeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
