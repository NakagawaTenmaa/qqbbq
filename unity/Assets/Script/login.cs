using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class login : MonoBehaviour
{
    public GameObject ID;
    public GameObject PS;
    int i;

    public Vector2 SPEED = new Vector2(0.05f, 0.05f);
    // Start is called before the first frame update
    void Start()
    {
        i = 190;
    }

    // Update is called once per frame
    void Update()
    {
        i--;


        Vector2 Position = transform.position;
        Position.y += SPEED.y;
        transform.position = Position;

        if(i==0)
        {
            SPEED.y = 0;
        }
    }
}
