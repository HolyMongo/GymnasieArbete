using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New wild pokemon", menuName = "Pokemon Creation/New Pokemon")]
public class BasePokemon : ScriptableObject
{
    [SerializeField] string Pokemonname;
    [SerializeField] int lvl;
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    //[SerializeField] int spAttack;
    [SerializeField] int defence;
    //[SerializeField] int spDefence;
    //[SerializeField] int speed;
    [SerializeField] Sprite sprite;

    //[SerializeField] PokemonTypes type1;
    //[SerializeField] PokemonTypes type2;

    public string Name{
        get { return Pokemonname; }
    }
    public int Lvl
    {
        get { return lvl; }
    }
    public int MaxHp
    {
        get { return maxHp; }
    }
    public int Attack
    {
        get { return attack; }
    }
    //public int SpAttack
    //{
    //    get { return spAttack; }
    //}
    public int Defence
    {
        get { return defence; }
    }
    //public int SpDefence
    //{
    //    get { return spDefence; }
    //}
    //public int Speed
    //{
    //    get { return speed; }
    //}
    public Sprite Sprite
    {
        get { return sprite; }
    }

    //public PokemonTypes Type1
    //{
    //    get { return type1; }
    //}
    //public PokemonTypes Type2
    //{
    //    get { return type2; }
    //}

    //public enum PokemonTypes
    //{
    //    none,
    //    Normal,
    //    Water,
    //    Fire,
    //    Grass,
    //    Electric,
    //    Ice,
    //    Fighting,
    //    Poison,
    //    Ground,
    //    Flying,
    //    Psychic,
    //    Bug,
    //    Rock,
    //    Ghost,
    //    Dragon
    //}

    public void ChangeInformation(string name_, int attack_, int health_, int defence_, int lvl_, Sprite sprite_)
    {
        Pokemonname = name_;
        attack = attack_;
        maxHp = health_;
        defence = defence_;
        lvl = lvl_;
        sprite = sprite_;
    }
}
