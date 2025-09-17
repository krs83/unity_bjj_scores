using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HotKeyScript : MonoBehaviour
{
    public TextMeshProUGUI scoresBlue;
    public TextMeshProUGUI advBlue;

    public int blue;
    public int red;
    int maxScore = 99;
    string maxScoreStr = "99";
    string minScoreStr = "0";
    int minScore = 0;

    public void clickerScore()
    {
        blue++;
        scoresBlue.SetText("" + blue);
        if (blue > maxScore)
        {

            scoresBlue.SetText(maxScoreStr);
            blue = maxScore;
        }
    }

    void clickerScoreNeg()
    {
        blue--;
        scoresBlue.SetText("" + blue);
        if (blue < minScore)
        {

            scoresBlue.SetText(minScoreStr);
            blue = minScore;
        }
    }

    public void clickerAdv()
    {
        blue++;
        advBlue.SetText("" + blue);
        if (blue > maxScore)
        {

            advBlue.SetText(maxScoreStr);
            blue = maxScore;
        }
    }

    void clickerAdvNeg()
    {
        blue--;
        advBlue.SetText("" + blue);
        if (blue < minScore)
        {

            advBlue.SetText(minScoreStr);
            blue = minScore;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        advBlue = GameObject.Find("adv blue clicker").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        KeysClicker();
    }
    void KeysClicker()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            clickerScore();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            clickerScoreNeg();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            clickerAdv();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            clickerAdvNeg();
        }
    }

    
}
