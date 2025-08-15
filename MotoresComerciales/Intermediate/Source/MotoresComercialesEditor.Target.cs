using UnrealBuildTool;

public class MotoresComercialesEditorTarget : TargetRules
{
	public MotoresComercialesEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MotoresComerciales");
	}
}
