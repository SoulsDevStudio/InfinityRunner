using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text timerText;
    public Text healthText;
    public GameObject gameOverPanel;

    public static GameController instance;

    Player player;
    float timerCount;
    int timerInt;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        Time.timeScale = 1;
        instance = this;
    }

    void Update()
    {
        timerCount += Time.deltaTime;
        timerInt = Mathf.RoundToInt(timerCount);
        if(timerCount <= 9)
        {
            timerText.text = "000" + timerInt.ToString();
        }
        else if (timerCount <= 99)
        {
            timerText.text = "00" + timerInt.ToString();
        }
        else if (timerCount <= 999)
        {
            timerText.text = "0" + timerInt.ToString();
        }
        else
        {
            timerText.text = timerInt.ToString();
        }

        healthText.text = "x" + player.health.ToString();
    }

    public void PlayerShooter()
    {
        player.Shooter();
    }

    public void PlayerJumping()
    {
        player.Jump();
    }

    public void ShowGameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
