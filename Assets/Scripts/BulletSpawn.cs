using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

    public Rigidbody bullet;
    [Range(0, 100)]
    public float speed = 60;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigidbody newBullet = (Rigidbody)GameObject.Instantiate(bullet, transform.position, transform.rotation);
            //alasan Vector3.back karena sudah terlanjur terbalik posisi nya :D
            newBullet.velocity = transform.TransformDirection(Vector3.back * speed);
            Destroy(newBullet.gameObject, 3f);
        }
	}
}
