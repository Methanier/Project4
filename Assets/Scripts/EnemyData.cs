using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemies", order = 0)]
public class EnemyData : ScriptableObject {

    public string enemyName;
    public float enemyHealth;
    public int enemyLevel;
    public float enemyDamage;
	
}
