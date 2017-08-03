
// The data class for be used in a ArrayList, List, Array, etc. 
// Useful for storing multiple types of data and for this time I wanted to implement a multdimensional, multityped class for be used in a List.

public class SpawnerData{

    private string[] monsterName;
    private int[] monsterCantity;
    private int[] spawnerID;

    public SpawnerData(int arrayDimension)
    {
        Init(arrayDimension);
    }

    private void Init(int arrayDimension)
    {
        monsterCantity = new int[arrayDimension];
        spawnerID = new int[arrayDimension];
        MonsterName = new string[arrayDimension];
    }

    public string[] MonsterName
    {
        get
        {
            return monsterName;
        }

        set
        {
            monsterName = value;
        }
    }

    public int[] MonsterCantity
    {
        get
        {
            return monsterCantity;
        }

        set
        {
            monsterCantity = value;
        }
    }

    public int[] SpawnerID
    {
        get
        {
            return spawnerID;
        }

        set
        {
            spawnerID = value;
        }
    }
}
