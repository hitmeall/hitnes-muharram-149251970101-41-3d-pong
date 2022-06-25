using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool isP1, isP2, isP3, isP4;
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            if (isP1)
            {
                scoreManager.AddP1Score(1);
            }
            if (isP2)
            {
                scoreManager.AddP2Score(1);
            }
            if (isP3)
            {
                scoreManager.AddP3Score(1);
            }
            if (isP4)
            {
                scoreManager.AddP4Score(1);
            }
        }
    }
}
