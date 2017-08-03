using System.Collections.Generic;
using UnityEngine;

//This class just test out the 'Matrix'.
//Docs for help:
//https://forum.unity3d.com/threads/c-arrays-with-multiple-types-of-data-at-each-point.144459/

public class CollectionTest : MonoBehaviour {

    //This is how you create a list. Notice how the type
    //is specified in the angle brackets (< >).
    List<SpawnerData> spawners = new List<SpawnerData>();
    // Use this for initialization
    void Start ()
    {
        //Here you initialize the List.
        spawners.Add(new SpawnerData(10));

        spawners[0].MonsterName[0] = "Cat";
        spawners[0].MonsterCantity[0] = 2;
        spawners[0].SpawnerID[0] = 2;

        spawners[0].MonsterName[1] = "Gárgola";
        spawners[0].MonsterCantity[1] = 2;
        spawners[0].SpawnerID[1] = 2;

        spawners[0].MonsterName[2] = "Nyx";
        spawners[0].MonsterCantity[2] = 2;
        spawners[0].SpawnerID[2] = 2;

        spawners[0].MonsterName[3] = "Demon";
        spawners[0].MonsterCantity[3] = 2;
        spawners[0].SpawnerID[3] = 2;

        for (int i = 0; i < spawners.Count; i++)
        {
            Debug.Log("En la oleada: " + i);
            for (int j = 0; j < spawners[i].MonsterCantity.Length; j++)
            {
                if (spawners[i].MonsterCantity[j] != 0)
                {
                    Debug.Log("En el Spawner " + spawners[i].SpawnerID[j] + " El monstruo " + "'" + spawners[i].MonsterName[j] + "'" + " Saldrá " + spawners[i].MonsterCantity[j] + " veces.");
                }
            }
            
        }
    }

}
