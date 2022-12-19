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
        if (pName != null)
        {
            pName.text = pp.Name;
        }
        if (pLvl != null)
        {
            pLvl.text = "Lvl: " + pp.Lvl;
        }
        if (pHp != null)
        {
            pHp.text = "Hp: " + pp.CurrentHp + "/" + pp.MaxHp;
        }
        if (pImage != null)
        {
            pImage.sprite = pp.Sprite;
        }
    }

}
