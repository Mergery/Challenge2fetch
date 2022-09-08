using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public int delaySpawn  = 3;  //  this serves as the initialization


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (delaySpawn >=3)  // it checks first whether time 
            {
            
            SpawnDog();

            }
        }
    }

    // create a new function to spawnDog to make code cleaner 
    void SpawnDog ()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        delaySpawn = Random.Range(0,1); // since they have already input their first command they have to wait betweeen a few  seconds before they spawn dogs again
        StartCoroutine(Interval());  // satrts execution of  whatever you place under IEnumarator in this case iNTERVAL is the name for our Ienumarator
    }

    IEnumerator Interval ()
    {
        // so here we are going to wait until 5 second mark
        while (delaySpawn<5) 
        {
        yield return new WaitForSeconds(1); // yield return 
        delaySpawn++;

        }
       
    
    }
}
