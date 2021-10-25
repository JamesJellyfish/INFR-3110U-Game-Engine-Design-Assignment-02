using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateDesignPattern : MonoBehaviour
{
    public enum playerstate{
        Cube,
        Rectangle,
        LongerRectangle,
    }
    public GameObject player;
    private playerstate currentstate;

    // Start is called before the first frame update
    void Start()
    {
        currentstate = playerstate.Cube;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            currentstate = playerstate.Cube;
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentstate = playerstate.Rectangle;
        }
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            currentstate = playerstate.LongerRectangle;
        }

        switch (currentstate)
        {
            case playerstate.Cube:
                player.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                break;
            case playerstate.Rectangle:
                player.transform.localScale = new Vector3(1.0f, 2.0f, 1.0f);
                break;
            case playerstate.LongerRectangle:
                player.transform.localScale = new Vector3(1.0f, 3.0f, 1.0f);
                break;
        }
    }
}
