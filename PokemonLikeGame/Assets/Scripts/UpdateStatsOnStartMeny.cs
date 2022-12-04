using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateStatsOnStartMeny : MonoBehaviour
{

   
    public void Bulbasaur()
    {
        GetComponent<TextMeshProUGUI>().text = "Type: Grass \nAttack: 52 \nHealth: 39 \nCool: Yes";
        
        
    }
    public void Charmander()
    {
        GetComponent<TextMeshProUGUI>().text = "Type: Fire \nAttack: 49 \nHealth: 45 \nCool: Yes";
        
    }

    public void Squirtle()
    {
        GetComponent<TextMeshProUGUI>().text = "Type: Water \nAttack: 48 \nHealth: 44 \nCool: Very";

    }


}
