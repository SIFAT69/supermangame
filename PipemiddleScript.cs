using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipemiddleScript : MonoBehaviour
{
    public ScoreCountScript logic;
    public birdscript birdlogic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreCountScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.layer == 3 && birdlogic.birdIsAlive) {
           logic.addScore(1);
        }
    }
}
