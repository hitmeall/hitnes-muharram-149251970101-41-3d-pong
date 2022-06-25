using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int P1Score, P2Score, P3Score, P4Score;
    public PaddleController P1, P2, P3, P4;

    public int maxScore = 15;

    public BallController ball;
    public GoalManager goalManager;

    public void AddP1Score(int increment)
    {
        P1Score += increment;
        if (P1Score == maxScore)
        {
            goalManager.setLoseP1();
            P1.deactivatePlayer();
        }
    }

    public void AddP2Score(int increment)
    {
        P2Score += increment;
        if (P2Score == maxScore)
        {
            goalManager.setLoseP2();
            P2.deactivatePlayer();
        }
    }

    public void AddP3Score(int increment)
    {
        P3Score += increment;
        if (P3Score == maxScore)
        {
            goalManager.setLoseP3();
            P3.deactivatePlayer();
        }
    }

    public void AddP4Score(int increment)
    {
        P4Score += increment;
        if (P4Score == maxScore)
        {
            goalManager.setLoseP4();
            P4.deactivatePlayer();
        }
    }

    public void resetScore()
    {
        P1Score = 0;
        P2Score = 0;
        P3Score = 0;
        P4Score = 0;
    }
}
