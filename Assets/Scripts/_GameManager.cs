using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _GameManager : MonoBehaviour
{
    #region Singleton
    public static _GameManager gameManager;

    void Awake()
    {
        gameManager = this;
    }
    #endregion

    public _SpawnEnemies _spawner;
    public GameObject _player;
    public _ScoreController _ScoreManager;

    public GameObject GameOverPanel;

    public void Start()
    {
        GameOverPanel.SetActive(false);
        _spawner.GenerateFork(_player.transform.position);
    }

    void Update()
    {
        if(_player.GetComponent<_PlayerController>().isDead == true) GameOver();
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        _player.GetComponent<_PlayerController>().enabled = false;
        _spawner.enabled = false;
        _ScoreManager.enabled = false;

    }

    public void Pause()
    {
        if(Time.timeScale == 1)
            Time.timeScale = 0;
        else Time.timeScale = 1;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
