using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class TimeSetting2 : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] TextMeshProUGUI timeSet2;
    public Timer timer;

    void Start()
    {
        timer = GameObject.Find("Time Clicker").GetComponent<Timer>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        
        timeSet2.SetText("2 : 00");
        timer.timeStart = 120;
    }

    

}
