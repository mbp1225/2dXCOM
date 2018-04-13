using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [SerializeField] Vector2Int gridSize;
    [SerializeField] GameObject gridCell;

    [SerializeField] GameObject[,] grid;
    [SerializeField] GameObject[,] gridContents;

    void Start ()
    {
        grid = new GameObject[gridSize.x, gridSize.y];
        gridContents = new GameObject[gridSize.x, gridSize.y];
        CreateGrid();
        transform.position += new Vector3(- (float)gridSize.x / 2, - (float)gridSize.y / 2);
	}
	
	void Update ()
    {
		
	}

    void CreateGrid()
    {
        for (int i = 0; i < gridSize.x; i++)
        {
            for (int j = 0; j < gridSize.y; j++)
            {
                grid[i, j] = Instantiate(gridCell, new Vector2(i + .5f, j + .5f), Quaternion.identity, transform) as GameObject;
                grid[i, j].GetComponent<CellController>().Setup(i, j);
            }
        }
    }
}
