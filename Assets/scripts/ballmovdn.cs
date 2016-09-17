using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ballmovdn : MonoBehaviour {

    public Text Restarttext;
    public Text Gameovertext;
    public GameObject[] balls;
    GameObject ballup;




	void Start() {


        InvokeRepeating("repeat", 1f, 2.5f);
    }


    void repeat()
    {
        if (touchpad.gameover != 1 )
        {
            Restarttext.text = " ";
            Gameovertext.text = " ";
            Invoke("spawnballup", 1f);
        }
    }


    void spawnballup()
    {
        
        int randNo1 = Random.Range(0, 4);
        GameObject ballInitup = balls[randNo1];


        Vector3 ballposup = new Vector3(0, 8f, 0);

        ballup = (GameObject)Instantiate(ballInitup, ballposup, Quaternion.identity);
        float randforce = -5f;
       
        if(touchpad.score>10)
        {
            randforce = -6f;
        }

       else if (touchpad.score > 15)
        {
            randforce = -9f;
        }
        else if(touchpad.score > 20)
        {
            randforce = -11f;
        }
        else if(touchpad.score > 25)
        {
            randforce = -13f;
        }
        else if(touchpad.score > 30)
        {
            randforce = -15f;
        }
        else if(touchpad.score > 35)
        {
            randforce = -18f;
        }
        else if (touchpad.score > 40)
        {
            randforce = -21f;
        }
        
        ballup.GetComponent<Rigidbody>().AddForce(0, randforce-5f, 0, ForceMode.Impulse); print("ball");

    }


}


