using UnityEngine;
using System.Collections;

public class purplecollider : MonoBehaviour {
	
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "purple")
        {
            print("puractive");
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
