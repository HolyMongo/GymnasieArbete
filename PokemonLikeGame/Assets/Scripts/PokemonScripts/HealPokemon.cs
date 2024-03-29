using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPokemon : MonoBehaviour
{
    [SerializeField] BasePokemon pp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pp.changeCurrentHealth(pp.MaxHp);
        }
    }
}
