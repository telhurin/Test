using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {

    public float speed = 10f;
    public int damage = 1;

	
	void Update () {
        transform.Translate(0, 0, speed * Time.deltaTime);

	}

    void OnCollisionEnter(Collision other)
    {
        PlayerCharacter player = other.gameObject.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            player.Hurt(damage);         
        }
        Destroy(gameObject);
    }
}
