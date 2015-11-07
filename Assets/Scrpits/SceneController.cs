using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour 
{
    public GameObject enemyPrefab;

    private GameObject enemy;


	void Update () 
    {
        if(enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(1, 0, 1);
            enemy.transform.Rotate(new Vector3(0, Random.Range(0, 360), 0));
        }
	}
}
