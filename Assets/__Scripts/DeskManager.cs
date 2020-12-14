using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Manages Spawning of Background Tiles
/// </summary>
public class DeskManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength =150;
    public int numberOfTiles = 3;
    private List<GameObject> activeTiles = new List<GameObject>();
    public Transform playerTransform;

    //Spawn Starting Tiles
    void Start(){
        for (int i = 0; i < numberOfTiles; i++){
            if(i == 0){
               SpawnTile(0);
               i++;
            }
            SpawnTile(Random.Range(0,tilePrefabs.Length));
        }        
    }

    //Spawn & Delete Tiles as the Player Moves Through the Map
    void Update(){
        if(playerTransform.position.z - 75 >zSpawn-(numberOfTiles * tileLength)){
            SpawnTile(Random.Range(0,tilePrefabs.Length));
            DeleteTile();
        }
    }
    //Spawn Tile from Prefab
    public void SpawnTile(int tileIndex){
        GameObject go = Instantiate(tilePrefabs[tileIndex],transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn +=tileLength;
    }
    //Deletes Tile from Array and Destroys Object 
    public void DeleteTile(){
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}