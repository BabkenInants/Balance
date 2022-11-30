using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

	public PlayerMovement movement;     
	private Transform PlayerTransform;
	

	private int Level13 = 1;
	private int Level13Complete = 0;	

	private int Level14 = 1;
	private int Level14Complete = 0;

	private int Level15 = 1;
	private int Level15Complete = 0;

	private int Level16 = 1;
	private int Level16Complete = 0;

	private int Level17 = 1;
	private int Level17Complete = 0;
	
	private int Level18 = 1;
	private int Level18_2ndCheckpoint = 1;
	private int Level18Complete = 0;
	
	private int Level19 = 1;
	private int Level19_2ndCheckpoint = 1;
	private int Level19Complete = 0;
	
	private int Level20 = 1;
	private int Level20_2ndCheckpoint = 1;
	private int Level20Complete = 0;

	private int BoolTrue = 1;


	void OnCollisionEnter(Collision collisionInfo)
	{
	

		//bardzracnum enq Player's Speed if Player collides Platform with tag Speed++
		if (collisionInfo.collider.tag == "Speed++")
		{
			movement.sidewaysForce = 300f;

		}

		//Catsracnum enq Player's Speed if Player collides Platform with tag Speed--
		if (collisionInfo.collider.tag == "Speed--")
		{
			movement.sidewaysForce = 100f;

		}

		//Finishing if Level == 1
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 2)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level1Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 2
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 3)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level2Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 3
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 4)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level3Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 4
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 5)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level4Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 5
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 6)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level5Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 6
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 7)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level6Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 7
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 8)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level7Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 8
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 9)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level8Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 9
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 10)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level9Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 10
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 11)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level10Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 11
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 12)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level11Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 12
		if (collisionInfo.collider.tag == "Finish" && SceneManager.GetActiveScene().buildIndex == 13)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level12Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 13
		if (collisionInfo.collider.tag == "Finish" && PlayerPrefs.GetInt("Level13Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 14)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level13Checkpoint", Level13Complete);
			PlayerPrefs.SetInt("Level13Complete", BoolTrue);
			
		}



		//Finishing if Level == 14
		if (collisionInfo.collider.tag == "Finish" && PlayerPrefs.GetInt("Level14Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 15)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level14Checkpoint", Level14Complete);
			PlayerPrefs.SetInt("Level14Complete", BoolTrue);
			
		}



		//Finishing if Level == 15
		if (collisionInfo.collider.tag == "Finish" && PlayerPrefs.GetInt("Level15Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 16)
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level15Checkpoint", Level15Complete);
			PlayerPrefs.SetInt("Level15Complete", BoolTrue);
			
		}

        //Finishing if Level == 16
        if (collisionInfo.collider.tag == "Finish" && PlayerPrefs.GetInt("Level16Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 17)
        {
			movement.enabled = false; //Disable Players movement
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level16Checkpoint", Level16Complete);
			PlayerPrefs.SetInt("Level16Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 17
        if (collisionInfo.collider.tag == "Finish" && PlayerPrefs.GetInt("Level17Checkpoint") == 1 && SceneManager.GetActiveScene().buildIndex == 18)
        {
			movement.enabled = false; //Disable Players movement
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level17Checkpoint", Level17Complete);
			PlayerPrefs.SetInt("Level17Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 18
        if (collisionInfo.collider.tag == "Finish" && PlayerPrefs.GetInt("Level18Checkpoint") == 1 && PlayerPrefs.GetInt("Level18Checkpoint2") == 1 && SceneManager.GetActiveScene().buildIndex == 19)
        {
			movement.enabled = false; //Disable Players movement
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level18Checkpoint", Level18Complete);
			PlayerPrefs.SetInt("Level18Checkpoint2", Level18Complete);
			PlayerPrefs.SetInt("Level18Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 19
        if (collisionInfo.collider.tag == "Finish" && PlayerPrefs.GetInt("Level19Checkpoint") == 1 && PlayerPrefs.GetInt("Level19Checkpoint2") == 1 && SceneManager.GetActiveScene().buildIndex == 20)
        {
			movement.enabled = false; //Disable Players movement
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level19Checkpoint", Level19Complete);
			PlayerPrefs.SetInt("Level19Checkpoint2", Level19Complete);
			PlayerPrefs.SetInt("Level19Complete", BoolTrue);
			
		}
		
		//Finishing if Level == 20
        if (collisionInfo.collider.tag == "Finish" && PlayerPrefs.GetInt("Level20Checkpoint") == 1 && PlayerPrefs.GetInt("Level20Checkpoint2") == 1 && SceneManager.GetActiveScene().buildIndex == 21)
        {
			movement.enabled = false; //Disable Players movement
			FindObjectOfType<GameManager>().CompleteLevel();
			PlayerPrefs.SetInt("Level20Checkpoint", Level20Complete);
			PlayerPrefs.SetInt("Level20Checkpoint2", Level20Complete);
			PlayerPrefs.SetInt("Level20Complete", BoolTrue);
			
		}
		
		//Changeing Player's Position if Player Collides platform with tag Checkpoint and setting spawn to that point 
		//Level13
		if (collisionInfo.collider.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 14)
		{
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;

			PlayerPrefs.SetInt("Level13Checkpoint", Level13);
		}

		//Changeing Player's Position if Player Collides platform with tag Checkpoint and setting spawn to that point
		//Level14
		if (collisionInfo.collider.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 15)
		{
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;

			PlayerPrefs.SetInt("Level14Checkpoint", Level14);
		}

		//Changeing Player's Position if Player Collides platform with tag Checkpoint and setting spwn to that point 
		//Level15
		if (collisionInfo.collider.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 16)
		{
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;

			PlayerPrefs.SetInt("Level15Checkpoint", Level15);
		}

		//Changeing Player's Position if Player Collides platform with tag Checkpoint and setting spwn to that point 
		//Level16
		if (collisionInfo.collider.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 17)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;

			PlayerPrefs.SetInt("Level16Checkpoint", Level16);
		}
		
		//Changeing Player's Position if Player Collides platform with tag Checkpoint and setting spwn to that point 
		//Level17
		if (collisionInfo.collider.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 18)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;

			PlayerPrefs.SetInt("Level17Checkpoint", Level17);
		}

		//Levels with two Checkpoints

		//Level 18
		//Changeing Player's Position if Player Collides platform with tag Checkpoint and setting spwn to that point 
		if (collisionInfo.collider.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 19)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;

			PlayerPrefs.SetInt("Level18Checkpoint", Level18);
		}
		
		//Changeing Player's Position if Player Collides platform with tag Checkpoint2 and setting spwn to that point 
		if (collisionInfo.collider.tag == "CheckPoint2" && SceneManager.GetActiveScene().buildIndex == 19)
        {
			Vector3 position = transform.position;
			position.x = 30f;
			position.y = 0f;
			position.z = 80f;
			transform.position = position;

			PlayerPrefs.SetInt("Level18Checkpoint2", Level18_2ndCheckpoint);
		}
		
		
		//Level19
		//Changeing Player's Position if Player Collides platform with tag Checkpoint and setting spwn to that point 
		if (collisionInfo.collider.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 20)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;

			PlayerPrefs.SetInt("Level19Checkpoint", Level19);
		}
		
		//Changeing Player's Position if Player Collides platform with tag Checkpoint2 and setting spwn to that point 
		if (collisionInfo.collider.tag == "CheckPoint2" && SceneManager.GetActiveScene().buildIndex == 20)
        {
			Vector3 position = transform.position;
			position.x = 30f;
			position.y = 0f;
			position.z = 80f;
			transform.position = position;

			PlayerPrefs.SetInt("Level19Checkpoint2", Level19_2ndCheckpoint);
		}
		
		
		//Level20
		//Changeing Player's Position if Player Collides platform with tag Checkpoint and setting spwn to that point 
		if (collisionInfo.collider.tag == "CheckPoint" && SceneManager.GetActiveScene().buildIndex == 21)
        {
			Vector3 position = transform.position;
			position.x = 55f;
			position.y = 0f;
			position.z = 30f;
			transform.position = position;

			PlayerPrefs.SetInt("Level20Checkpoint", Level20);
		}
		
		//Changeing Player's Position if Player Collides platform with tag Checkpoint2 and setting spwn to that point 
		if (collisionInfo.collider.tag == "CheckPoint2" && SceneManager.GetActiveScene().buildIndex == 21)
        {
			Vector3 position = transform.position;
			position.x = 30f;
			position.y = 0f;
			position.z = 80f;
			transform.position = position;

			PlayerPrefs.SetInt("Level20Checkpoint2", Level20_2ndCheckpoint);
		}


	}
    


}  


