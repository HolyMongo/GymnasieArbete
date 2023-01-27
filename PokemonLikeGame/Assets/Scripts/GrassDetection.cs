using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrassDetection : MonoBehaviour
{
    int randomnumber;
    [SerializeField] PlayerData pD;
    [SerializeField] Transform transfo;
    [SerializeField] BasePokemon e1;
    [SerializeField] BasePokemon e2;
    [SerializeField] BasePokemon e3;
    [SerializeField] BasePokemon e4;
    [SerializeField] BasePokemon e5;
    [SerializeField] BasePokemon e6;
    [SerializeField] BasePokemon e7;
    [SerializeField] BasePokemon e8;
    [SerializeField] BasePokemon e9;

    [SerializeField] BasePokemon eP;
    [SerializeField] BasePokemon pP;

    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject battleCam;
    [SerializeField] GameObject playerCharacter;
    [SerializeField] GetPokemonStats gps;
    [SerializeField] GetPokemonStats egps;

    private void Start()
    {
        Debug.Log("started");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Exited");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Entered");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.attachedRigidbody.velocity.x != 0 || collision.attachedRigidbody.velocity.y != 0)
            {
                if (pP.CurrentHp > 0)
                {

               
                    randomnumber = Random.Range(1, 500);
                    if (randomnumber < 5)
                    {
                        randomnumber = Random.Range(1, 13);
                        if (randomnumber <= 7)
                        {
                            randomnumber = Random.Range(1, 4);
                            if (randomnumber == 1)
                            {
                                eP.ChangeInformation(e1.name, e1.Attack, e1.MaxHp, e1.CurrentHp ,e1.Defence, e1.Lvl, e1.Sprite, e1.A1, e1.A2, e1.A3, e1.A4);
                            }
                            else if (randomnumber == 2)
                            {
                                eP.ChangeInformation(e4.name, e4.Attack, e4.MaxHp, e4.CurrentHp, e4.Defence, e4.Lvl, e4.Sprite, e4.A1, e4.A2, e4.A3, e4.A4);
                            }
                            else
                            {
                                eP.ChangeInformation(e7.name, e7.Attack, e7.MaxHp, e7.CurrentHp, e7.Defence, e7.Lvl, e7.Sprite, e7.A1, e7.A2, e7.A3, e7.A4);
                            }
                        }
                        else if (randomnumber > 7 && randomnumber <= 11)
                        {
                            randomnumber = Random.Range(1, 4);
                            if (randomnumber == 1)
                            {
                                eP.ChangeInformation(e2.name, e2.Attack, e2.MaxHp, e2.CurrentHp, e2.Defence, e2.Lvl, e2.Sprite, e2.A1, e2.A2, e2.A3, e2.A4);
                            }
                            else if (randomnumber == 2)
                            {
                                eP.ChangeInformation(e5.name, e5.Attack, e5.MaxHp, e5.CurrentHp, e5.Defence, e5.Lvl, e5.Sprite, e5.A1, e5.A2, e5.A3, e5.A4);
                            }
                            else
                            {
                                eP.ChangeInformation(e8.name, e8.Attack, e8.MaxHp, e8.CurrentHp, e8.Defence, e8.Lvl, e8.Sprite, e8.A1, e8.A2, e8.A3, e8.A4);
                            }
                        }
                        else
                        {
                            randomnumber = Random.Range(1, 4);
                            if (randomnumber == 1)
                            {
                                eP.ChangeInformation(e3.name, e3.Attack, e3.MaxHp, e3.CurrentHp, e3.Defence, e3.Lvl, e3.Sprite, e3.A1, e3.A2, e3.A3, e3.A4);
                            }
                            else if (randomnumber == 2)
                            {
                                eP.ChangeInformation(e6.name, e6.Attack, e6.MaxHp, e6.CurrentHp, e6.Defence, e6.Lvl, e6.Sprite, e6.A1, e6.A2, e6.A3, e6.A4);
                            }
                            else
                            {
                                eP.ChangeInformation(e9.name, e9.Attack, e9.MaxHp, e9.CurrentHp, e9.Defence, e9.Lvl, e9.Sprite, e9.A1, e9.A2, e9.A3, e9.A4);
                            }
                        }
                        pD.ChangePlayerPos(transfo.position.x, transfo.position.y);
                        //SceneManager.LoadScene("Battle");
                        mainCam.SetActive(false);
                        battleCam.SetActive(true);
                        playerCharacter.SetActive(false);
                        gps.UpdateStats();
                        egps.UpdateStats();
                        Debug.Log("Wild pokemon encounter");
                    } 
                }
            }

        }
    }



}
