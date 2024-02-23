using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreTxt;
  
    void Update()
    {
     
            scoreTxt.text = player.position.x.ToString("0");
  
    }
}
