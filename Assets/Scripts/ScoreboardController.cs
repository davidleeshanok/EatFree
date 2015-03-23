using UnityEngine;
using System.Collections;

public class ScoreboardController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        guiText.text = "Score: " + Globals.score + "\nLives: " + Globals.lives;
    }
}
