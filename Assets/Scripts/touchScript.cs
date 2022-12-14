using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class touchScript : MonoBehaviour
{
    public TextMeshProUGUI phaseDisplayText;
    private Touch theTouch;
    private float timeTouchEnded;
    private float displayTime = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            phaseDisplayText.SetText(theTouch.phase.ToString());
            if(theTouch.phase == TouchPhase.Ended)
            {
                timeTouchEnded = Time.time;
            }
        }
        else if(Time.time - timeTouchEnded>displayTime)
        {
            phaseDisplayText.SetText("No events");
        }
       
    }
}
