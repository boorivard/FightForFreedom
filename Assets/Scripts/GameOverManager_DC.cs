using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager_DC : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreCard;
    public TMP_Text highScoreCard;
    public string limiter = "oldHighScore";
    private int score;
    private int limit;
    void Start()
    {
        if (PlayerPrefs.HasKey(limiter))
        {
            Debug.Log("Old SCORE SET");
        }

        else
        {
            Debug.Log("Setting up");
            PlayerPrefs.SetInt(limiter, 0);
        }

        score = PlayerPrefs.GetInt("scoreKey");
        limit = PlayerPrefs.GetInt(limiter);
        scoreCard.text = "Score: " + score.ToString();
        if (score > limit)
        {
            highScoreCard.text = "New High Score: " + score.ToString();
            PlayerPrefs.SetInt(limiter, score);
        }
        else
        {
            highScoreCard.text = "High Score: " + limit.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Splash");
        }
    }
}
