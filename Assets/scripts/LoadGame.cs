using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;


public class LoadGame : MonoBehaviour
{
    // Path to the saved game file
    private string filePath = "savegame.dat";

    // Load the saved game data and apply it to the game
    public void LoadGameData()
    {
        // Check if the save file exists
        if (File.Exists(filePath))
        {
            // Open the save file and deserialize the data
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(filePath, FileMode.Open);
            GameData data = (GameData)formatter.Deserialize(file);
            file.Close();

            // Apply the loaded data to the game
            // For example, set player position and score
            PlayerController player = FindObjectOfType<PlayerController>();
            player.transform.position = data.playerPosition;
            ScoreManager.score = data.score;

            Debug.Log("Game loaded successfully!");
        }
        else
        {
            Debug.Log("No saved game found.");
        }
    }
}
