﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength =150;
    public int numberOfTiles = 3;
    private List<GameObject> activeTiles = new List<GameObject>();
    public Transform playerTransform;

    void Start(){
        for (int i = 0; i < numberOfTiles; i++){
            if(i == 0){
               SpawnTile(0);
               i++;
            }
            SpawnTile(Random.Range(0,tilePrefabs.Length));
        }        
    }

    void Update(){
        if(playerTransform.position.z - 75 >zSpawn-(numberOfTiles * tileLength)){
            SpawnTile(Random.Range(0,tilePrefabs.Length));
            DeleteTile();
        }
    }

    public void SpawnTile(int tileIndex){
        GameObject go = Instantiate(tilePrefabs[tileIndex],transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn +=tileLength;
    }

    public void DeleteTile(){
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}