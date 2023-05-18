using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videoplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer; // Reference to the Video Player component
    public string nextSceneName; // Name of the scene to load after the video

    private bool videoStarted = false;

    private void Update()
    {
        if (!videoStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                videoPlayer.Play();
                videoStarted = true;
            }
        }
        else
        {
            if (!videoPlayer.isPlaying)
            {
                StartGame();
            }
        }
    }

    private void StartGame()
    {
        // Load the next scene or perform other actions to start the game
        SceneManager.LoadScene(nextSceneName);
    }

}
