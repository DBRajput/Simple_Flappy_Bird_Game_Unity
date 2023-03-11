using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public GameRestartScript gameOverScreen;
    public Rigidbody2D myRigidBody;
    public float flapPower;
    public bool birdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        // We Just Changed the Object Name
        // gameObject.name = "Champion Bird";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive == true)
        {
            myRigidBody.velocity = Vector2.up * flapPower;
        }

        if ((transform.position.x > 22 || transform.position.x < -22) || (transform.position.y > 13 || transform.position.y < -13))
        {
            Destroy(gameObject);
            gameOverScreen.RestartGameScreen();
            birdAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOverScreen.RestartGameScreen();
        birdAlive = false;
    }
}
