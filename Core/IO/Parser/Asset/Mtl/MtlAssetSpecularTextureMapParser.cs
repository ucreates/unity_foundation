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
public class MtlAssetSpecularTextureMapParser : MtlAssetBaseParser<MtlAssetSpecularTextureMapFormat> {
    public override MtlAssetSpecularTextureMapFormat Read(string header, string body) {
        MtlAssetSpecularTextureMapFormat format = new MtlAssetSpecularTextureMapFormat();
        format.header = header;
        format.name = body;
        return format;
    }
}
}
