

using UnrealBuildTool;
using System.Collections.Generic;

public class Star_BrigadeEditorTarget : TargetRules
{
	public Star_BrigadeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Star_Brigade" } );
	}
}
