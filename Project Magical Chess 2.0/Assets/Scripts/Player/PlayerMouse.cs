using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouse : MonoBehaviour
{
    //CONTROL MOUSE INPUT
    //
    private Vector3Int previousMousePos = new Vector3Int();
    [SerializeField] LayerMask interactLayer;


    private void Update()
    {
        MouseHover();
        MouseInput();
    }

    void MouseHover()
    {
        Vector3Int mousePos = Utils.GetMousePositionInt(GridHandler.instance.groundMap);
        if (!mousePos.Equals(previousMousePos))
        {



            if (GridHandler.instance.groundMap.HasTile(mousePos))
            {
                GridHandler.instance.highlighterMap.SetTile(previousMousePos, null);
                GridHandler.instance.highlighterMap.SetTile(new Vector3Int(mousePos.x, mousePos.y, mousePos.z), GridHandler.instance.highlighterTile);
                previousMousePos = mousePos;
                Debug.Log("something else");
            }
            else
            {
                GridHandler.instance.highlighterMap.ClearAllTiles();
                
            }
            //THEN THAT MEANS THAT WE SWITCH THE PLACE OF THE INTERACT MOUSE.




        }
    }
    void MouseInput()
    {
        //WHAT THINGS CAN WE CLICK.
        //UNITS
        //OBJECTS


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, interactLayer);


        if (hit.collider == null) return;
  
        if (Input.GetMouseButtonDown(0))
        {
            //TRY TO GET INFO
            HandleInfo(hit.collider.gameObject);
        }
        if (Input.GetMouseButtonDown(1))
        {
            //TRY TO GET CONTROL
            HandleControl(hit.collider.gameObject);
        }
    }

    #region HANDLE INPUT
    void HandleInfo(GameObject target)
    {
        //WE GET INFO ABOUT THE TARGET.


    }
    void HandleControl(GameObject target)
    {
        //WE GET CONTROL FROM THE TARGET.

        if (target.GetComponent<UnitHolder>() != null) HandleUnitControl(target.GetComponent<UnitHolder>());

    }
    void HandleUnitControl(UnitHolder unit)
    {
        //WHEN WE GET CONTROL FROM AN UNIT.
        //


    }
    #endregion
}
