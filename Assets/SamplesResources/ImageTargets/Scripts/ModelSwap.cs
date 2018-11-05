/*============================================================================== 
 * Copyright (c) 2015 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/
using UnityEngine;
using System.Collections;


public class ModelSwap : MonoBehaviour 
{
	public GameObject mDefaultModel;
	public GameObject mExtTrackedModel;
    private GameObject mActiveModel = null;
    //private TrackableSettings mTrackableSettings = null;

	public void Start () 
    {
        //mDefaultModel = this.transform.FindChild("teapot").gameObject;
        //mExtTrackedModel = this.transform.FindChild("tower").gameObject;
        mActiveModel = mDefaultModel;
        //mTrackableSettings = FindObjectOfType<TrackableSettings>();
    }
    
    public void swapModel () 
    {
        if (mActiveModel == mDefaultModel)
        {
            // Switch 3D model to tower
            mDefaultModel.SetActive(false);
            mExtTrackedModel.SetActive(true);
            mActiveModel = mExtTrackedModel;
        }
        else if (mActiveModel == mExtTrackedModel)
        {
            // Switch 3D model to teapot
            mExtTrackedModel.SetActive(false);
            mDefaultModel.SetActive(true);
            mActiveModel = mDefaultModel;
        }
    }
}
