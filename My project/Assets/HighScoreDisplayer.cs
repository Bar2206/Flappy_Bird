using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreDisplayer : MonoBehaviour
{
    public LeaderBoard leaderBoard;
    public TMPro.TMP_Text text;

    private void OnEnable()
    {

        text.text = "";
        int counter = 1;
        foreach (var item in leaderBoard.array)
        {

            
            text.text += $"{counter}:{item}\n";
            counter++;
        }

    }

}
