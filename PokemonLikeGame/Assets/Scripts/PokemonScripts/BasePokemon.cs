using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New wild pokemon", menuName = "Pokemon Creation/New Pokemon")]
public class BasePokemon : ScriptableObject
{
    [SerializeField] string Pokemonname;
    [SerializeField] int lvl;
    [SerializeField] int maxHp;
    [SerializeField] int currentHp;
    [SerializeField] int attack;
    //[SerializeField] int spAttack;
    [SerializeField] int defence;
    //[SerializeField] int spDefence;
    //[SerializeField] int speed;
    [SerializeField] Sprite sprite;

    [SerializeField] Attacks Attack1;
    [SerializeField] Attacks Attack2;
    [SerializeField] Attacks Attack3;
    [SerializeField] Attacks Attack4;
    //[SerializeField] PokemonTypes type1;
    //[SerializeField] PokemonTypes type2;

    int exp;
    int expToLvlUp;

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
    public int CurrentHp
    {
        get { return currentHp; }
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

    public Attacks A1
    {
        get { return Attack1; }
    }
    public Attacks A2
    {
        get { return Attack2; }
    }
    public Attacks A3
    {
        get { return Attack3; }
    }
    public Attacks A4
    {
        get { return Attack4; }
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

    public enum Attacks
    {
        None,
        Scratch,
        Tackle,
        Leafage,
        Chloroblast,
        Flametrower,
        Ember,
        Scald,
        Surf
    }
    public void ChangeInformation(string name_, int attack_, int health_, int currentHp_, int defence_, int lvl_, Sprite sprite_, Attacks A1_, Attacks A2_, Attacks A3_, Attacks A4_)
    {
        Pokemonname = name_;
        attack = attack_;
        maxHp = health_;
        currentHp = currentHp_;
        defence = defence_;
        lvl = lvl_;
        sprite = sprite_;
        Attack1 = A1_;
        Attack2 = A2_;
        Attack3 = A3_;
        Attack4 = A4_;
    }

    public void GetHit(int attckerAttack_, int defenderDefence_)
    {
        int attackdamage;
        //Debug.Log(attckerAttack_);
        //Debug.Log(defenderDefence_);
        //Debug.Log(Mathf.FloorToInt(attckerAttack_ / defenderDefence_));
        //currentHp -= Mathf.FloorToInt(attckerAttack_/defenderDefence_);

        currentHp -= Mathf.FloorToInt((((((attckerAttack_ * lvl) / 5) + 2) * (attckerAttack_ / defenderDefence_)) / 5) + 2);
        attackdamage = Mathf.FloorToInt(attckerAttack_ * lvl);
        Debug.Log(attackdamage);
        attackdamage = Mathf.FloorToInt(attackdamage/5);
        Debug.Log(attackdamage);
        attackdamage = Mathf.FloorToInt(attackdamage + 2);
        Debug.Log(attackdamage);
        attackdamage = Mathf.FloorToInt(attackdamage * (attckerAttack_ / defenderDefence_));
        Debug.Log(attackdamage);
        attackdamage = Mathf.FloorToInt(attackdamage / 5);
        Debug.Log(attackdamage);
        attackdamage = Mathf.FloorToInt(attackdamage + 2);
        Debug.Log("Final damage should be: " + attackdamage);


        Debug.Log("attack: " + attckerAttack_);
        Debug.Log("Defence: " + defenderDefence_);
        Debug.Log("Damage: " + Mathf.FloorToInt((((((attckerAttack_ * lvl) / 5) + 2) * (attckerAttack_ / defenderDefence_)) / 5) + 2));
    }

    public void changeCurrentHealth(int currentHP_)
    {
        currentHp = currentHP_;
    }


    public void AddExp(int A, int B, int C)
    {
        float ExpGainAmout = Mathf.Floor(Mathf.Floor(Mathf.Sqrt(A) * (A * A)) * B / Mathf.Floor(Mathf.Sqrt(C) * (C * C))) + 1;

        Debug.Log(ExpGainAmout);

    }
}
