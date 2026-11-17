using System;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using Gamekit3D;

public enum ElementalPower
{
    Fire,
    Water,
    Earth,
    Light,
    None
}
[System.Serializable]
public struct CharacterInformation
{
    public string name;
    public ElementalPower elementalPower;
    public float speed;
    public int health;
    public bool isAlive;
    public int damagePower;
}

public enum CharacterMood
{

    Happy,
    Sad,
    Angry,
    Frustrated,
    Mesmerized,
    Ecstatic,
    Furious,
    Grounded
}



public class WS3 : MonoBehaviour
{

    public ElementalPower elementKraft;
    public CharacterInformation characterInformation;
    public int[] highScores;
    public CharacterMood mood;
    public int[] kills;

    private void Start()
    {
        if (mood == CharacterMood.Frustrated)
        {
            Debug.Log("AAAARRGHH!!!");
        }
        
        if (characterInformation.health == 0)
            {
              mood = CharacterMood.Sad;
            }

        if (elementKraft == ElementalPower.Fire)
        {
            mood = CharacterMood.Furious;
        }

        if (elementKraft == ElementalPower.Water)
        {
            mood = CharacterMood.Mesmerized;
        }

        if (elementKraft == ElementalPower.Earth)
        {
            mood = CharacterMood.Grounded;
        }
        
        if (kills[0] == 0)
        {
            mood = CharacterMood.Angry;
            
        }
        
           
    }


        
    
}