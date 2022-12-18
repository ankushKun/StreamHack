using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class scoreManager : MonoBehaviour
{
    private int score = 0;
    private int energy = 100;

    public int increment = 1;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI energyText;

    private String scoreTextStr = "Score   : ";
    private String energyTextStr = "Energy : ";

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreTextStr + score;
        energyText.text = energyTextStr + energy;
    }

    public void incrementScore()
    {
        score += increment;
        scoreText.text = scoreTextStr + score;
    }

    public void incrementEnergy()
    {
        energy += increment;
        energyText.text = energyTextStr + energy;
    }

    public void decrementEnergy()
    {
        energy -= 10;
        energyText.text = energyTextStr + energy;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
