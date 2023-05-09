using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone1Controller : MonoBehaviour
{
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        gm.p2s++;
        StartCoroutine(gm.BallRespawn());
    }
}
