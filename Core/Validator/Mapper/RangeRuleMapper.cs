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
using Core.Validator.Message;
using Core.Validator.Builder;
namespace Core.Validator.Mapper {
public sealed class RangeRuleMapper : BaseRuleMapper {
    public override Dictionary<string, object> Map(XmlNodeList ruleNodeList) {
        Dictionary<string, object> ret = new Dictionary<string, object>();
        RangeValidatorUnitBuilder builder = new RangeValidatorUnitBuilder();
        foreach (XmlNode ruleNode in ruleNodeList) {
            foreach (XmlAttribute ruleAttr in ruleNode.Attributes) {
                string attrValue = ruleAttr.Value.ToLower();
                if (attrValue.Equals("type")) {
                    string typeName = ruleNode.InnerText.ToLower();
                    builder.AddType(typeName);
                } else if (attrValue.Equals("min")) {
                    string minValue = ruleNode.InnerText.ToLower();
                    builder.AddMin(minValue);
                } else if (attrValue.Equals("max")) {
                    string maxValue = ruleNode.InnerText.ToLower();
                    builder.AddMax(maxValue);
                } else if (attrValue.Equals("option")) {
                    string option = ruleNode.InnerText.ToLower();
                    builder.AddOption(option);
                } else if (attrValue.Equals("summary")) {
                    string summary = ruleNode.InnerText.ToLower();
                    builder.AddMessage(new ErrorValidateMessage(summary));
                }
            }
        }
        ret.Add(builder.type, builder.Build());
        return ret;
    }
}
}
