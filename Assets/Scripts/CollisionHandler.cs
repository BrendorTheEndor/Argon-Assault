using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Player triggered something");
    }

}
