using UnityEngine;

public class LetterPiece : MonoBehaviour
{
    public string letter;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.AddLetterToAnswer(letter);
        Debug.Log("Clicked");
    }
}

