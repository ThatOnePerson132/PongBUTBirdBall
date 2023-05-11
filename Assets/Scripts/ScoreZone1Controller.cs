using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone1Controller : MonoBehaviour
{
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        // gm = gameObject.GetComponent<GameManager>();
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            gm.player2Points++;
            StartCoroutine(gm.BallRespawn());
        }
    }
}
