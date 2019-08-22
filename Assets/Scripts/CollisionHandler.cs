using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [SerializeField] float timeToWait = 1f;

    PlayerController myPlayerController;

    private void Start() {
        myPlayerController = GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other) {
        StartDeathRoutine();
    }

    private void StartDeathRoutine() {
        Debug.Log("Player triggered something");
        SendMessage("OnPlayerDeath");
        StartCoroutine(WaitAndReload());
    }

    IEnumerator WaitAndReload() {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
