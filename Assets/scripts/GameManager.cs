using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text answerText;
    public string targetWord;
    public GameObject gameOverPanel;

    private string answer;

    private void Start()
    {
        answer = "";
        answerText.text = "";
    }

    public void AddLetterToAnswer(string letter)
    {
        answer += letter;
        answerText.text = answer;

        if (answer == targetWord)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
}


