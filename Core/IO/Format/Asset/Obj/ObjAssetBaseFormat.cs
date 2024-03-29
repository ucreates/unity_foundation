﻿//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2017 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
namespace Core.IO.Format.Asset {
public class ObjAssetBaseFormat : AssetBaseFormat {
    public const string COMMENT  = "#";
    public const string O  = "o";
    public const string G  = "g";
    public const string V  = "v";
    public const string VT = "vt";
    public const string VN = "vn";
    public const string F  = "f";
    public const string MTLLIB = "mtllib";
    public const string USEMTL = "usemtl";
    public string header {
        get;
        set;
    }
    public ObjAssetBaseFormat() {
        this.header = string.Empty;
    }
    public virtual void Dump() {
        return;
    }
}
}
