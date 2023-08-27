using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class day2 : MonoBehaviour
{ 
    string heroname = "khaled";
    int heroPower = 200;

    string villainName = "ali";
    int villairPower = 200;

    float playerSpeed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villairPower)
        {
            print("khaled better then ali");
        }
        else if (heroPower == villairPower)
        {
            print("khaled = ali");
        }
        else if (heroPower < villairPower)
        {
            print("ali better then khaled");
        }
        print (playerSpeed is 100.5f);
    }
    void sitspeed(float speed)
    {
    float playerSpeed = 2.5f;
        speed = playerSpeed; 
    }
    // Update is called once per frame
    void Update()
 
    {
        
    }
}
