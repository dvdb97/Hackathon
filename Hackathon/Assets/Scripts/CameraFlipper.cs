using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFlipper : MonoBehaviour {

    //Die Frequenz (Wartezeit in Sekunden), in der die Kamera gekippt werden soll.
    public float Frequency = 10f;
    private float timeStamp;
    private int oldRotation;

	// Use this for initialization
	void Start () {
        timeStamp = Time.time;
        oldRotation = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= timeStamp + Frequency)
        {
            int randomRotation = Random.Range(0, 3);

            while (randomRotation == oldRotation)
            {
                randomRotation = Random.Range(0, 3);
            }

            transform.rotation = Quaternion.Euler(0, 0, randomRotation * 90f);

            timeStamp = Time.time;
        }
	}
}
