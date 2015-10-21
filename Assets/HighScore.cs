using UnityEngine;
using System.Collections;
public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    void Awake()
    {
        // If the ApplePickerHighScore already exists, read it
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        // Assign the high score to ApplePickerHighScore
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }

    void Update()
    {
        GUIText gt = this.GetComponent<GUIText>();
        gt.text = "High Score: " + score;
        // Update ApplePickerHighScore in PlayerPrefs if necessary
        if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
    }
}