using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    
	// Use this for initialization
	void Start () {

		SetupCamera();
        SetupLight();
	}

    

    private void SetupCamera()
    {
        GameObject gameCamera = GameObject.FindGameObjectWithTag("MainCamera");

        gameCamera.transform.position = new Vector3(0, 0, -300);
        gameCamera.transform.eulerAngles = new Vector3(0, 0, 0);

        gameCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor; // solid color for background
        gameCamera.GetComponent<Camera>().backgroundColor = new Color32(0, 0, 0, 255); // background.color = black
    }

    private void SetupLight()
    {
        GameObject directionalLight = GameObject.Find("Directional Light");

        directionalLight.transform.eulerAngles = new Vector3(50, -30, 0);
        directionalLight.GetComponent<Light>().color = new Color32(152, 204, 255, 255);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
