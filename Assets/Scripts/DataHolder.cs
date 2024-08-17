using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder : MonoBehaviour
{

    public GameObject furniture;
    public static DataHolder instance;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null)
        {
            instance = this;
        }
        
    }

    public GameObject GetFurniture()
    {
        return furniture;
    }



}
