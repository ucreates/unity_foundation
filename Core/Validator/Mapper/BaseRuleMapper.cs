//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using System.Xml;
using System.Collections.Generic;
namespace Core.Validator.Mapper {
public abstract class BaseRuleMapper {
    public virtual Dictionary<string, object> Map(XmlNodeList ruleNodeList) {
        return null;
    }
}
}
