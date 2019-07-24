//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2019 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Service.Strategy;
using Service.Domain;
namespace Service {
public abstract class BaseServiceGateway {
    protected Dictionary<string, BaseDomain> serviceDictionary {
        get;
        set;
    }
    protected BaseServiceGateway() {
        this.serviceDictionary = new Dictionary<string, BaseDomain>();
        this.Register();
    }
    public BaseStrategy Request(string domainName) {
        string protocol = @"service://";
        Regex regex = new Regex(protocol);
        if (false == regex.IsMatch(domainName)) {
            return null;
        }
        domainName = domainName.Replace(protocol, "");
        char[] delimiter = new char[] {'/'};
        string[] schema = domainName.Split(delimiter);
        if (0 == schema.Length) {
            return null;
        }
        string serviceName = schema[0];
        if (false == this.serviceDictionary.ContainsKey(serviceName)) {
            return null;
        }
        BaseDomain service = this.serviceDictionary[serviceName];
        string strategyName = "";
        for (int i = 1; i < schema.Length; i++) {
            strategyName += schema[i];
            if (i < schema.Length - 1) {
                strategyName += "/";
            }
        }
        return service.Create(strategyName);
    }
    protected virtual void Register() {
        return;
    }
}
}
