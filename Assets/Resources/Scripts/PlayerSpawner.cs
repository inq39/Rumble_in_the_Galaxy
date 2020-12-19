using System;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour 
{
	SOActorModel actorModel;
	GameObject playerShip;

	// Use this for initialization
	void Start () {
		
		CreatePlayer();
	}

    private void CreatePlayer()
    {
		//Create Player
		actorModel = GameObject.Instantiate(Resources.Load("Script/ScriptableObject/Player_Default")) as SOActorModel;

		playerShip = GameObject.Instantiate(actorModel.actor) as GameObject;
		playerShip.GetComponent<Player>().ActorStats(actorModel);

		//Set Player Up
		playerShip.transform.rotation = Quaternion.Euler(0, 180, 0);
		playerShip.transform.localScale = new Vector3(60, 60, 60);
		playerShip.name = "Player";
		playerShip.transform.SetParent(this.transform);
		playerShip.transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
