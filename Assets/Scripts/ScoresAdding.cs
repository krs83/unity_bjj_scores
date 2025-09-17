using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ScoresAdding : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI scoresRed;
    
    public int red;
    public int blue;
    int maxScore = 99;
    string maxScoreStr = "99";
    string minScoreStr = "0";
    int minScore = 0;

    public void OnPointerClick(PointerEventData eventData)
    {

        if (eventData.pointerId == -1)
        {
            red++;
            scoresRed.SetText("" + red);
            if (red > maxScore)
            {
                scoresRed.SetText(maxScoreStr);
                red = maxScore;
            }
        }
        else if (eventData.pointerId == -2)
        {
            red--;
            scoresRed.SetText("" + red);
            if (red < minScore)
            {
                scoresRed.SetText(minScoreStr);
                red = minScore;
            }
        }
    }

}
