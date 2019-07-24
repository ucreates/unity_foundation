//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2019 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using System;
using System.Collections.Generic;
using Service.Integration.Table;
namespace Service.Integration {
public abstract class BaseDataBase {
    public Dictionary<string, BaseDao> daoList {
        get;
        private set;
    }
    protected BaseDataBase() {
        this.daoList = new Dictionary<string, BaseDao>();
        this.Register();
    }
    public void Clear() {
        foreach (string key in this.daoList.Keys) {
            this.daoList [key].Clear();
        }
    }
    public Dao<T> FindBy<T>() where T : BaseTable, new () {
        Type type = typeof(T);
        string daoName = type.Name;
        if (false == this.daoList.ContainsKey(daoName)) {
            return null;
        }
        Dao<T> dao = this.daoList[daoName] as Dao<T>;
        dao.Reset();
        return dao;
    }
    protected virtual void Register() {
        return;
    }
}
}
