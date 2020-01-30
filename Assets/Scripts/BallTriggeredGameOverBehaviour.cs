using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallTriggeredGameOverBehaviour : MonoBehaviour
{
    public GameObject Ball;
    public int LifesBeforeEndTheGame;
    private int LifeCount;

    private void Start()
    {
        LifeCount = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (LifeCount >= LifesBeforeEndTheGame)
        {
            GameManager.RestartAfterGameOver();
            LifeCount = 0;
        }
        else
        {
            LifeCount++;
            Ball.transform.position = Vector2.zero;
            GameManager.StartGame(Ball.GetComponent<Rigidbody2D>(), Ball.GetComponent<BallAutomaticMovimentBehaviour>().Speed);
        }
    }
}
