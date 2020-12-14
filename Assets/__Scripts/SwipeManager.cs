﻿using UnityEngine;
/// <summary>
/// Handles Input as swiping Controls to be used in the PlayerMovement Script
/// Differentiates betwen tap and swipe
/// Then calculates the direction of the swipe
/// </summary>
public class SwipeManager : MonoBehaviour
{
    public static bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    private bool isDragging = false;
    private Vector2 startTouch, swipeDelta;

   private void Update()
    {
        tap = swipeDown = swipeUp = swipeLeft = swipeRight = false;
        #region Standalone Inputs
        //Checks for tap
        if(Input.GetMouseButtonDown(0)){
            tap = true;
            isDragging = true;
            startTouch = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0)){
            isDragging = false;
            Reset();
        }
        #endregion

        #region  Mobile Input
        //Checks for Swipe
        if(Input.touches.Length>0){
            if(Input.touches[0].phase == TouchPhase.Began){
                tap = true;
                isDragging = true;
                startTouch = Input.touches[0].position;
            }

            else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled){
                isDragging = false;
                Reset();
            }
        }
        #endregion

        //Calculate Distance
        swipeDelta = Vector2.zero;
        if(isDragging){
            if(Input.touches.Length<0)
                swipeDelta = Input.touches[0].position - startTouch;
            else if(Input.GetMouseButton(0))
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
        }
        //Calculate Direction
        if(swipeDelta.magnitude > 100){
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if(Mathf.Abs(x)>Mathf.Abs(y)){
                if(x<0)
                    swipeLeft = true;
                else
                    swipeRight = true;
            }
            else{
                if(y<0)
                    swipeDown = true;
                else
                    swipeUp = true;
            }
            Reset();
        }
    }
    //Resets
    private void Reset(){
        startTouch = swipeDelta = Vector2.zero;
        isDragging = false;
    }
}
