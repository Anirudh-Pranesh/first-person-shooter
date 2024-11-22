using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	public float health = 100f;
	public GameObject obj;
	
	public void TakeDamage(float amount)
	{
		health -= amount;
		if(health <= 0)
		{
			Die();
		}
	}

	void respawn()
    {
		GameObject.Instantiate(obj);
    }

	void Die()
	{
		Destroy(gameObject);
		Invoke("respawn", 3f);
	}

	private void Update()
	{
		if(obj.transform.position.y <= -50f)
		{
			Destroy(obj);
		}

		if(obj.transform.position.y >= 200f)
		{
			Destroy(obj);
		}
	}
}
