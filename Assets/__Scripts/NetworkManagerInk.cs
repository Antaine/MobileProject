using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Manages Multiplayer Connections
/// </summary>
namespace Mirror.InkRun
{
    [AddComponentMenu("")]
    public class NetworkManagerInk : NetworkManager
    {
        public Transform firstPlayerSpawn;
        public Transform secondPlayerpawn;

        public override void OnServerAddPlayer(NetworkConnection conn){
            // Add player at correct spawn position
            Transform start = numPlayers == 0 ? firstPlayerSpawn : secondPlayerpawn;
            GameObject player = Instantiate(playerPrefab, start.position, start.rotation);
            NetworkServer.AddPlayerForConnection(conn, player);
            //Pause Game
            Time.timeScale = 0f;
            if (numPlayers == 2){
                //Play
                    Time.timeScale = 1f;
                }
        }
        //On Disconnect
        public override void OnServerDisconnect(NetworkConnection conn){
            base.OnServerDisconnect(conn);
        }
    }
}
