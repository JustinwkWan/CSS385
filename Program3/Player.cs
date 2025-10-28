using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public int score = 0; 
    void Awake() {
        Instance = this;
    }

    
    public void SavePlayer()
    {
        Debug.Log("Saving player position: " + transform.position);
        SaveSystem.SavePlayer(this);
        Debug.Log("Player position saved!");
    }

    public void LoadPlayer()
    {
        Debug.Log("Loading player data...");
        PlayerData data = SaveSystem.LoadPlayer();
        if (data != null)
        {
            Vector3 position = new Vector3(data.positionArray[0], data.positionArray[1], data.positionArray[2]);

            Debug.Log("Loaded position: " + position);
            
            transform.position = position;
        }
    }
}