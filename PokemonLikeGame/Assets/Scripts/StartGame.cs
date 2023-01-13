using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject currentCam;
    [SerializeField] GameObject playerCharacter;
    public void Startgame()
    {
        //SceneManager.LoadScene("Game");

        currentCam.SetActive(false);
        mainCam.SetActive(true);
        playerCharacter.SetActive(true);
    }

}
