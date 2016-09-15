using UnityEngine;
using System.Collections;

public class tealcollider : MonoBehaviour {

	//public GameObject ball;
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "teal") {
			print("active");
			col.gameObject.SetActive (false);

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
