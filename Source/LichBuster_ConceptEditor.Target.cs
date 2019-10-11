// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class LichBuster_ConceptEditorTarget : TargetRules
{
	public LichBuster_ConceptEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "LichBuster_Concept" } );
	}
}
