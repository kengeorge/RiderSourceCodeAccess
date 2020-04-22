// Copyright Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class RiderSourceCodeAccess : ModuleRules
	{
	#if WITH_FORWARDED_MODULE_RULES_CTOR
        public RiderSourceCodeAccess(ReadOnlyTargetRules Target) : base(Target)
    #else
        public RiderSourceCodeAccess(TargetInfo Target)
    #endif
        {
#if WITH_FORWARDED_MODULE_RULES_CTOR
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
#endif
		    PrivateDependencyModuleNames.AddRange(
                new []
                {
                    "Core",
                    "SourceCodeAccess",
                    "DesktopPlatform",
					"Projects",
					"Json"
                }
            );

            if (Target.Platform == UnrealTargetPlatform.Win64)
            {
                PrivateIncludePaths.Add("RiderSourceCodeAccess/Private/RiderPathLocatorWin");
            }
		}
	}
}