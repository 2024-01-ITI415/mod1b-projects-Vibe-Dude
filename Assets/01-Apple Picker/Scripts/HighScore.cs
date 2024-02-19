using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class HighScore : MonoBehaviour
{
    static public int score = 1000;
    private TextMeshProUGUI text;
    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
      // If the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("HighScore"))
        { 
            score = PlayerPrefs.GetInt("HighScore");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("HighScore", score);
    }
    void Update()
    { 
        //Text gt = this.GetComponent<Text>();
        text.SetText("High Score: " + score);
        // Update the PlayerPrefs HighScore if necessary
        if (score > PlayerPrefs.GetInt("HighScore"))
        { // d
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
