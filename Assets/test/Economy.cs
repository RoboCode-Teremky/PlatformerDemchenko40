using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{
    private static int coins = 0;
    public static void AddCoin(){
        coins++;
    }
    public static int GetCoin(){
        return coins;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
