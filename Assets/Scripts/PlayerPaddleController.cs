using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
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
        vertInput = Input.GetAxis("Vertical"); 
        transform.Translate(Vector2.up * speed * vertInput * Time.deltaTime);
    }
}
