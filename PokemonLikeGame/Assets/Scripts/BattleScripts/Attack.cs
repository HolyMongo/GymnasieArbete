using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Attack : MonoBehaviour
{
    [SerializeField] BasePokemon pp;
    [SerializeField] BasePokemon ep;
    [SerializeField] TextMeshProUGUI echp;
    [SerializeField] TextMeshProUGUI pchp;

    public void AttackOrTakeDamage()
    {
        ep.GetHit(Mathf.FloorToInt((pp.Attack * pp.Lvl) / 100f) + 5 * Random.Range(1, 3), Mathf.FloorToInt((pp.Defence * pp.Lvl) / 100f));
        echp.text = "Hp: " + ep.CurrentHp + "/" + ep.MaxHp;
        if (ep.CurrentHp >= 1)
        {
            pp.GetHit(Mathf.FloorToInt((pp.Attack * pp.Lvl) / 100f) + 5, Mathf.FloorToInt((pp.Defence * pp.Lvl) / 100f));
            pchp.text = "Hp: " + pp.CurrentHp + "/" + pp.MaxHp;
        }
    }
}
