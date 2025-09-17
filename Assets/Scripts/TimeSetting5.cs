using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class TimeSetting5 : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] TextMeshProUGUI timeSet5;
    [SerializeField] Timer timer;


    void Start()
    {
        timer = GameObject.Find("Time Clicker").GetComponent<Timer>();
    }
      
    public void OnPointerDown(PointerEventData eventData)
    {
        
        timeSet5.SetText("5 : 00");
        timer.timeStart = 300;
    }

    

}
