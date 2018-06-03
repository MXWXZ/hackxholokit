using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityARInterface;
using System;


namespace HoloKit
{
    public class HoloKitPlacement : MonoBehaviour
    {
        public enum PlacePointer : int
        {
            CenterScreen = 0,
            Touch = 1
        }

        public UnityEvent onPlace = new UnityEvent();
        public UnityEvent onHide = new UnityEvent();

        public PlacePointer placePointer;
        public LayerMask placeMask;
        public bool isPlaceOnKey = true;
        public bool isPlaceOnTouch = true;
        public bool isRotateToCamera = false;
        public GameObject mainCamera;
        public bool flg = false;
        public GameObject d1,d2,d3,d4,d5,d6,d7,d8,d9;
        public Vector2 direction1 = new Vector2(1F, 1F);
        public Vector2 direction2 = new Vector2(1F, 1F);
        public Vector2 direction3 = new Vector2(1F, 1F);
        public Vector2 direction4 = new Vector2(1F, 1F);
        public Vector2 direction5 = new Vector2(1F, 1F);
        public Vector2 direction6 = new Vector2(1F, 1F);
        public Vector2 direction7 = new Vector2(1F, 1F);
        public Vector2 direction8 = new Vector2(1F, 1F);
        public Vector2 direction9 = new Vector2(1F, 1F);
        private void Start()
        {
            d1.SetActive(false);
            d2.SetActive(false);
            d3.SetActive(false);
            d4.SetActive(false);
            d5.SetActive(false);
            d6.SetActive(false);
            d7.SetActive(false);
            d8.SetActive(false);
            d9.SetActive(false);
        }
        private void Update()
        {
            
            if (!flg)
            {
                PlaceObject();
            }
            else
            {
                if (d1.transform.position[0] < -3 || d1.transform.position[0] > 3) { direction1[0] = -direction1[0]; }
                if (d1.transform.position[1] < -3 || d1.transform.position[1] > 3) { direction1[1] = -direction1[1]; }
                if (d2.transform.position[0] < -3 || d2.transform.position[0] > 3) { direction2[0] = -direction2[0]; }
                if (d2.transform.position[1] < -3 || d2.transform.position[1] > 3) { direction2[1] = -direction2[1]; }
                if (d3.transform.position[0] < -3 || d3.transform.position[0] > 3) { direction3[0] = -direction3[0]; }
                if (d3.transform.position[1] < -3 || d3.transform.position[1] > 3) { direction3[1] = -direction3[1]; }
                if (d4.transform.position[0] < -3 || d4.transform.position[0] > 3) { direction4[0] = -direction4[0]; }
                if (d4.transform.position[1] < -3 || d4.transform.position[1] > 3) { direction4[1] = -direction4[1]; }
                if (d5.transform.position[0] < -3 || d5.transform.position[0] > 3) { direction5[0] = -direction5[0]; }
                if (d5.transform.position[1] < -3 || d5.transform.position[1] > 3) { direction5[1] = -direction5[1]; }
                if (d6.transform.position[0] < -3 || d6.transform.position[0] > 3) { direction6[0] = -direction6[0]; }
                if (d6.transform.position[1] < -3 || d6.transform.position[1] > 3) { direction6[1] = -direction6[1]; }
                if (d7.transform.position[0] < -3 || d7.transform.position[0] > 3) { direction7[0] = -direction7[0]; }
                if (d7.transform.position[1] < -3 || d7.transform.position[1] > 3) { direction7[1] = -direction7[1]; }
                if (d8.transform.position[0] < -3 || d8.transform.position[0] > 3) { direction8[0] = -direction8[0]; }
                if (d8.transform.position[1] < -3 || d8.transform.position[1] > 3) { direction8[1] = -direction8[1]; }
                if (d9.transform.position[0] < -3 || d9.transform.position[0] > 3) { direction9[0] = -direction9[0]; }
                if (d9.transform.position[1] < -3 || d9.transform.position[1] > 3) { direction9[1] = -direction9[1]; }
                float speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                float speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d1.transform.position = new Vector3(d1.transform.position.x + speedx * direction1[0], d1.transform.position.y, d1.transform.position.z + speedz * direction1[1]);
                speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d2.transform.position = new Vector3(d2.transform.position.x + speedx * direction2[0], d2.transform.position.y, d2.transform.position.z + speedz * direction2[1]);
                speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d3.transform.position = new Vector3(d3.transform.position.x + speedx * direction3[0], d3.transform.position.y, d3.transform.position.z + speedz * direction3[1]);
                speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d4.transform.position = new Vector3(d4.transform.position.x + speedx * direction4[0], d4.transform.position.y, d4.transform.position.z + speedz * direction4[1]);
                speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d5.transform.position = new Vector3(d5.transform.position.x + speedx * direction5[0], d5.transform.position.y, d5.transform.position.z + speedz * direction5[1]);
                speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d6.transform.position = new Vector3(d6.transform.position.x + speedx * direction6[0], d6.transform.position.y, d6.transform.position.z + speedz * direction6[1]);
                speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d7.transform.position = new Vector3(d7.transform.position.x + speedx * direction7[0], d7.transform.position.y, d7.transform.position.z + speedz * direction7[1]);
                speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d8.transform.position = new Vector3(d8.transform.position.x + speedx * direction8[0], d8.transform.position.y, d8.transform.position.z + speedz * direction8[1]);
                speedx = UnityEngine.Random.Range(-100, 100) / 1000F;
                speedz = UnityEngine.Random.Range(-100, 100) / 1000F;
                d9.transform.position = new Vector3(d9.transform.position.x + speedx * direction9[0], d9.transform.position.y, d9.transform.position.z + speedz * direction9[1]);
                Catch();
            }
        }

        private void PlaceObject()
        {
            Vector2 screenPoint = Vector2.zero;
            Camera camera = HoloKitCamera.Instance.cameraCenter;

            switch (placePointer)
            {
                case PlacePointer.CenterScreen:
                    screenPoint = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
                    break;
                case PlacePointer.Touch:
                    screenPoint = Input.touches[0].position;
                    break;
            }

            if (HoloKitUITool.IsOverUI(Input.touches[0].position))
                return;

            Ray ray = camera.ScreenPointToRay(screenPoint);
            RaycastHit rayHit;
            if (Physics.Raycast(ray, out rayHit, float.MaxValue, placeMask))
            {
                if (onPlace != null)
                    onPlace.Invoke();
                d1.SetActive(true);
                d2.SetActive(true);
                d3.SetActive(true);
                d4.SetActive(true);
                d5.SetActive(true);
                d6.SetActive(true);
                d7.SetActive(true);
                d8.SetActive(true);
                d9.SetActive(true);
                d1.transform.position = new Vector3(rayHit.point.x - 1, rayHit.point.y, rayHit.point.z - 1);
                d2.transform.position = new Vector3(rayHit.point.x - 1, rayHit.point.y, rayHit.point.z);
                d3.transform.position = new Vector3(rayHit.point.x - 1, rayHit.point.y, rayHit.point.z + 1);
                d4.transform.position = new Vector3(rayHit.point.x, rayHit.point.y, rayHit.point.z - 1);
                d5.transform.position = new Vector3(rayHit.point.x, rayHit.point.y, rayHit.point.z + 1);
                d6.transform.position = new Vector3(rayHit.point.x + 1, rayHit.point.y, rayHit.point.z - 1);
                d7.transform.position = new Vector3(rayHit.point.x + 1, rayHit.point.y, rayHit.point.z);
                d8.transform.position = new Vector3(rayHit.point.x + 1, rayHit.point.y, rayHit.point.z + 1);
                d9.transform.position = new Vector3(rayHit.point.x + 0.3F, rayHit.point.y, rayHit.point.z + 0.3F);
                flg = true;
            }
        }
        private void Catch() {
            Camera camera = HoloKitCamera.Instance.cameraCenter;
            Vector2 screenPoint = Input.touches[0].position;
            Ray ray = Camera.main.ScreenPointToRay(screenPoint);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f))
            {
                GameObject obj = hit.collider.gameObject;
                obj.SetActive(false);
            }
        }
    }
}