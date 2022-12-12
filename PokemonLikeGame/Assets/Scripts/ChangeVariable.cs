using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVariable : MonoBehaviour
{
    [SerializeField] private Sprite charm;
    [SerializeField] private Sprite Bulb;
    [SerializeField] private Sprite squirt;
    [SerializeField] private BasePokemon pokemonSO;
 

    //private void Start()
    //{
    //    pokemonSO.ChangeInformation("bulba", 50, 100, 10, 5);
    //}

    public void CVB()
    {
        pokemonSO.ChangeInformation("bulba", 49, 45, 45, 49, 5, Bulb, BasePokemon.Attacks.Scratch, BasePokemon.Attacks.Leafage, BasePokemon.Attacks.None, BasePokemon.Attacks.None);
    }
    public void CVC()
    {
        pokemonSO.ChangeInformation("Charman", 52, 39, 39, 43, 5, charm, BasePokemon.Attacks.Scratch, BasePokemon.Attacks.Ember, BasePokemon.Attacks.None, BasePokemon.Attacks.None);
    }
    public void CVS()
    {
        pokemonSO.ChangeInformation("Squirt", 48, 44, 44, 56, 5, squirt, BasePokemon.Attacks.Scratch, BasePokemon.Attacks.Scald, BasePokemon.Attacks.None, BasePokemon.Attacks.None);
    }
}
