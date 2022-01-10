using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GridManager : MonoBehaviour
{
	private int[,] grid;
	private int vertical;
	private int horizontal;
	private int columns;
	private int rows;
	public Sprite square;
	
	void Start()
    {
	    vertical = (int) Camera.main.orthographicSize; // 5
	    
	    horizontal = 9;
	    /*
	     * Should be 9, dont know the forumla to make it dynamic. Should be something like
	     * 1920 / 1080 = 1,7778 ---> 1,7778 * 5 = 8,8889 which is rounded to 9, but unity
	     * doesnt like it and rounds something before the whole calculation is completed.
	     * I assume this is because vertical is declared as int, but I cannot change that. It
	     * needs to be int. 
	     */
	    
	    columns = horizontal * 2;
	    rows = vertical * 2;
	    grid = new int[columns, rows];

	    for (int i = 0; i < columns; i++)
	    {
		    for (int j = 0; j < rows; j++)
		    {
			    //grid[i, j] = Random.Range(0, 10);
			    //SpawnTile(i, j, grid[i,j]);
			    SpawnTile(i, j);
		    }
	    }
    }

    //private void SpawnTile(int x, int y, int value)
    private void SpawnTile(int x, int y)
    {
	    GameObject g = new GameObject("X: " + x + ", Y: " + y);
	    g.transform.position = new Vector3(x - (horizontal - 0.5f), y - (vertical - 0.5f));
	    SpriteRenderer s = g.AddComponent<SpriteRenderer>();
	    s.sprite = square;
	    s.color = new Color((float) Random.Range(0.1f, 0.9f), (float) Random.Range(0.1f, 0.9f),
		    (float) Random.Range(0.1f, 0.9f));
    }
    
}
