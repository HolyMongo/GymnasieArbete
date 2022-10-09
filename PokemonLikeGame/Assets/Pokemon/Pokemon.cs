using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    BasePokemon _base;
    int lvl;

    public Pokemon(BasePokemon PokemonBase, int _lvl)
    {
        _base = PokemonBase;
        lvl = _lvl;
    }

    public int Attack
    {
        get { return Mathf.FloorToInt((_base.Attack * lvl) / 100f) + 5; }
    }
    public int SpAttack
    {
        get { return Mathf.FloorToInt((_base.SpAttack * lvl) / 100f) + 5; }
    }
    public int Defence
    {
        get { return Mathf.FloorToInt((_base.Defence * lvl) / 100f) + 5; }
    }
    public int SpDefence
    {
        get { return Mathf.FloorToInt((_base.SpDefence * lvl) / 100f) + 5; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((_base.Speed * lvl) / 100f) + 5; }
    }
    public int MaxHp
    {
        get { return Mathf.FloorToInt((_base.MaxHp * lvl) / 100f) + 10; }
    }
}
