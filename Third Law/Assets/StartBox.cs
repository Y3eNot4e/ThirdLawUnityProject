using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        GameObject.Find("Canvas").SendMessage("StartTimer");
    }
}
