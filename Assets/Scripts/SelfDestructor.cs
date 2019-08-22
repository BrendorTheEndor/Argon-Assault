using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour {

    [SerializeField] float timeBeforeDestroy = 5f;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(WaitToDestroy());
    }

    IEnumerator WaitToDestroy() {
        yield return new WaitForSeconds(timeBeforeDestroy);
        Destroy(gameObject);
    }
}
