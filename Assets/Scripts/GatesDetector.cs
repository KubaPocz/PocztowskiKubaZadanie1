using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatesDetector : MonoBehaviour
{
    private GatesManagment GM;
    private void Start()
    {
        GM = GetComponentInParent<GatesManagment>();
    }
    private void OnTriggerEnter(Collider other)
    {
        GM.PlayerTriggerEnter();
    }
}
