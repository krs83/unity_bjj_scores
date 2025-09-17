using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ScoresAddingBlue : MonoBehaviour, IPointerDownHandler
{
    public TextMeshProUGUI scoresBlue;

    public int blue;
    int maxScore = 99;
    string maxScoreStr = "99";
    string minScoreStr = "0";
    int minScore = 0;


    public void OnPointerDown(PointerEventData eventData)
    {

        if (Input.GetMouseButtonDown(0))
        {
            blue++;
            scoresBlue.SetText("" + blue);
            if (blue > maxScore)
            {
                scoresBlue.SetText(maxScoreStr);
                blue = maxScore;
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {

            blue--;
            scoresBlue.SetText("" + blue);
            if (blue < minScore)
            {             
                scoresBlue.SetText(minScoreStr);
                blue = minScore;
            }
        }
    }}
