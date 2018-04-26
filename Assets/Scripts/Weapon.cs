using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

// Enum with key's set to value of 1 and then moved using binary operator <<
public enum DamageType
{
    None = 0,           // the big would read (00000000)
    Melee = 1 << 0,     // the bit would read (00000001)
    Range = 1 << 1,     // the bit would read (00000010)
    Fire = 1 << 2,      // the bit would read (00000100)
    Cold = 1 << 3,      // the bit would read (00001000)
    Poison = 1 << 4,    // the bit would read (00010000)
    Magic = 1 << 5,     // the bit would read (00100000)
    Explosive = 1 << 6, // the bit would read (01000000)
    Electric = 1 << 7   // the bit would read (10000000)

}

public class Weapon : MonoBehaviour {

    public string weaponName;
    [EnumFlag]
    public DamageType damageType;
    [CustomRange(0, 10)]
    public float damage;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Adds a damage type to damageTypeVariable
    void AddDamageType(DamageType type)
    {
        int dType = (int)type;

        Debug.Log("Bit before add: " + DecimalToBinary(dType));

        damageType = damageType | type; // Uses Binary Or operator to add the value of type to damageType

        dType = (int)type;

        Debug.Log("Bit after add: " + DecimalToBinary(dType));
    }

    bool HasDamageType(DamageType type)
    {
        //If damageType and type have the same bit at the same value returns true
        if((damageType & type) == type)
        {
            return true;
        }
        return false;
    }

    //Removes a value from damageType
    void RemoveDamageType(DamageType type)
    {
        //var antiType = ~type;
        //damageType = damageType & antiType;

        int dType = (int)type;

        Debug.Log("Bit before remove: " + DecimalToBinary(dType));

        damageType &= ~type;

        dType = (int)type;

        Debug.Log("Bit after remove: " + DecimalToBinary(dType));
    }

    //Toggles a value in damageType
    void ToggleDamageType(DamageType type)
    {
        int dType = (int)type;

        Debug.Log("Bit before toggle: " + DecimalToBinary(dType));

        damageType ^= type;

        dType = (int)type;

        Debug.Log("Bit after toggle: " + DecimalToBinary(dType));
    }


    string DecimalToBinary(int i)
    {
        string result = "00000000";
        string front = "";

        if (i > 255)
            return null;

        result = Convert.ToString(i, 2);

        if(result.Length < 7)
        {
            for(int j = 0; j < (8 - result.Length); j++)
            {
                front += "0";
            }
            result = front + result;
        }
        return result;
    }

    int BinaryToDecimal(string i)
    {
        int result = Convert.ToInt32(i, 2);
        return result;
    }
}
