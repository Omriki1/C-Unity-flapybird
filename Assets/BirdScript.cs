using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public LogicMangScript logic;
    public bool BirdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicMangScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapstrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BirdIsAlive = false;
    }
}
