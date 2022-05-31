using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public static class Utils
{

    #region POSITIONS
    public static Vector3Int GetMousePositionInt(Tilemap map)
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 newMousePos = new Vector3(mouseWorldPos.x + 1 , mouseWorldPos.y + 1, -5);
        Vector3Int gridPos = GetGridPos(map, newMousePos);
        return gridPos;
    }   


    public static Vector3 GetWorldPos(Tilemap map, Vector3Int target)
    {
        return map.CellToWorld(target);
    }
    public static Vector3Int GetGridPos(Tilemap map, Vector3 target)
    {
        return map.WorldToCell(target);
    }

    #endregion
}
