using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VirtualDPad : MonoBehaviour
{
    public TextMeshProUGUI directionText, touchcount;
    private Touch theTouch;
    private Vector2 touchStartPosition, touchEndPosition;
    private string direction;
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
            if(theTouch.phase == TouchPhase)
            {
                touchStartPosition = theTouch.position;
            }
            else if (theTouch.phase == TouchPhase.Moved || theTouch.phase == TouchPhase.Ended)
            {
                touchEndPosition = theTouch.position;
                float x = touchEndPosition.x - touchStartPosition.x;
                float y = touchEndPosition.y - touchStartPosition.y;
                if (Mathf.Abs(x) == 0 && Mathf.Abs(y) ==0)
                {
                    direction = "Tapped";
                }
                else if (Mathf.Abs(x) >Mathf.Abs(y)) 
                {
                    direction = x > 0 ? "Right" : "Left";
                }
                else
                {
                    direction = y > 0 ? "Up" : "Down";
                }
            }
        }
        directionText.SetText(direction);
        touchcount.SetText(Input.touchCount.ToString());
        
    }
}
