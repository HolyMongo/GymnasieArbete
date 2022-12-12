using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HideOrShowAttacks : MonoBehaviour
{
    [SerializeField] Button attack1;
    [SerializeField] Button attack2;
    [SerializeField] Button attack3;
    [SerializeField] Button attack4;
    [SerializeField] TextMeshProUGUI wwyd;
    bool isShowing = false;

    [SerializeField] BasePokemon pp;

    public void Hideorshowattacks() {

        if (!isShowing)
        {
            attack1.GetComponent<Image>().enabled = true;
            attack1.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            attack1.GetComponentInChildren<TextMeshProUGUI>().text = pp.A1.ToString();
            if (pp.A1 != BasePokemon.Attacks.None)
            { 
                attack1.GetComponent<Button>().enabled = true;
            }

                attack2.GetComponent<Image>().enabled = true;
            attack2.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            attack2.GetComponentInChildren<TextMeshProUGUI>().text = pp.A2.ToString();
            if (pp.A2 != BasePokemon.Attacks.None)
            { 
                attack2.GetComponent<Button>().enabled = true;
            }

                attack3.GetComponent<Image>().enabled = true;
            attack3.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            attack3.GetComponentInChildren<TextMeshProUGUI>().text = pp.A3.ToString();
            if (pp.A3 != BasePokemon.Attacks.None)
            { 
                attack3.GetComponent<Button>().enabled = true;
            }

            attack4.GetComponent<Image>().enabled = true;
            attack4.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            attack4.GetComponentInChildren<TextMeshProUGUI>().text = pp.A4.ToString();
            if (pp.A4 != BasePokemon.Attacks.None)
            {
                attack4.GetComponent<Button>().enabled = true;
            }

            wwyd.GetComponent<TextMeshProUGUI>().enabled = false;
            isShowing = true;
        }
        else
        {
            attack1.GetComponent<Image>().enabled = false;
            attack1.GetComponent<Button>().enabled = false;
            attack1.GetComponentInChildren<TextMeshProUGUI>().enabled = false;

            attack2.GetComponent<Image>().enabled = false;
            attack2.GetComponent<Button>().enabled = false;
            attack2.GetComponentInChildren<TextMeshProUGUI>().enabled = false;

            attack3.GetComponent<Image>().enabled = false;
            attack3.GetComponent<Button>().enabled = false;
            attack3.GetComponentInChildren<TextMeshProUGUI>().enabled = false;

            attack4.GetComponent<Image>().enabled = false;
            attack4.GetComponent<Button>().enabled = false;
            attack4.GetComponentInChildren<TextMeshProUGUI>().enabled = false;

            wwyd.GetComponent<TextMeshProUGUI>().enabled = true;
            isShowing = false;
        }
    }

}
