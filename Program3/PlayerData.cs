using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] positionArray = new float[3];

    public PlayerData (Player player)
    {
        positionArray[0] = player.transform.position.x;
        positionArray[1] = player.transform.position.y;
        positionArray[2] = player.transform.position.z;
    }
}