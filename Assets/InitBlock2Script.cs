using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlock2Script : MonoBehaviour {

    public GameObject blockBlue;
    public GameObject blockGreen;
    public GameObject blockRed;
    public GameObject blockYellow;
    public GameObject blockPink;
    public static int gridX = 10;
    public static int gridY = 2;
    int xStart;
   


    // Use this for initialization
    void Start()
    {
        MainCameraScript.countInitBlock = 0;
        int numberOfObjects1 = 30;
        float radius2 = 50f;
        initBlocks(numberOfObjects1, radius2, blockGreen, blockPink);
        numberOfObjects1 = 15;
        radius2 = 40f;
        initBlocks(numberOfObjects1, radius2, blockYellow, blockRed);
        numberOfObjects1 = 10;
        radius2 = 30f;
        initBlocks(numberOfObjects1, radius2, blockBlue, blockYellow);
        numberOfObjects1 = 10;
        radius2 = 20f;
        initBlocks(numberOfObjects1, radius2, blockYellow, blockBlue);
        numberOfObjects1 = 4;
        radius2 = 10f;
        initBlocks(numberOfObjects1, radius2, blockYellow, blockBlue);

       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void initBlocks(int numberOfObjects, float radius, GameObject block1, GameObject block2)
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            Vector3 pos = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * radius;
            if (i % 2 == 0)
            {
                Instantiate(block1, pos, Quaternion.identity);
            }
            else
            {
                Instantiate(block2, pos, Quaternion.identity);
            }
            MainCameraScript.countInitBlock ++;
        }

    }
}
