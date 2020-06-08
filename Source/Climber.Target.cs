// Copyright (C) 2020 Tan Junhui. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ClimberTarget : TargetRules
{
	public ClimberTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Climber" } );
	}
}
