using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager_DC : MonoBehaviour
{
    // Start is called before the first frame update
    private int lives = 5;
    private int score = 0;
    public string scoreKey = "scoreKey";
    private int highScore;
    public string highScoreKey = "highScoreKey";

    void Start()
    {
        if (PlayerPrefs.HasKey(highScoreKey))
        {
            Debug.Log("High score: " + highScoreKey);
        }
        else
        {
            Debug.Log("HIGH SCORE SET");
            PlayerPrefs.SetInt(highScoreKey, 0);
        }
        if (PlayerPrefs.HasKey(scoreKey))
        {
            Debug.Log("High score: " + scoreKey);
            PlayerPrefs.SetInt(scoreKey, 0);
        }
        else
        {
            Debug.Log("HIGH SCORE SET");
            PlayerPrefs.SetInt(scoreKey, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShotByBullet()
    {
        lives--;
        if (lives<=0)
        {
            PlayerPrefs.SetInt(scoreKey, score);
            if (score > PlayerPrefs.GetInt(highScoreKey))
            {
                PlayerPrefs.SetInt(highScoreKey, score);
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
