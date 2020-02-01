using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class charmovement : MonoBehaviour 
{	
	public AudioSource scream;
	public Vector2 speed = new Vector2(50, 50);
	float timer;
	public float setTime = 1;
	private Vector2 movement;
	//float movementSpeed = .1F;
	private int colisionCount = 0;

    //YOU SHOULD HAVE INVINCIBILITY FRAMES TO PREVENT DYING FROM SHITTY PHYSICS
	private float invincibility = 0;

    void Start()
	{
	}

	void Update()
	{
		timer -= Time.deltaTime;
		invincibility -= Time.deltaTime;
		// 3 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// 4 - Movement per direction
		movement = new Vector2(
		speed.x * inputX,
		speed.y * inputY);

        if (Input.GetKey (KeyCode.DownArrow))
		{

			// GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Random.Range (-50, 0)));
		}

		if (Input.GetKey (KeyCode.UpArrow))
		{

			// GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Random.Range (0, 50)));
		}
		
	    if (Input.GetKey (KeyCode.LeftArrow)) 
		    {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range (-25, 0), 0));
        }
	    if (Input.GetKey (KeyCode.RightArrow))
		    {

			    GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range (0, 25), 0));
		    }

		if (Input.GetKey (KeyCode.Escape))
		{
			//pause logic here
		}
		

	    if (Input.GetKey (KeyCode.S))
	    {
		
		    // GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Random.Range (-100, 0)));
	    }
	
	    if (Input.GetKey (KeyCode.W))
	    {
		
		   // GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Random.Range (0, 100)));
	    }
	
	    if (Input.GetKey (KeyCode.A)) 
	    {

		    GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range (-25, 0), 0));
	    }
	    if (Input.GetKey (KeyCode.D))
	    {
		
		    GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range (0, 25), 0));
	    }

        // stop if not pressing keys
        if (inputX == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, this.GetComponent<Rigidbody2D>().velocity.y, 0);
            this.GetComponent<Rigidbody2D>().angularVelocity = 0;
        }

        float maxVel = 10;
        if (this.GetComponent<Rigidbody2D>().velocity.x > maxVel)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(maxVel, this.GetComponent<Rigidbody2D>().velocity.y, 0);
        } else if (this.GetComponent<Rigidbody2D>().velocity.x < -1 * maxVel)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(-1 * maxVel, this.GetComponent<Rigidbody2D>().velocity.y, 0);
        }
}	
			
	void FixedUpdate()
	{

	}

	void OnCollisionEnter2D(Collision2D c)
	{

		if (c.gameObject.tag == "enemy")
        {
			if(invincibility <= 0)
			{
				colisionCount ++;
				scream.Play ();
				invincibility = 2f;
			}
					}
			if (colisionCount >= 3)
			{
			    SceneManager.LoadScene("gameover");
			    Debug.Log("You die when you collide with the wrong things enough");
		    }
	    }
    }



