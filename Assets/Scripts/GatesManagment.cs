using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatesManagment : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Gates;
    [SerializeField]
    private GameObject teleport;
    [SerializeField]
    private GameObject point;
    private int currentStage = 1;

    private void Start()
    {
        Gates[0].SetActive(true);
        Gates[1].SetActive(false);
        Gates[2].SetActive(false);
        Gates[3].SetActive(false);
        teleport.SetActive(false);
        point.SetActive(false);
    }

    public void PlayerTriggerEnter()
    {
        switch (currentStage)
        {
            case 1:
                Gates[1].SetActive(true);
                if(currentStage < 2)
                {
                    currentStage = 2;
                }
                break;
            case 2:
                Gates[2].SetActive(true);
                if (currentStage < 3)
                {
                    currentStage = 3;
                }
                break;
            case 3:
                Gates[3].SetActive(true);
                if (currentStage < 4)
                {
                    currentStage = 4;
                }
                break;
            case 4:
                teleport.SetActive(true);
                point.SetActive(true);
                if (currentStage < 5)
                {
                    currentStage = 5;
                }
                break;
            default:
                break;
        }
    }
}
