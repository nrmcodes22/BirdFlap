using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMiddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript logic;
    public AudioSource point;
    void Start()
    {
        
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.layer==3)
        {
            point.Play();
            point.mute=false;
            logic.addScore(1);
        }
        else
        {
            point.mute=true;
        }
        
    }
}
