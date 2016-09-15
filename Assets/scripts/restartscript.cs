using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class restartscript : MonoBehaviour {
    public Text Restarttext;
    
    void OnMouseDown()
    {
        if(touchpad.restart ==1)
        {
            //Restarttext.text = " ";
            touchpad.gameover = 0;
            touchpad.restart = 0;
           
        }
        
    }


}
