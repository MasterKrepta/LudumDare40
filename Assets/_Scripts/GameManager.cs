using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private float timeToSpawn = 30f;

    private float currentTime;
    bool countDown = true;
    public delegate void PlayerEvents();
    
    public static event PlayerEvents AddHuman;
    public static event PlayerEvents PlaceWorker;
    public static event PlayerEvents SpawnHumans;
    public static event PlayerEvents UpdateStats;
    
    
    public void CallAddHuman() {
        AddHuman();
    }

    public void CallPlaceWorker() {
        PlaceWorker();
    }
    public void CallSpawnHumans() {
        SpawnHumans();
    }
    public void CallSpawnover() {
        WorkerMode();
    }

    public void CallUpdateStats() {
        UpdateStats();
    }

    private void WorkerMode() {
        while (timeToSpawn <=0) {
            //TODO make avisual timer to countdown on screen
            currentTime -= Time.deltaTime;

            if (timeToSpawn <= 0) {
                currentTime = timeToSpawn;
                CallSpawnHumans();
            }
        }
        

        
    }
}
