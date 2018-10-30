using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject explosionParticle;

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint cp = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, cp.normal);
        GameObject explosive = Instantiate(explosionParticle, cp.point, rotation) as GameObject;
        Destroy(gameObject);
        Destroy(explosive, 1f);
    }
}
