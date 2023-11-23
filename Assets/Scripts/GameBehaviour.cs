using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    public BackgroundScroll bg1, bg2;
    public GameObject Coin;
    public GameObject Wall;
    public GameObject GOText;
    public PlayerMovement pm;
    private float coinSpawnTime, coinTimeBetweenSpawn;
    private float wallSpawnTime, wallTimeBetweenSpawn;
    bool running;

    // Start is called before the first frame update
    void Start() {
        running = true;
        coinTimeBetweenSpawn = 4;
        wallTimeBetweenSpawn = 2;
        pm.enabled = true;
        bg1.enabled = true;
        bg2.enabled = true;
    }

    // Update is called once per frame
    void Update() {
        if(running) {

            if (Time.time > coinSpawnTime)
            {
                StartCoroutine(CoinSpawn(coinTimeBetweenSpawn));
                coinSpawnTime = Time.time + coinTimeBetweenSpawn;
            }

            if (Time.time > wallSpawnTime)
            {
                StartCoroutine(WallSpawn(wallTimeBetweenSpawn));
                wallSpawnTime = Time.time + wallTimeBetweenSpawn;
            }
            
        }
    }

    private IEnumerator CoinSpawn(float tbs) {
        yield return new WaitForSeconds(tbs);

        float x;
        int random = Random.Range(0,4);

        if (random == 0) {
            x = -2.5f;
        } else if (random == 1) {
            x = 0;
        } else {
            x = 2.5f;
        }

        Instantiate(Coin, new Vector3(x, 10, 0), Quaternion.identity);
    }

    private IEnumerator WallSpawn(float tbs) {
        yield return new WaitForSeconds(tbs);

        float x;
        int random = Random.Range(0,4);

        if (random == 0) {
            x = -2.5f;
        } else if (random == 1) {
            x = 0;
        } else {
            x = 2.5f;
        }

        Instantiate(Wall, new Vector3(x, 10, 0), Quaternion.identity);
    }

    public void GameOver() {
        GOText.SetActive(true);
        running = false;
        pm.enabled = false;
        bg1.enabled = false;
        bg2.enabled = false;
    }
}
