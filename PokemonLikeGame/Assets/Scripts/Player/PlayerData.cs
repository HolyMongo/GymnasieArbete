using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "Player Data/New player")]
public class PlayerData : ScriptableObject
{
    [SerializeField] float xPos;
    [SerializeField] float yPos;


    public float XPos
    {
        get { return xPos; }
    }
    public float YPos
    {
        get { return yPos; }
    }

    public void ChangePlayerPos(float x_, float y_)
    {
        xPos = x_;
        yPos = y_;
    }
}
