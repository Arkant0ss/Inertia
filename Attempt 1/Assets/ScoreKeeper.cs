using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ScoreKeeper : NetworkBehaviour
{
    //[SyncVar]
    //public float score1;
    //[SyncVar]
    //public float score2;

    public static float score1;
    public static float score2;

    private Text textscore1;
    private Text textscore2;

    private void Start()
    {
        textscore1 = GameObject.Find("TextScore1").GetComponent<Text>();
        textscore2 = GameObject.Find("TextScore2").GetComponent<Text>();
    }
    private void Update()
    {
        CmdAdjustScore1();
        CmdAdjustScore2();
        textscore1.text = score1.ToString();
        textscore2.text = score2.ToString();

    }

    [Command]
    void CmdAdjustScore1()
    {
        //score1 += 1;
        textscore1.text = score1.ToString();
        //Debug.Log(score1);
    }
    [Command]
    void CmdAdjustScore2()
    {
        //score2 += 1;
        textscore2.text = score2.ToString();
        Debug.Log(score2);
    }
}
