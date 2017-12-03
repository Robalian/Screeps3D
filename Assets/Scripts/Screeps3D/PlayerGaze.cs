﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace Screeps3D
{
    public class PlayerGaze : MonoBehaviour
    {
        [SerializeField] private ScreepsAPI api;

        private void Update()
        {
            if (!api || !api.IsConnected)
            {
                return;
            }

            var ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
            if (!EventSystem.current.IsPointerOverGameObject() && Input.GetMouseButtonUp(0))
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            }

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 200))
            {
                var roomView = hit.collider.GetComponent<RoomView>();
                if (roomView == null)
                {
                    return;
                }

                roomView.Target();
            }
        }
    }
}