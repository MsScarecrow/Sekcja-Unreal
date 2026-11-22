// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Sekcja : ModuleRules
{
	public Sekcja(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Sekcja",
			"Sekcja/Variant_Platforming",
			"Sekcja/Variant_Platforming/Animation",
			"Sekcja/Variant_Combat",
			"Sekcja/Variant_Combat/AI",
			"Sekcja/Variant_Combat/Animation",
			"Sekcja/Variant_Combat/Gameplay",
			"Sekcja/Variant_Combat/Interfaces",
			"Sekcja/Variant_Combat/UI",
			"Sekcja/Variant_SideScrolling",
			"Sekcja/Variant_SideScrolling/AI",
			"Sekcja/Variant_SideScrolling/Gameplay",
			"Sekcja/Variant_SideScrolling/Interfaces",
			"Sekcja/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
