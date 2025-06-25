

using UnrealBuildTool;
using System.Collections.Generic;

public class Star_BrigadeTarget : TargetRules
{
	public Star_BrigadeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Star_Brigade" } );
	}
}
