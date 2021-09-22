using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "FoodData")]
public class FrootSO : ScriptableObject
{
    [SerializeField] Sprite foodSprite;
    [SerializeField] float foodValue;

    public Sprite FoodSprite { get { return foodSprite; } }
    public float FoodValue { get { return foodValue; } }

}

