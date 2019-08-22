using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] Transform parent;
    [SerializeField] GameObject deathFX;

    void Start() {
        AddNonTriggerBoxCollider();
    }

    private void AddNonTriggerBoxCollider() {
        BoxCollider enemyBoxCollider = gameObject.AddComponent<BoxCollider>();
        enemyBoxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other) {
        Debug.Log("Particle collided with enemy ship: " + gameObject.name);
        var instanceOfDeathFX = Instantiate(deathFX, transform.position, Quaternion.identity);
        instanceOfDeathFX.transform.parent = parent;
        Destroy(gameObject);
    }
}
