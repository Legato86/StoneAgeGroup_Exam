using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Froot : MonoBehaviour
{
    [SerializeField] FrootSO frootData;
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = frootData.FoodSprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHunger player = collision.GetComponent<PlayerHunger>();
        if(player != null) 
        {

            player.UpdateHunger(frootData.FoodValue);
            Destroy(gameObject);

        }
    }
}
