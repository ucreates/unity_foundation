//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
namespace Core.Device {
public sealed class Screen {
    public static float halfWidth {
        get {
            float val = (float)UnityEngine.Screen.width / 2f;
            return val;
        }
    }
    public static float halfHeight {
        get {
            float val = (float)UnityEngine.Screen.height / 2f;
            return val;
        }
    }
    public static float aspectRatio {
        get {
            float val = (float)UnityEngine.Screen.height / (float)UnityEngine.Screen.width;
            return val;
        }
    }
}
}
