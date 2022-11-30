using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnabler : MonoBehaviour
{

    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level6;
    public GameObject Level7;
    public GameObject Level8;
    public GameObject Level9;
    public GameObject Level10;
    public GameObject Level11;
    public GameObject Level12;
    public GameObject Level13;
    public GameObject Level14;
    public GameObject Level15;
    public GameObject Level16;
    public GameObject Level17;
    public GameObject Level18;
    public GameObject Level19;
    public GameObject Level20;

    public void Update()
    {

       if (PlayerPrefs.GetInt("Level1Complete") == 1)
        {
            Level2.SetActive(true);
        } 
        
       if (PlayerPrefs.GetInt("Level2Complete") == 1)
        {
            Level3.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level3Complete") == 1)
        {
            Level4.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level4Complete") == 1)
        {
            Level5.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level5Complete") == 1)
        {
            Level6.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level6Complete") == 1)
        {
            Level7.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level7Complete") == 1)
        {
            Level8.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level8Complete") == 1)
        {
            Level9.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level9Complete") == 1)
        {
            Level10.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level10Complete") == 1)
        {
            Level11.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level11Complete") == 1)
        {
            Level12.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level12Complete") == 1)
        {
            Level13.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level13Complete") == 1)
        {
            Level14.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level14Complete") == 1)
        {
            Level15.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level15Complete") == 1)
        {
            Level16.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level16Complete") == 1)
        {
            Level17.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level17Complete") == 1)
        {
            Level18.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level18Complete") == 1)
        {
            Level19.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Level19Complete") == 1)
        {
            Level20.SetActive(true);
        }

    }
}
