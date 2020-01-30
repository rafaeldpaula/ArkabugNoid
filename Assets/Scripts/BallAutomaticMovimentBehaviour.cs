using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAutomaticMovimentBehaviour : MonoBehaviour
{
    public float Speed;

    void Start()
    {
        GameManager.StartGame(GetComponent<Rigidbody2D>(), Speed);
    }
}
