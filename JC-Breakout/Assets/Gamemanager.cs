using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject brickPrefab;
    public float xSpace;
    // Start is called before the first frame update
    void Start()
    {
        for(int x=0;x<10;x++)
        {
            Instantiate(brickPrefab, new Vector2(x,3), Quaternion.identity);
        }
    }
}   
