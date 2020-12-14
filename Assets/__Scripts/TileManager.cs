using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Manages the Rate, Position and Pattern of Prefab Tile Spawning to make the track/// </summary>
public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public GameObject shield;
    public float zSpawn = 0;
    public float tileLength =10;
    public int numberOfTiles = 10;
    public float shieldRate = 5;
    private int count =0;
    private List<GameObject> activeTiles = new List<GameObject>();
    private List<GameObject> activeShields = new List<GameObject>();
    public Transform playerTransform;

//Spawns Starting Tiles
    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if(i == 0){
                SpawnTile(0);
                i++;
            }
           else if(i%shieldRate == 0){
                SpawnShield();   
            }
            SpawnTile(Random.Range(1,tilePrefabs.Length));       
        }
    }

//Controls spawning and deleting of tiles based on player movement
    void Update()
    {
        if(playerTransform.position.z - 35 >zSpawn-(numberOfTiles * tileLength)){
            SpawnTile(Random.Range(0,tilePrefabs.Length));
            DeleteTile();
            count++;
        }

        if(count == shieldRate){
            SpawnShield();
            DeleteShields();
            count =0;
        }
    }
//Spawns Tiles
    public void SpawnTile(int tileIndex){
        GameObject go = Instantiate(tilePrefabs[tileIndex],transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn +=tileLength;
    }
//Spawns Shields
    public void SpawnShield(){
        GameObject go = Instantiate(shield,transform.forward * zSpawn,transform.rotation);
        activeShields.Add(go);
        go.transform.position =  new Vector3(0,1,zSpawn);
    }
//Deletes Tiles
    public void DeleteTile(){
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
//Deletes Shields
    public void DeleteShields(){
        activeShields.RemoveAt(0);
    }
}
