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
        pokemonSO.ChangeInformation("bulba", 49, 45, 49, 5, Bulb);
    }
    public void CVC()
    {
        pokemonSO.ChangeInformation("Charman", 52, 39, 43, 5, charm);
    }
    public void CVS()
    {
        pokemonSO.ChangeInformation("Squirt", 48, 44, 56, 5, squirt);
    }
}
