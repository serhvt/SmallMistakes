using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    private int pointsToWin = 2;
    private int currentPoints;
    public GameObject nextButton;

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            pointsToWin += 4;
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            pointsToWin += 3;
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            pointsToWin += 3;
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            pointsToWin += 2;
        }

    }
    void Update()
    {
        
        if (currentPoints >= pointsToWin)
        {
            // WIN
            nextButton.SetActive(true);
            Debug.Log("win");
        }
    }

    public void AddPoints()
    {
        currentPoints++;
        
    }
}