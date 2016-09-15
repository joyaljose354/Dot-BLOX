using UnityEngine;
using System.Collections;

public class pinkcollider : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "pink")
        {
            print("pinkactive");
            col.gameObject.SetActive(false);

           touchpad.score++;

        }
        else
        {
            Destroy(col.gameObject);
            touchpad.gameover = 1;
            touchpad.restart = 1;
        }

    }
}
