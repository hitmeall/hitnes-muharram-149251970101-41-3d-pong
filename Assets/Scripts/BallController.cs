using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;

    private Rigidbody rig;

    public float maxSpeed = 10.0f;

    public Collider goalP1, goalP2, goalP3, goalP4;
    public SpawnerController manager;
    public ScoreManager managerScore;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == goalP1)
        {
            managerScore.AddP1Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == goalP2)
        {
            managerScore.AddP2Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == goalP3)
        {
            managerScore.AddP3Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == goalP4)
        {
            managerScore.AddP4Score(1);
            manager.RemoveBall(gameObject);
        }
    }
}
