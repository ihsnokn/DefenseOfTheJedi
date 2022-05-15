using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endgame : MonoBehaviour
{

    [SerializeField] Text scoreText;

    void Update()
    {
        scoreText.text = FindObjectOfType<GameManager>().score.ToString();
    }
}
