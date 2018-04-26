using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player", order = 0)]
public class PlayerData : ScriptableObject {

    public string playerName;
    public float playerHealth;
    public float playerSpeed;
    public float playerExperience;

}
