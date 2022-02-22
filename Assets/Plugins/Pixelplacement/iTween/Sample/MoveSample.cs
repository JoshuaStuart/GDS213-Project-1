using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{
	public GameObject cube;

    private void Update()
    {
		if (Input.GetKeyDown("d"))
		{
			Move();
		}
    }
    void Move()
	{
			iTween.MoveAdd(gameObject, iTween.Hash("speed", 2, "easeType", "easeOutExpo"));
	}
}

