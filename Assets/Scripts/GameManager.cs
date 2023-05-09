using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float p1s = 0;
    public float player1Points;
    public TMP_Text player1PointsScore;
    public ScoreZone1Controller SZ1;    

    public float p2s = 0;
    public float player2Points;
    public TMP_Text player2PointsScore;
    public ScoreZone2Controller SZ2;

    public GameObject Ball;
    public GameObject ballSpawner;

    // Start is called before the first frame update
    void Start()
    {
        SZ1 = gameObject.GetComponent<ScoreZone1Controller>();
        player1Points = p1s; 
        SZ2 = gameObject.GetComponent<ScoreZone2Controller>();
        player2Points = p2s;

        player1PointsScore.SetText("P1Points: " + player1Points);
        player2PointsScore.SetText("P2Points: " + player2Points);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator BallRespawn()
    {
       yield return new WaitForSeconds(1.5f);
        Instantiate(Ball, ballSpawner.transform.position, ballSpawner.transform.rotation);
    }
}
