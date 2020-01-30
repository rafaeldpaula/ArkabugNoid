using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovimentBehaviour : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
            currentPosition.x += Speed;
        else if (Input.GetKey(KeyCode.LeftArrow))
            currentPosition.x -= Speed;

        GetComponent<Rigidbody2D>().MovePosition(currentPosition);
    }
}
