using System.Collections.Generic;

namespace MathexGaming.Models.Diablo3
{
	public class D3Lists
	{
		public static List<AchievementGroup> AchievementGroups = new()
		{
			new AchievementGroup { AchievementGroupID = 1, AchievementGroupName = "GENERAL" }
			,
			new AchievementGroup { AchievementGroupID = 2, AchievementGroupName = "ADVENTURE MODE" }
			,
			new AchievementGroup { AchievementGroupID = 3, AchievementGroupName = "CAMPAIGN" }
			,
			new AchievementGroup { AchievementGroupID = 4, AchievementGroupName = "COOPERATIVE" }
			,
			new AchievementGroup { AchievementGroupID = 5, AchievementGroupName = "HARDCORE" }
			,
			new AchievementGroup { AchievementGroupID = 6, AchievementGroupName = "CLASSES" }
			,
			new AchievementGroup { AchievementGroupID = 7, AchievementGroupName = "SET DUNGEONS" }
			,
			new AchievementGroup { AchievementGroupID = 8, AchievementGroupName = "CHALLENGES" }
			,
			new AchievementGroup { AchievementGroupID = 9, AchievementGroupName = "CRAFTING" }
			,
			new AchievementGroup { AchievementGroupID = 10, AchievementGroupName = "SEASON" }
			,
			new AchievementGroup { AchievementGroupID = 11, AchievementGroupName = "FEATS OF STRENGTH" }
		};
		public static List<AchievementSubGroup> AchievementSubGroups = new()
		{
			new AchievementSubGroup { AchievementSubGroupID = 1, AchievementSubGroupName = "GENERAL", AchievementGroupId = 1 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 2, AchievementSubGroupName = "CONVERSATIONS", AchievementGroupId = 1 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 3, AchievementSubGroupName = "EXPLORATION", AchievementGroupId = 1 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 4, AchievementSubGroupName = "SPECIAL EVENTS", AchievementGroupId = 1 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 5, AchievementSubGroupName = "ADVENTURE MODE", AchievementGroupId = 2 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 6, AchievementSubGroupName = "BOUNTIES", AchievementGroupId = 2 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 7, AchievementSubGroupName = "NEPHALEM RIFTS", AchievementGroupId = 2 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 8, AchievementSubGroupName = "CAMPAIGN", AchievementGroupId = 3 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 9, AchievementSubGroupName = "ACT I", AchievementGroupId = 3 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 10, AchievementSubGroupName = "ACT II", AchievementGroupId = 3 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 11, AchievementSubGroupName = "ACT III", AchievementGroupId = 3 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 12, AchievementSubGroupName = "ACT IV", AchievementGroupId = 3 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 13, AchievementSubGroupName = "ACT V", AchievementGroupId = 3 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 14, AchievementSubGroupName = "COOPERATIVE", AchievementGroupId = 4 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 15, AchievementSubGroupName = "ACT I", AchievementGroupId = 4 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 16, AchievementSubGroupName = "ACT II", AchievementGroupId = 4 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 17, AchievementSubGroupName = "ACT III", AchievementGroupId = 4 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 18, AchievementSubGroupName = "ACT IV", AchievementGroupId = 4 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 19, AchievementSubGroupName = "ACT V", AchievementGroupId = 4 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 20, AchievementSubGroupName = "HARDCORE", AchievementGroupId = 5 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 21, AchievementSubGroupName = "ACT I", AchievementGroupId = 5 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 22, AchievementSubGroupName = "ACT II", AchievementGroupId = 5 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 23, AchievementSubGroupName = "ACT III", AchievementGroupId = 5 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 24, AchievementSubGroupName = "ACT IV", AchievementGroupId = 5 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 25, AchievementSubGroupName = "ACT V", AchievementGroupId = 5 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 26, AchievementSubGroupName = "CLASSES", AchievementGroupId = 6 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 27, AchievementSubGroupName = "BARBARIAN", AchievementGroupId = 6 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 28, AchievementSubGroupName = "CRUSADER", AchievementGroupId = 6 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 29, AchievementSubGroupName = "DEMON HUNTER", AchievementGroupId = 6 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 30, AchievementSubGroupName = "MONK", AchievementGroupId = 6 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 31, AchievementSubGroupName = "WITCH DOCTOR", AchievementGroupId = 6 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 32, AchievementSubGroupName = "WIZARD", AchievementGroupId = 6 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 33, AchievementSubGroupName = "NECROMANCER", AchievementGroupId = 6 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 34, AchievementSubGroupName = "SET DUNGEONS", AchievementGroupId = 7 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 35, AchievementSubGroupName = "BARBARIAN", AchievementGroupId = 7 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 36, AchievementSubGroupName = "CRUSADER", AchievementGroupId = 7 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 37, AchievementSubGroupName = "DEMON HUNTER", AchievementGroupId = 7 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 38, AchievementSubGroupName = "MONK", AchievementGroupId = 7 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 39, AchievementSubGroupName = "WITCH DOCTOR", AchievementGroupId = 7 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 40, AchievementSubGroupName = "WIZARD", AchievementGroupId = 7 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 41, AchievementSubGroupName = "NECROMANCER", AchievementGroupId = 7 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 42, AchievementSubGroupName = "CHALLENGES", AchievementGroupId = 8 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 43, AchievementSubGroupName = "ACT I", AchievementGroupId = 8 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 44, AchievementSubGroupName = "ACT II", AchievementGroupId = 8 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 45, AchievementSubGroupName = "ACT III", AchievementGroupId = 8 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 46, AchievementSubGroupName = "ACT IV", AchievementGroupId = 8 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 47, AchievementSubGroupName = "ACT V", AchievementGroupId = 8 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 48, AchievementSubGroupName = "CRAFTING", AchievementGroupId = 9 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 49, AchievementSubGroupName = "BLACKSMITH", AchievementGroupId = 9 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 50, AchievementSubGroupName = "JEWELER", AchievementGroupId = 9 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 51, AchievementSubGroupName = "MYSTIC", AchievementGroupId = 9 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 52, AchievementSubGroupName = "GENERAL", AchievementGroupId = 10 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 53, AchievementSubGroupName = "GENERAL/NEPHALEM RIFTS", AchievementGroupId = 10 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 54, AchievementSubGroupName = "GENERAL/BOSSES", AchievementGroupId = 10 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 55, AchievementSubGroupName = "ITEMS", AchievementGroupId = 10 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 56, AchievementSubGroupName = "GREATER RIFTS", AchievementGroupId = 10 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 57, AchievementSubGroupName = "FEATS OF STRENGTH/SEASONS", AchievementGroupId = 10 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 58, AchievementSubGroupName = "SCCONQUESTS", AchievementGroupId = 10 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 59, AchievementSubGroupName = "HCCONQUESTS", AchievementGroupId = 10 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 60, AchievementSubGroupName = "FEATS OF STRENGTH", AchievementGroupId = 11 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 61, AchievementSubGroupName = "CHALLENGES", AchievementGroupId = 11 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 62, AchievementSubGroupName = "CAMPAIGN", AchievementGroupId = 11 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 63, AchievementSubGroupName = "CLASSES", AchievementGroupId = 11 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 64, AchievementSubGroupName = "COOPERATIVE", AchievementGroupId = 11 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 65, AchievementSubGroupName = "CRAFTING", AchievementGroupId = 11 }
			,
			new AchievementSubGroup { AchievementSubGroupID = 66, AchievementSubGroupName = "HARDCORE", AchievementGroupId = 11 }
		};

		//public static List<D3Achievement> D3Achievements = new()
		//{
		//	#region Season 24
		//	new D3Achievement
		//	{
		//		//D3AchievementId = 1,
		//		//CompletedColor = "red",
		//		AchievementName = "Boss Mode",
		//		AchievementText = "Kill all bosses (except Vidian) in 20 mins",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 2,
		//		//CompletedColor = "red",
		//		AchievementName = "Worlds Apart",
		//		AchievementText = "Hardcore: Kill all bosses (except Vidian) in 20 mins",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 3,
		//		//CompletedColor = "red",
		//		AchievementName = "On A Good Day",
		//		AchievementText = "3x Legendary Gem 65",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 4,
		//		//CompletedColor = "red",
		//		AchievementName = "I Can't Stop",
		//		AchievementText = "Hardcore: 3x Legendary Gem 65",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 5,
		//		//CompletedColor = "red",
		//		AchievementName = "Curses!",
		//		AchievementText = "350 kills Cursed Peat (Act 5/Paths Of The Drowned)",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 6,
		//		//CompletedColor = "red",
		//		AchievementName = "Stars Align",
		//		AchievementText = "Hardcore: 350 kills Cursed Peat (Act 5/Paths Of The Drowned)",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 7,
		//		//CompletedColor = "red",
		//		AchievementName = "The Thrill",
		//		AchievementText = "GR45 No Set Items",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 8,
		//		//CompletedColor = "red",
		//		AchievementName = "Super Human",
		//		AchievementText = "Hardcore: GR45 No Set Items",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 9,
		//		//CompletedColor = "red",
		//		AchievementName = "Years Of War",
		//		AchievementText = "GR55 6 different 6-piece set bonuses",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 24
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 10,
		//		//CompletedColor = "red",
		//		AchievementName = "Dynasty",
		//		AchievementText = "Hardcore: GR55 6 different 6-piece set bonuses",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 24
		//	}
		//	#endregion
		//	,
		//	#region Season 23
		//	new D3Achievement
		//	{
		//		//Id = 11,
		//		//CompletedColor = "red",
		//		AchievementName = "Boss Mode",
		//		AchievementText = "Kill all bosses (except Vidian) in 20 mins",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 12,
		//		//CompletedColor = "red",
		//		AchievementName = "Worlds Apart",
		//		AchievementText = "Hardcore: Kill all bosses (except Vidian) in 20 mins",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 13,
		//		//CompletedColor = "red",
		//		AchievementName = "Avarice",
		//		AchievementText = "50 mio in a single streak",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 14,
		//		//CompletedColor = "red",
		//		AchievementName = "Avaritia",
		//		AchievementText = "Hardcore: 50 mio in a single streak",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		//Id = 15,
		//		//CompletedColor = "red",
		//		AchievementName = "Speed Demon",
		//		AchievementText = "T10 rift < 2min",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		AchievementName = "Need For Speed",
		//		AchievementText = "Hardcore: T10 rift < 2min",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		//CompletedColor = "red",
		//		AchievementName = "Divinity",
		//		AchievementText = "GR75+ Solo",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		//CompletedColor = "red",
		//		AchievementName = "Lionhearted",
		//		AchievementText = "Hardcore: GR75+ Solo",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		//CompletedColor = "red",
		//		AchievementName = "Masters Of The Universe",
		//		AchievementText = "8 set dungeons mastered",
		//		Group = "ScConquests",
		//		SubGroup = "ScConquests",
		//		SeasonRoll = 23
		//	},
		//	new D3Achievement
		//	{
		//		//CompletedColor = "red",
		//		AchievementName = "Master Of Sets",
		//		AchievementText = "Hardcore: 8 set dungeons mastered",
		//		Group = "HcConquests",
		//		SubGroup = "HcConquests",
		//		SeasonRoll = 23
		//	}
		//	#endregion
		//};
	}
}
