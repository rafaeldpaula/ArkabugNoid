using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreakBehaviour : MonoBehaviour
{
    public Color[] BrickColors;
    private int BrickMaxLife;
    private int BrickLife;

    void Start()
    {
        BrickMaxLife = BrickColors.Length;
        BrickLife = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CheckBrickLifeOnCollision();
    }

    public void CheckBrickLifeOnCollision()
    {
        if (BrickLife < BrickMaxLife)
        {
            GetComponent<SpriteRenderer>().color = BrickColors[BrickLife];
            BrickLife++;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
