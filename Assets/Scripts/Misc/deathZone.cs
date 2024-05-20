using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathZone : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D truc) {
        if (truc.tag == "Player") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
