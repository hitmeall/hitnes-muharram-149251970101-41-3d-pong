using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinningController : MonoBehaviour
{
    public GoalManager goalManager;
    public List<PaddleController> paddlePlayers;
    public ScoreManager scoreManager;
    public SpawnerController spawnerController;
    public Text WinnerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        SetWinnerText("P" + goalManager.winner + " Win");
    }

    private void SetWinnerText(string text)
    {
        WinnerText.text = text;
    }

    public void replayGame()
    {
        goalManager.resetGoal();
        for (int i = 0; i < 4; i++)
        {
            paddlePlayers[i].activatePlayer();
        }
        scoreManager.resetScore();
        spawnerController.RemoveAllBall();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
