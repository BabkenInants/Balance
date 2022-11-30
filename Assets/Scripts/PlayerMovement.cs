using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	
	public Rigidbody rb;

	public float sidewaysForce = 100f;
	public float sidewaysForceForJoystick = 5f;
	public GameObject GameManager;
	public Joystick Joystick;

	private float MoveInput;




	
	void FixedUpdate ()
	{
		
		//WASD
		//"d"
		if (Input.GetKey("d"))
		{
			
			rb.AddForce(0, 0, sidewaysForce * Time.deltaTime );
		}

		//"a"
		if (Input.GetKey("a"))  
		{
			
			rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime );
		}

		//"w"
		if (Input.GetKey("w"))
        {
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

		//"s"
		if (Input.GetKey("s"))
        {
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
		

		//Arrows
		//arrow right
		if (Input.GetKey("right"))
		{
			
			rb.AddForce(0, 0, sidewaysForce * Time.deltaTime );
		}

		//arrow left
		if (Input.GetKey("left"))  
		{
			
			rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime );
		}

		//arrow up
		if (Input.GetKey("up"))
        {
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

		//arrow down
		if (Input.GetKey("down"))
        {
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

		
		


		//Joystick

		float moveHorizontal = Joystick.Vertical;//horizontal move
		float moveVertical = Joystick.Horizontal; //vertical move

		Vector3 movement = new Vector3(-moveHorizontal, 0.0f, moveVertical); //movement
		rb.AddForce(movement * sidewaysForceForJoystick); //made ball to move


		//Lose

		if (rb.position.y < -20f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}




	}

	void Start()
	{

		// Decides how to load Level13
		if (PlayerPrefs.GetInt("Level13Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 14)
		{
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;
		}

		if (PlayerPrefs.GetInt("Level13Checkpoint") == 0 && SceneManager.GetActiveScene().buildIndex == 14)
		{
			Vector3 position = transform.position;
			position.x = 0f;
			position.y = 1f;
			position.z = 0f;
			transform.position = position;
		}
		
		//Desides how to load Level14
		if (PlayerPrefs.GetInt("Level14Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 15)
		{
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;
		}

		if (PlayerPrefs.GetInt("Level14Checkpoint") == 0 && SceneManager.GetActiveScene().buildIndex == 15)
		{
			Vector3 position = transform.position;
			position.x = 0f;
			position.y = 1f;
			position.z = 0f;
			transform.position = position;
		}


		//Desides how to load Level15
		if (PlayerPrefs.GetInt("Level15Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 16)
		{
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;
		}		

		if (PlayerPrefs.GetInt("Level15Checkpoint") == 0 && SceneManager.GetActiveScene().buildIndex == 16)
		{
			Vector3 position = transform.position;
			position.x = 0f;
			position.y = 1f;
			position.z = 0f;
			transform.position = position;
		}

		//Desides how to load level16
		if (PlayerPrefs.GetInt("Level16Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 17)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;
        }

		if (PlayerPrefs.GetInt("Level16Checkpoint") == 0 && SceneManager.GetActiveScene().buildIndex == 17)
        {
			Vector3 position = transform.position;
			position.x = 0f;
			position.y = 1f;
			position.z = 0f;
			transform.position = position;
		}
		
		//Desides how to load level17
		if (PlayerPrefs.GetInt("Level17Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 18)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;
        }

		if (PlayerPrefs.GetInt("Level17Checkpoint") == 0 && SceneManager.GetActiveScene().buildIndex == 18)
        {
			Vector3 position = transform.position;
			position.x = 0f;
			position.y = 1f;
			position.z = 0f;
			transform.position = position;
		}
		
		//Desides how to load level18
		if (PlayerPrefs.GetInt("Level18Checkpoint") == 1 && PlayerPrefs.GetInt("Level18Checkpoint2") == 0 && SceneManager.GetActiveScene().buildIndex == 19)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;
        }

		if (PlayerPrefs.GetInt("Level18Checkpoint") == 0 && SceneManager.GetActiveScene().buildIndex == 19)
        {
			Vector3 position = transform.position;
			position.x = 0f;
			position.y = 1f;
			position.z = 0f;
			transform.position = position;
		}

		if (PlayerPrefs.GetInt("Level18Checkpoint2") == 1 && PlayerPrefs.GetInt("Level18Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 19)
        {
			Vector3 position = transform.position;
			position.x = 30f;
			position.y = 0f;
			position.z = 80f;
			transform.position = position;
		}
		
		//Desides how to load level19
		if (PlayerPrefs.GetInt("Level19Checkpoint") == 1 && PlayerPrefs.GetInt("Level19Checkpoint2") == 0 && SceneManager.GetActiveScene().buildIndex == 20)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;
        }

		if (PlayerPrefs.GetInt("Level19Checkpoint") == 0 && SceneManager.GetActiveScene().buildIndex == 20)
        {
			Vector3 position = transform.position;
			position.x = 0f;
			position.y = 1f;
			position.z = 0f;
			transform.position = position;
		}

		if (PlayerPrefs.GetInt("Level19Checkpoint2") == 1 && PlayerPrefs.GetInt("Level19Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 20)
        {
			Vector3 position = transform.position;
			position.x = 30f;
			position.y = 0f;
			position.z = 80f;
			transform.position = position;
		}
		
		//Desides how to load level20
		if (PlayerPrefs.GetInt("Level20Checkpoint") == 1 && PlayerPrefs.GetInt("Level20Checkpoint2") == 0 && SceneManager.GetActiveScene().buildIndex == 21)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;
        }

		if (PlayerPrefs.GetInt("Level20Checkpoint") == 0 && SceneManager.GetActiveScene().buildIndex == 21)
        {
			Vector3 position = transform.position;
			position.x = 0f;
			position.y = 1f;
			position.z = 0f;
			transform.position = position;
		}

		if (PlayerPrefs.GetInt("Level20Checkpoint2") == 1 && PlayerPrefs.GetInt("Level20Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 21)
        {
			Vector3 position = transform.position;
			position.x = 30f;
			position.y = 0f;
			position.z = 80f;
			transform.position = position;
		}





	}
}

