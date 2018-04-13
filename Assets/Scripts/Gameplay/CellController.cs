using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour
{
    [SerializeField] Vector2Int pos;

	void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    public void Setup (int x, int y)
    {
        pos.x = x;
        pos.y = y;
    }

    private void OnMouseEnter()
    {
        print("Cell " + pos.x + " " + pos.y);
    }
}
