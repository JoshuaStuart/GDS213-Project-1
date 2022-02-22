using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    public Transform gameOverCanvas;
    public GameObject OutOfTime;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        gameOverCanvas.gameObject.SetActive(true);
    }

    /*private void RunOutOfTime()
    {
        if(OutOfTime.gameObject.GetComponent<currentTime>() == 0)
        {
            Time.timeScale = 0;
            gameOverCanvas.gameObject.SetActive(true);
        }
    }*/
}
