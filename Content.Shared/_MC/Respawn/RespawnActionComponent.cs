using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._MC.Respawn;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class RespawnActionComponent : Component
{
	[DataField, AutoNetworkedField]
	public EntProtoId ActionId = "RespawnAction";

	[DataField, AutoNetworkedField]
	public EntityUid? Action;
}
