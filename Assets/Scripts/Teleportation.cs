using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    [SerializeField]
    private GameObject[] nextPlatform;
    public PlayerPoints player;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerPoints>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            switch (player.points)
            {
                case 1:
                    if (player.canTp)
                    {
                        player.canTp = false;
                        other.gameObject.transform.position = nextPlatform[0].transform.position;
                    }
                    break;
                case 2:
                    if (player.canTp)
                    {
                        player.canTp = false;
                        other.gameObject.transform.position = nextPlatform[1].transform.position;
                    }
                    break;
                case 3:
                    if (player.canTp)
                    {
                        if (CountEnemies(GameObject.Find("Platform3")) == 0)
                        {
                            player.canTp = false;
                            other.gameObject.transform.position = nextPlatform[2].transform.position;
                        }
                    }
                    break;
                case 4:
                    Debug.Log("Koniec gry");
                    Application.Quit();
                    break;
                default:
                    break;
            }
        }
    }
    private int CountEnemies(GameObject parent)
    {
        int count = 0;
        foreach (Transform child in parent.transform)
        {
            if(child.tag == "Enemy")
            {
                count++;
            }
        }
        return count;
    }
}
