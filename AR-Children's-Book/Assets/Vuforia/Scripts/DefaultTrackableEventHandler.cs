/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    #region PROTECTED_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    protected GameObject a;
    protected GameObject b;
    protected GameObject c;
    protected GameObject d;
    protected GameObject e;
    protected GameObject f;
    protected GameObject g;
    protected GameObject h;
    protected GameObject i;
    protected GameObject j;
    protected GameObject k;
    protected GameObject l;
    protected GameObject m;
    protected GameObject n;
    protected GameObject o;
    protected GameObject p;
    protected GameObject q;
    protected GameObject r;
    protected GameObject s;
    protected GameObject t;
    protected GameObject u;
    protected GameObject v;
    protected GameObject w;
    protected GameObject x;
    protected GameObject y;
    protected GameObject z;
    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        a = GameObject.Find("A");
        b = GameObject.Find("B");
        c = GameObject.Find("C");
        d = GameObject.Find("D");
        e = GameObject.Find("E");
        f = GameObject.Find("F");
        g = GameObject.Find("G");
        h = GameObject.Find("H");
        i = GameObject.Find("I");
        j = GameObject.Find("J");
        k = GameObject.Find("K");
        l = GameObject.Find("L");
        m = GameObject.Find("M");
        n = GameObject.Find("N");
        o = GameObject.Find("O");
        p = GameObject.Find("P");
        q = GameObject.Find("Q");
        r = GameObject.Find("r");
        s = GameObject.Find("S");
        t = GameObject.Find("T");
        u = GameObject.Find("U");
        v = GameObject.Find("V");
        w = GameObject.Find("W");
        x = GameObject.Find("X");
        y = GameObject.Find("Y");
        z = GameObject.Find("Z");


        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;

        if (mTrackableBehaviour.Trackable.Name == "A-001") {
            a.GetComponent<AudioSource>().Play ();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-001")
        {
            b.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "C-002")
        {
            c.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "D1-001")
        {
            d.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "E-001")
        {
            e.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "F1-001")
        {
            f.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "G-001")
        {
            g.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "H-001")
        {
            h.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "I-001")
        {
            i.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "J-001")
        {
            j.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "K-001")
        {
            k.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "L-001")
        {
            l.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "M-001")
        {
            m.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "N-002")
        {
            n.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "O1-001")
        {
            o.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "P-001")
        {
            p.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Q-001")
        {
            q.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "R-001")
        {
            r.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "S-001")
        {
            s.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "T-001")
        {
            t.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "U-001")
        {
            u.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "V1-001")
        {
            v.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "W-001")
        {
            w.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "X1-001")
        {
            x.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Y1-001")
        {
            y.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Z-001")
        {
            z.GetComponent<AudioSource>().Play();
        }




    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;

        a.GetComponent<AudioSource>().Stop();
        b.GetComponent<AudioSource>().Stop();
        c.GetComponent<AudioSource>().Stop();
        d.GetComponent<AudioSource>().Stop();
        e.GetComponent<AudioSource>().Stop();
        f.GetComponent<AudioSource>().Stop();
        g.GetComponent<AudioSource>().Stop();
        h.GetComponent<AudioSource>().Stop();
        i.GetComponent<AudioSource>().Stop();
        j.GetComponent<AudioSource>().Stop();
        k.GetComponent<AudioSource>().Stop();
        l.GetComponent<AudioSource>().Stop();
        m.GetComponent<AudioSource>().Stop();
        n.GetComponent<AudioSource>().Stop();
        o.GetComponent<AudioSource>().Stop();
        p.GetComponent<AudioSource>().Stop();
        q.GetComponent<AudioSource>().Stop();
        r.GetComponent<AudioSource>().Stop();
        s.GetComponent<AudioSource>().Stop();
        t.GetComponent<AudioSource>().Stop();
        u.GetComponent<AudioSource>().Stop();
        v.GetComponent<AudioSource>().Stop();
        w.GetComponent<AudioSource>().Stop();
        x.GetComponent<AudioSource>().Stop();
        y.GetComponent<AudioSource>().Stop();
        z.GetComponent<AudioSource>().Stop();

    }

    #endregion // PROTECTED_METHODS
}
