using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    [NonSerialized]
    public int points = 0;
    [NonSerialized]
    public bool canTp = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            points++;
            Destroy(other.gameObject);
            canTp = true;
        }
    }
}
