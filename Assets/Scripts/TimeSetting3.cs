using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class TimeSetting3 : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] TextMeshProUGUI timeSet3;
    public Timer timer;

    void Start()
    {
        timer = GameObject.Find("Time Clicker").GetComponent<Timer>();
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        
        timeSet3.SetText("3 : 00");
        timer.timeStart = 180;
        
    }

    

}
