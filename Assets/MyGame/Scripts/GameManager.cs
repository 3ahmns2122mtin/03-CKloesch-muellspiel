using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject parentOfTargets;

  
    void Start()
    {
        InvokeRepeating("Spawn", 6f, 8f);
    }


    private void Spawn()
    {
        float randomX = Random.Range(-370, 370);
        float randomY = Random.Range(470, 470);


        Vector2 random2DPosition = new Vector2(randomX, randomY);


        GameObject myTarget = Instantiate(target, parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPosition;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
