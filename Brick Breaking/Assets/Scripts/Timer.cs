using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 40f;

    [SerializeField] Text countdownText;
    [SerializeField] Text scoreText;
    [SerializeField] Text livesText;
    [SerializeField] Text levelText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        scoreText.text = FindObjectOfType<GameManager>().score.ToString();
        livesText.text = FindObjectOfType<GameManager>().lives.ToString();
        levelText.text = FindObjectOfType<GameManager>().level.ToString();

        if (currentTime <= 0)
        {
            currentTime = 0;
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
