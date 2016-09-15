using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class yellowcollider : MonoBehaviour {

    
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "yellow")
        {
            touchpad.score++;

            col.gameObject.SetActive(false);
        }
        else
        {
            Destroy(col.gameObject);
            touchpad.gameover = 1;
            touchpad.restart = 1;

        }
    }
       
  

    }
