using UnityEngine;
using System.Collections;

public class Globals : MonoBehaviour
{

    public static int score = 0;
    public static int lives = 5;
    public static float startTime;
    private static bool gameEnd = false;

    void Startup() {
        startTime = Time.time;
    }

    public static void decrementLives()
    {
        lives--;

        if (lives <= 0)
            gameEnd = true;
    }

    public static void incrementScore()
    {
        score += 100;
    }

    void reset()
    {
        score = 0;
        lives = 5;
        startTime = Time.time;

        GameObject[] gameObjects =  GameObject.FindGameObjectsWithTag ("Skier");
        for(var i = 0 ; i < gameObjects.Length ; i ++)
            Destroy(gameObjects[i]);
    }

    void OnGUI ()
    {
        if (gameEnd) {
            int buttonWidth = 100;
            int buttonHeight = 50;
            float halfScreenWidth = Screen.width / 2;
            float halfButtonWidth = buttonWidth / 2;
            
            GUI.Label (new Rect (halfScreenWidth - 100, 320, 200, buttonHeight), "Oh no, you ran out of lives! \n Your score is " + score);
            
            if (GUI.Button (new Rect (halfScreenWidth - halfButtonWidth, 370, buttonWidth, buttonHeight), "Restart")) {
                gameEnd = false;
                reset();
            }
        }
    }
}
