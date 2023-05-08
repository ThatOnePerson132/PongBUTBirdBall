using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZoneController : MonoBehaviour
{
    public Collider2D cd;

    // Start is called before the first frame update
    void Start()
    {
        cd = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
