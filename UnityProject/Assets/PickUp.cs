using UnityEngine;
using System.Collections;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: PickUp 
/// </summary>
public class PickUp : MonoBehaviour {
    #region Fields

    public Transform pickUpTransform;
    bool hasFlag = false;
    int score = 0;
    #endregion

    void Start() { }

    void Update() { }

    void OnTriggerEnter(Collider other) {

        switch (other.tag) {
            case "Flag":
                other.transform.parent = this.transform;
                other.transform.position = pickUpTransform.position;
                hasFlag = true;
                break;
            case "PickUpObject":
                print("picked up " + other.name);
                break;
            case "FlagDrop":
                hasFlag = false;
                score++;
                break;
        }
    }

}