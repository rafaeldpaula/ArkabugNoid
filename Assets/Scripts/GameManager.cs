using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static void RestartAfterGameOver()
    {
        SceneManager.LoadScene("Scenes/MainGameScene", LoadSceneMode.Single);
    }

    public static void StartGame(Rigidbody2D rigidbody2D, float speed)
    {
        var result = Random.Range(1, 20);
        var initialVector = result <= 10 ? Vector2.left : Vector2.right;

        rigidbody2D.velocity = (Vector2.up + initialVector) * speed;
    }
}
