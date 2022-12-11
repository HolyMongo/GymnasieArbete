using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HideOrShowAttacks : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI attack1;
    [SerializeField] TextMeshProUGUI attack2;
    [SerializeField] TextMeshProUGUI attack3;
    [SerializeField] TextMeshProUGUI attack4;

    public HideOrShowAttacks() {

        attack1.GetComponent<Image>().enabled = false;
    }

}
