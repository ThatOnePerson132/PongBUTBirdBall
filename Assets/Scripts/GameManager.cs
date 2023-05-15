using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float player1Points;
    public TMP_Text player1PointsScore;
    public ScoreZone1Controller SZ1;

    public float player2Points;
    public TMP_Text player2PointsScore;
    public ScoreZone2Controller SZ2;

    public GameObject Ball;
    public GameObject ballSpawner;
   // public GameObject Chuck;
   // public GameObject ChuckSpawner;

    // Start is called before the first frame update
    void Start()
    {
        SZ1 = gameObject.GetComponent<ScoreZone1Controller>();
        player1Points = 0;
        SZ2 = gameObject.GetComponent<ScoreZone2Controller>();
        player2Points = 0;


    }

    // Update is called once per frame
    void Update()
    {
        player1PointsScore.SetText("P1Points: " + player1Points);
        player2PointsScore.SetText("P2Points: " + player2Points);
    }

    public IEnumerator BallRespawn()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(Ball, ballSpawner.transform.position, ballSpawner.transform.rotation);
       // Instantiate(Chuck, ChuckSpawner.transform.position, ChuckSpawner.transform.rotation);
    }

    public void RespawnBall()
    {
       // GameObject currentChuck = GameObject.FindGameObjectWithTag("Chuck").gameObject;
        GameObject currentBall = GameObject.FindObjectOfType<Ball>().gameObject;
        Destroy(currentBall);
        //Destroy(currentChuck);
        Instantiate(Ball, ballSpawner.transform.position, ballSpawner.transform.rotation);
        //Instantiate(Chuck, ChuckSpawner.transform.position, ChuckSpawner.transform.rotation);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("PINGPONG");
    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void Winnerscene() 
    { 
      if (player1Points == 10)
      {
         SceneManager.LoadScene("Player1WinScreen");
      }

      if (player2Points == 10)
      {
         SceneManager.LoadScene("Player2WinScreen");
      }

    }


}
