using UnrealBuildTool;

public class MotoresComercialesClientTarget : TargetRules
{
	public MotoresComercialesClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MotoresComerciales");
	}
}
