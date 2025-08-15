using UnrealBuildTool;

public class MotoresComercialesServerTarget : TargetRules
{
	public MotoresComercialesServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MotoresComerciales");
	}
}
