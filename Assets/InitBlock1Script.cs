using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlock1Script : MonoBehaviour {

    public GameObject blockBlue;
    public GameObject blockGreen;
    public GameObject blockRed;
    public GameObject blockYellow;
    public GameObject blockPink;
    public static int gridX = 10;
    public static int gridY = 2;
    int xStart;

    // Use this for initialization
    void Start () {
        gridX = 10;
        xStart = -75;
        MainCameraScript.countInitBlock = 0;
        initBlocks();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void initBlocks()
    {
        int y = 93;
        int x = -75;
        for (int k = 0; k < gridY; k++, y-=10)
        {
            for (int t = 0; t < gridX; t++, x+=17)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(blockBlue, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            gridX -= 2;
            x = xStart += 17;
        }
        for (int k = 0; k < gridY; k++, y -= 10)
        {
            for (int t = 0; t < gridX; t++, x += 17)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(blockGreen, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            gridX -= 2;
            x = xStart += 17;
        }      
        for (int k = 0; k < gridY; k++, y -= 10)
        {
            for (int t = 0; t < gridX; t++, x += 17)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(blockPink, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            x = xStart;
        }
        gridX += 2;
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
        for (int k = 0; k < gridY; k++, y -= 10)
        {
            for (int t = 0; t < gridX; t++, x += 17)
            {
                Vector3 pos = new Vector3(x, y, 0);
                Instantiate(blockRed, pos, Quaternion.identity);
                MainCameraScript.countInitBlock++;
            }
            gridX += 2;
            x = xStart -= 17;
        }
    }
}
