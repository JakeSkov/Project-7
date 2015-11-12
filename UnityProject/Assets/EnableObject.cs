using UnityEngine;
using System.Collections;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: EnableObject 
/// </summary>
public class EnableObject : MonoBehaviour {
    #region Fields

    public GameObject toEnable;

    #endregion

    void Start() {
        toEnable.SetActive(true);
    }

    void Update() { }

}