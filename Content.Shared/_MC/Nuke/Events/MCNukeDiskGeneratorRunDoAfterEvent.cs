﻿using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared._MC.Nuke.Events;

[Serializable, NetSerializable]
public sealed partial class MCNukeDiskGeneratorRunDoAfterEvent : SimpleDoAfterEvent;
