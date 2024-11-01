using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private int direction = 1;
    private Vector3 vector = new Vector3(0, 0, 1);
    void Update()
    {
        transform.position += vector * speed*0.005f * direction;
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            int randomDirection = Random.Range(0, 3);
            direction *= -1;
            switch (randomDirection)
            {
                case 0:
                    vector = new Vector3(1, 0, 1);
                    break;
                case 1:
                    vector = new Vector3(-1, 0, 1);
                    break;
                case 2:
                    vector = new Vector3(0, 0, 1);
                    break;
            }

        }
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
