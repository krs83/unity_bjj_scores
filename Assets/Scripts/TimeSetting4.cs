using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class TimeSetting4 : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] TextMeshProUGUI timeSet4;
    public Timer timer;

    void Start()
    {
        timer = GameObject.Find("Time Clicker").GetComponent<Timer>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        
        timeSet4.SetText("4 : 00");
        timer.timeStart = 240;
       
    }
}
