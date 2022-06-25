using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public GameObject GoalP1, GoalP2, GoalP3, GoalP4;

    bool P1 = true, P2 = true, P3 = true, P4 = true;

    private int reminderPlayer = 4;

    public int winner;


    public GameObject winnerCanvas;

    private void Update()
    {
        if (reminderPlayer == 1)
        {
            if (P1)
            {
                winner = 1;
            }
            if (P2)
            {
                winner = 2;
            }
            if (P3)
            {
                winner = 3;
            }
            if (P4)
            {
                winner = 4;
            }
            //GameOver
            winnerCanvas.SetActive(true);
        }
    }

    public void setLoseP1()
    {
        GoalP1.GetComponent<MeshRenderer>().enabled = true;
        GoalP1.GetComponent<Collider>().isTrigger = false;
        reminderPlayer--;
        P1 = false;
    }

    public void setLoseP2()
    {
        GoalP2.GetComponent<MeshRenderer>().enabled = true;
        GoalP2.GetComponent<Collider>().isTrigger = false;
        reminderPlayer--;
        P2 = false;
    }

    public void setLoseP3()
    {
        GoalP3.GetComponent<MeshRenderer>().enabled = true;
        GoalP3.GetComponent<Collider>().isTrigger = false;
        reminderPlayer--;
        P3 = false;
    }

    public void setLoseP4()
    {
        GoalP4.GetComponent<MeshRenderer>().enabled = true;
        GoalP4.GetComponent<Collider>().isTrigger = false;
        reminderPlayer--;
        P4 = false;
    }

    public void resetGoal()
    {
        reminderPlayer = 4;
        GoalP1.GetComponent<MeshRenderer>().enabled = false;
        GoalP1.GetComponent<Collider>().isTrigger = true;
        P1 = true;

        GoalP2.GetComponent<MeshRenderer>().enabled = false;
        GoalP2.GetComponent<Collider>().isTrigger = true;
        P2 = true;

        GoalP3.GetComponent<MeshRenderer>().enabled = false;
        GoalP3.GetComponent<Collider>().isTrigger = true;
        P3 = true;

        GoalP4.GetComponent<MeshRenderer>().enabled = false;
        GoalP4.GetComponent<Collider>().isTrigger = true;
        P4 = true;

        winnerCanvas.SetActive(false);
    }
}
