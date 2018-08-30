using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitAttachToMouse : MonoBehaviour {


    private GameObject target;
    private bool _mouseState;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hitInfo;
            target = GetObjectOnClick(out hitInfo);
            if(target != null)
            {
                _mouseState = true;
          
            }

        }
        if(Input.GetMouseButtonUp(0))
        {
            _mouseState = false;

        }
        if(_mouseState)
        {
            Vector2 curscreenSpace = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 curPos = Camera.main.ScreenToWorldPoint(curscreenSpace);
            target.transform.position = curPos;
        }
    }

    GameObject GetObjectOnClick(out RaycastHit2D hitInfo)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hitInfo = Physics2D.Raycast(ray.origin, ray.direction);
        if (hitInfo)
        {
            target = hitInfo.collider.gameObject;
        }
        return target;
    }
}
