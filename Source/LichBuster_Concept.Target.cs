// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class LichBuster_ConceptTarget : TargetRules
{
	public LichBuster_ConceptTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "LichBuster_Concept" } );
	}
}
