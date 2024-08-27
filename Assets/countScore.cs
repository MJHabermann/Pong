using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class countScore : MonoBehaviour
{
    public TMP_Text P1text;
    public TMP_Text P2text;
    public GameObject ball;
    // Start is called before the first frame update
    public int P1Score = 0;
    public int P2Score = 0;
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 10f)
        {
            P2Score++;
        }
        else if (ball.transform.position.x <= -10f)
        {
            P1Score++;
        }
        P1text.SetText(P1Score.ToString());
        P2text.SetText(P2Score.ToString());
    }
}
