//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using Frontend.Notify;
using Frontend.Component.Property;
using Frontend.Behaviour.Base;
using Core.Entity;
namespace Frontend.Behaviour.Audio {
public sealed class AudioBehaviour : BaseBehaviour, INotify {
    public void Start() {
        this.property = new BaseProperty(this);
        Notifier notifier = Notifier.GetInstance();
        notifier.Add(this, this.property);
    }
    public void OnNotify(int notifyMessage, Parameter parameter = null) {
        return;
    }
}
}
