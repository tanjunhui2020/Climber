// Copyright (C) 2020 Tan Junhui. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ClimberEditorTarget : TargetRules
{
	public ClimberEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Climber" } );
	}
}
