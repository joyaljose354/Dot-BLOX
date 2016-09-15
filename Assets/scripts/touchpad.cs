using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class touchpad : MonoBehaviour
{
    public Text scoretext;
    public static int score = 0;
    public Text Restarttext;
    public Text Gameovertext;
    public static int  restart;
    public static int gameover;
    public Vector3 rotation;
    public Space space;

    void start()
    {
        gameover = 0;
        restart = 0;
        Gameovertext.text = " ";
        Restarttext.text = " ";
     }

    public GameObject square;
    void OnMouseDown()
    {
        square.GetComponent<Rigidbody>().transform.Rotate(0, 0, 90);
    }
    void Update()

    {
        scoretext.text = score.ToString();
        if(gameover == 1)
        {
            restart = 1;
            score = 0;
            Gameovertext.text = "GAME OVER";
        }
        if (restart == 1)
        {
            Restarttext.text = "Restart";
        }
    }
    }
