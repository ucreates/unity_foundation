﻿//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2017 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using Core.IO.Format.Asset;
namespace Core.IO.Parser.Asset {
public class MtlAssetBumpTextureMapParser : MtlAssetBaseParser<MtlAssetBumpTextureMapFormat> {
    public override MtlAssetBumpTextureMapFormat Read(string header, string body) {
        MtlAssetBumpTextureMapFormat format = new MtlAssetBumpTextureMapFormat();
        format.header = header;
        format.name = body;
        return format;
    }
}
}
