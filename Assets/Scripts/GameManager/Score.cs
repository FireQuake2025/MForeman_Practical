using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static Score Instance;
    public static int HighScore;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighScoreText;
    public TextMeshProUGUI HealthText;
    private PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = FindAnyObjectByType<PlayerHealth>();
        Instance = this;
        playerHealth.Score = 0;
        HighScoreText.text = "High Score: " + HighScore;
        LoadGameState();
    }

    public void ShowScore()
    {

        if (playerHealth.Score > HighScore)
        {
            HighScore = playerHealth.Score;
            HighScoreText.text = "High Score: " + HighScore;
            SaveGameState();
        }
    }
    // Update is called once per frame
    void Update()
    {

        ScoreText.text = $"Score: {playerHealth.Score}";
        ShowScore();
        SaveGameState();

    }

    public void SaveGameState()
    {
        PlayerPrefs.SetInt("HighScore", playerHealth.Score);
    }

    public void LoadGameState()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            HighScore = 0;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
    }
}
