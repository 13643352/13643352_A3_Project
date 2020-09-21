﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int[,] levelMap;
    // public int i, j;
    public GameObject outCorner;
    public GameObject outWall;
    public GameObject inCorner;
    public GameObject inWall;
    public GameObject normalPellet;
    public GameObject powerPellet;
    public GameObject tJunction;

    // Start is called before the first frame update
    void Start()
    {
        //int [,] levelMap =
        //{
        //     {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        //     {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        //     {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        //     {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        //     {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        //     {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        //     {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        //     {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        //     {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        //     {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        //     {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        //     {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        //     {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        //     {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        //     {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        //};
        int[,] levelMap =
        {
             {1,2,2,2,2,2,2,2,2,2,2,2,2,7,7,2,2,2,2,2,2,2,2,2,2,2,2,1},
             {2,5,5,5,5,5,5,5,5,5,5,5,5,4,4,5,5,5,5,5,5,5,5,5,5,5,5,2},
             {2,5,3,4,4,3,5,3,4,4,4,3,5,4,4,5,3,4,4,4,3,5,3,4,4,3,5,2},
             {2,6,4,0,0,4,5,4,0,0,0,4,5,4,4,5,4,0,0,0,4,5,4,0,0,4,6,2},
             {2,5,3,4,4,3,5,3,4,4,4,3,5,3,3,5,3,4,4,4,3,5,3,4,4,3,5,2},
             {2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2},
             {2,5,3,4,4,3,5,3,3,5,3,4,4,4,4,4,4,3,5,3,3,5,3,4,4,3,5,2},
             {2,5,3,4,4,3,5,4,4,5,3,4,4,3,3,4,4,3,5,4,4,5,3,4,4,3,5,2},
             {2,5,5,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,5,5,2},
             {1,2,2,2,2,1,5,4,3,4,4,3,0,4,4,0,3,4,4,3,4,5,1,2,2,2,2,1},
             {0,0,0,0,0,2,5,4,3,4,4,3,0,3,3,0,3,4,4,3,4,5,2,0,0,0,0,0},
             {0,0,0,0,0,2,5,4,4,0,0,0,0,0,0,0,0,0,0,4,4,5,2,0,0,0,0,0},
             {0,0,0,0,0,2,5,4,4,0,3,4,4,0,0,4,4,3,0,4,4,5,2,0,0,0,0,0},
             {2,2,2,2,2,1,5,3,3,0,4,0,0,0,0,0,0,4,0,3,3,5,1,2,2,2,2,2},
             {0,0,0,0,0,0,5,0,0,0,4,0,0,0,0,0,0,4,0,0,0,5,0,0,0,0,0,0},
             {2,2,2,2,2,1,5,3,3,0,4,0,0,0,0,0,0,4,0,3,3,5,1,2,2,2,2,2},
             {0,0,0,0,0,2,5,4,4,0,3,4,4,0,0,4,4,3,0,4,4,5,2,0,0,0,0,0},
             {0,0,0,0,0,2,5,4,4,0,0,0,0,0,0,0,0,0,0,4,4,5,2,0,0,0,0,0},
             {0,0,0,0,0,2,5,4,3,4,4,3,0,3,3,0,3,4,4,3,4,5,2,0,0,0,0,0},
             {1,2,2,2,2,1,5,4,3,4,4,3,0,4,4,0,3,4,4,3,4,5,1,2,2,2,2,1},
             {2,5,5,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,5,5,2},
             {2,5,3,4,4,3,5,4,4,5,3,4,4,3,3,4,4,3,5,4,4,5,3,4,4,3,5,2},
             {2,5,3,4,4,3,5,3,3,5,3,4,4,4,4,4,4,3,5,3,3,5,3,4,4,3,5,2},
             {2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2},
             {2,5,3,4,4,3,5,3,4,4,4,3,5,3,3,5,3,4,4,4,3,5,3,4,4,3,5,2},
             {2,6,4,0,0,4,5,4,0,0,0,4,5,4,4,5,4,0,0,0,4,5,4,0,0,4,6,2},
             {2,5,3,4,4,3,5,3,4,4,4,3,5,4,4,5,3,4,4,4,3,5,3,4,4,3,5,2},
             {2,5,5,5,5,5,5,5,5,5,5,5,5,4,4,5,5,5,5,5,5,5,5,5,5,5,5,2},
             {1,2,2,2,2,2,2,2,2,2,2,2,2,7,7,2,2,2,2,2,2,2,2,2,2,2,2,1},
        };
        // levelMap = new int[i, j];

        for (int i = 0; i < levelMap.GetLength(0); i++)
        {
            for (int j = 0; j < levelMap.GetLength(1); j++)
            {
                if (levelMap[i, j] == 0)
                { }
                if (levelMap[i, j] == 1)
                {
                    Instantiate(outCorner, new Vector2(i, j), Quaternion.Euler(0f, 0f, 0f));
                }
                if (levelMap[i, j] == 2)
                {
                    Instantiate(outWall, new Vector2(i, j), Quaternion.Euler(0f, 0f, 0f));
                }
                if (levelMap[i, j] == 3)
                {
                    Instantiate(inCorner, new Vector2(i, j), Quaternion.Euler(0f, 0f, 0f));
                }
                if (levelMap[i, j] == 4)
                {
                    Instantiate(inWall, new Vector2(i, j), Quaternion.Euler(0f, 0f, 0f));
                }
                if (levelMap[i, j] == 5)
                {
                    Instantiate(normalPellet, new Vector2(i, j), Quaternion.identity);
                }
                if (levelMap[i, j] == 6)
                {
                    Instantiate(powerPellet, new Vector2(i, j), Quaternion.identity);
                }
                if (levelMap[i, j] == 7)
                {
                    Instantiate(tJunction, new Vector2(i, j), Quaternion.Euler(0f, 0f, 0f));
                }
            }
        }

        //for (int i = levelMap.GetLength(0) - 2; i >= 0; i--)
        //{
        //    for (int j = 0; j < levelMap.GetLength(1); j++)
        //    {
        //        if (levelMap[i, j] == 0)
        //        { }
        //        if (levelMap[i, j] == 1)
        //        {
        //            Instantiate(outCorner, new Vector2(i, j), Quaternion.Euler(0f, 0f, 90f));
        //        }
        //        if (levelMap[i, j] == 2)
        //        {
        //            Instantiate(outWall, new Vector2(i, j), Quaternion.Euler(0f, 0f, 90f));
        //        }
        //        if (levelMap[i, j] == 3)
        //        {
        //            Instantiate(inCorner, new Vector2(i, j), Quaternion.Euler(0f, 0f, 90f));
        //        }
        //        if (levelMap[i, j] == 4)
        //        {
        //            Instantiate(inWall, new Vector2(i, j), Quaternion.Euler(0f, 0f, 90f));
        //        }
        //        if (levelMap[i, j] == 5)
        //        {
        //            Instantiate(normalPellet, new Vector2(i, j), Quaternion.identity);
        //        }
        //        if (levelMap[i, j] == 6)
        //        {
        //            Instantiate(powerPellet, new Vector2(i, j), Quaternion.identity);
        //        }
        //        if (levelMap[i, j] == 7)
        //        {
        //            Instantiate(tJunction, new Vector2(i, j), Quaternion.Euler(0f, 0f, 90f));
        //        }
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
