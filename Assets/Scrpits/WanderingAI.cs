using UnityEngine;
using System.Collections;

public class WanderingAI : MonoBehaviour {

    public float speed = 3f;
    public float obstacleRange = 5f;

    public GameObject fireballPrefab;
    private GameObject fireball;

    public bool alive {private get; set;}

    void Start()
    {
        alive = true;
    }

	void Update () {

        if (alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                if (hit.collider.gameObject.tag == "Player")
                {
                    if (fireball == null)
                    {
                        fireball = Instantiate(fireballPrefab) as GameObject;
                        fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        fireball.transform.rotation = transform.rotation;
                    }
                }
                else if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
	}
}
