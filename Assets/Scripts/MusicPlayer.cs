using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    [SerializeField] float timeToDelayLoad = 2f;

    private void Awake() {
        int numberOfObject = FindObjectsOfType<MusicPlayer>().Length;
        if(numberOfObject > 1) {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(WaitAndLoadNextScene());
    }

    // Update is called once per frame
    void Update() {

    }

    IEnumerator WaitAndLoadNextScene() {
        yield return new WaitForSeconds(timeToDelayLoad);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
