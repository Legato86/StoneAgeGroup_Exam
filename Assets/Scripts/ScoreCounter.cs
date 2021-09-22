// https://docs.unity3d.com/ScriptReference/PlayerPrefs.html


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameData gameData;
    [SerializeField] private Image imageHunger; 


    void Start() 
    {
        scoreText.text = gameData.Score.ToString();
        gameData.Hunger = 1f;
    }

    private void FixedUpdate()
    {
        gameData.Hunger -= Time.deltaTime * gameData.hungerSpeed;
        imageHunger.fillAmount = gameData.Hunger;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            CountScore();
            Destroy(collision.gameObject);
        }
    }


    private void CountScore()
    {
        gameData.Score += 10;
        scoreText.text = gameData.Score.ToString();
        CheckWin();
    }

    private void CheckWin()
    {
        if ((gameData.Score % 100) == 0) 
        {
            if (SceneManager.GetActiveScene().buildIndex == gameData.OpenLevels)
            {
                gameData.OpenLevels++;   
            }
            gameData.SaveData();
            Debug.Log("YOU WIN!!!");
            SceneManager.LoadScene(0); 
        }
    }
}


