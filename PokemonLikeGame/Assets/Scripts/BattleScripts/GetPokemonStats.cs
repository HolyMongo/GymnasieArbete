using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetPokemonStats : MonoBehaviour
{
    [SerializeField] BasePokemon pp;
    [SerializeField] TextMeshProUGUI pName;
    [SerializeField] TextMeshProUGUI pLvl;
    [SerializeField] TextMeshProUGUI pHp;
    [SerializeField] Image pImage;


    void Start()
    {
        pName.text = pp.Name;
        pLvl.text = "Lvl: " + pp.Lvl;
        pHp.text = "Hp: " + pp.MaxHp + "/" + pp.MaxHp;
        pImage.sprite = pp.Sprite;
    }

}
