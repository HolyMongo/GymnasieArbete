using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateStatsOnStartMeny : MonoBehaviour
{
   
    public void Bulbasaur()
    {
        GetComponent<TextMeshProUGUI>().text = "Type: Grass \nAttack: ??? \nHealth: ??? \nCool: Yes";
        
    }
    public void Charmander()
    {
        GetComponent<TextMeshProUGUI>().text = "Type: Fire \nAttack: ??? \nHealth: ??? \nCool: Yes";
        
    }

    public void Squirtle()
    {
        GetComponent<TextMeshProUGUI>().text = "Type: Water \nAttack: ??? \nHealth: ??? \nCool: Very";

    }


}
