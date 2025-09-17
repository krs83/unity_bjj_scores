using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject timerSettings;
    [SerializeField] TextMeshProUGUI timer;

    public float timeStart = 120f;

    [SerializeField] bool timeRunning;
    [SerializeField] bool timeOut;
    [SerializeField] ScoresAdding scoresAdding;
    [SerializeField] ScoresAdding scoresAddingAdv;
    [SerializeField] ScoresAdding scoresAddingPenl;
    
    [SerializeField] ScoresAddingBlue scoresAddingBlue;
    [SerializeField] ScoresAddingBlue scoresAddingBlueAdv;
    [SerializeField] ScoresAddingBlue scoresAddingBluePenl;
   

    int resolutuinWidth = 1024;
    int resolutuinHeight = 768;
    int t = 60;
    float r = 255 / 255f;
    float g = 31 / 255f;
    float b = 13 / 255f;
    float a = 255 / 255f;

    string scoreR = "score red clicker";
    string advR = "adv red clicker";
    string penlR = "penl red clicker";
    string scoreB = "score blue clicker";
    string advB = "adv blue clicker";
    string penlB = "penl blue clicker";

    

    // Start is called before the first frame update
    void Start()
    {
       
        Screen.SetResolution(resolutuinWidth, resolutuinHeight, true);
        scoresAdding = GameObject.Find(scoreR).GetComponent<ScoresAdding>();
        scoresAddingAdv = GameObject.Find(advR).GetComponent<ScoresAdding>();
        scoresAddingPenl = GameObject.Find(penlR).GetComponent<ScoresAdding>();

        scoresAddingBlue = GameObject.Find(scoreB).GetComponent<ScoresAddingBlue>();
        scoresAddingBlueAdv = GameObject.Find(advB).GetComponent<ScoresAddingBlue>();
        scoresAddingBluePenl = GameObject.Find(penlB).GetComponent<ScoresAddingBlue>();


        timerSettings.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeCount();
        KeysDown();
        
    }

    void TimeCount()
    {
       
        float minutes = Mathf.Floor(timeStart / t);
        float seconds = Mathf.Floor(timeStart % t);
          

        if (timeRunning  && !timeOut)
        {
            
            timeStart -= Time.deltaTime;

            if (seconds < 10)
            {
                timer.SetText(minutes + " : " + "0" + seconds);
                    if (timeStart <= 0)
                    {
                    timeOut = true;
                    timer.SetText("0 : 00");
                    timer.color = new Color(r,g,b,a);

                }
                    else
                    {
                    timeOut = false;
                    }
            }else
            {
                timer.SetText(minutes + " : " + seconds);
            }
        }
    }

    public void ButtonOnOff()
    {
        timeRunning = !timeRunning;
        timer.color = new Color(r,r,r,a);

        if (timeRunning)
        {
            timerSettings.SetActive(false);
            if (timeOut)
            {
                timeOut = !timeOut;
                
            }           
        }
        else
        {
            timerSettings.SetActive(true);
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TimeCount();
    }

    void KeysDown()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("EXIT");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            scoresAdding.red = 0;
            scoresAdding.scoresRed.SetText("0");

            scoresAddingAdv.red = 0;
            scoresAddingAdv.scoresRed.SetText("0");

            scoresAddingPenl.red = 0;
            scoresAddingPenl.scoresRed.SetText("0");


            scoresAddingBlue.blue = 0;
            scoresAddingBlue.scoresBlue.SetText("0");

            scoresAddingBlueAdv.blue = 0;
            scoresAddingBlueAdv.scoresBlue.SetText("0");

            scoresAddingBluePenl.blue = 0;
            scoresAddingBluePenl.scoresBlue.SetText("0");

        }
    }

}
