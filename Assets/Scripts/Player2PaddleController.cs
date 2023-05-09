using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2PaddleController : MonoBehaviour
{
    public float vertInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertInput = Input.GetAxis("VerticalP2"); 
        transform.Translate(Vector2.up * speed * vertInput * Time.deltaTime);
    }
}
