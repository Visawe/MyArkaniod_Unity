using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlock3Script : MonoBehaviour {

    public GameObject moveBlock;
    public GameObject blockBlue;
    public GameObject blockGreen;
    public GameObject blockRed;
    public GameObject blockYellow;
    public GameObject blockPink;
    public static int gridX = 10;
    public static int gridY = 3;
    int xStart;

    // Use this for initialization
    void Start()
    {
        gridX = 10;
        xStart = -75;
        MainCameraScript.countInitBlock = 0;
        initBlocks();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void initBlocks()
    {
        
        int x = -86;
        int y = 100;
        
        for (int k = 0; k < gridY; k++, y -= 10)
        {
            for (int t = 0; t < 5; t++, x += 33)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(moveBlock, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            gridX -= 1;
            x = xStart += 17;
        }
        gridX -= 1;
        x = xStart -= 17;
        for (int k = 0; k < gridY; k++, y -= 10)
        {
            for (int t = 0; t < gridX; t++, x += 17)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(blockYellow, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            gridX += 2;
            x = xStart -= 17;
        }
        x = xStart += 17;
        gridX -= 2;
        for (int k = 0; k < gridY; k++, y -= 10)
        {
            for (int t = 0; t < gridX; t++, x += 17)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(blockRed, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            gridX -= 2;
            x = xStart += 17;
        }
        x = -86;
        for (int k = 0; k < 2; k++, y -= 10)
        {
            for (int t = 0; t < 2; t++, x += 172)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(moveBlock, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            x = -86;
        }
        for (int k = 0; k < 6; k++, y -= 10)
        {
            for (int t = 0; t < 2; t++, x += 17)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(blockGreen, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            x = -86;
        }
        y += 60;
        x = 70;
        for (int k = 0; k < 6; k++, y -= 10)
        {
            for (int t = 0; t < 2; t++, x += 17)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(blockGreen, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            x = 70;
        }
        Vector3 pos1 = new Vector3(-87, -106, 0);
        Instantiate(blockPink, pos1, Quaternion.identity);
        MainCameraScript.countInitBlock++;
        Vector3 pos2 = new Vector3(87, -106, 0);
        Instantiate(blockPink, pos2, Quaternion.identity);
        MainCameraScript.countInitBlock++;
    }
}
