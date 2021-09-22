using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHunger : MonoBehaviour
{
    [SerializeField] GameData gameData;

    public void UpdateHunger(float foodValue)
    {
        gameData.Hunger += foodValue / 100; 
    }
}
