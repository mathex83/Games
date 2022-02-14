using System;
using System.Collections.Generic;
using System.Linq;

namespace MathexGaming.Models.FIFA
{
	public class FIFALists
	{
		public static List<FUTgame> FUTgames = new()
		{
			new FUTgame { FUTgameID = 17 }
			,
			new FUTgame { FUTgameID = 18 }
			,
			new FUTgame { FUTgameID = 19 }
		};

		public static List<User> Users = new()
		{
			new User { UserID = 1, UserName = "Mathex83/mn83gamer", PS4RealName = "Martin Nørholm" }
			,
			new User { UserID = 2, UserName = "mathex83woi", PS4RealName = "Mar Nor" }
			,
			new User { UserID = 3, UserName = "mathex1683woi", PS4RealName = "Martin Norh" }
			,
			new User { UserID = 4, UserName = "mathex1983woi", PS4RealName = "Martin Norhol" }
			,
			new User { UserID = 5, UserName = "di3ach", PS4RealName = "Marjak Norholm" }
			,
			new User { UserID = 6, UserName = "mnnyhed", PS4RealName = "Martin No" }
			,
			new User { UserID = 7, UserName = "mn83woi", PS4RealName = "Martin Norholm" }
			,
			new User { UserID = 8, UserName = "m83woi3", PS4RealName = "" }
			,
			new User { UserID = 9, UserName = "HeLoJo31", PS4RealName = "Henrik Nøgle" }
			,
			new User { UserID = 10, UserName = "SchalkeFan31", PS4RealName = "Henrik Nøgle2" }
			,
			new User { UserID = 11, UserName = "SeMaGo22", PS4RealName = "Henrik Nøgle3" }
			,
			new User { UserID = 12, UserName = "Sch04Fan", PS4RealName = "Henrik Nøgle4" }
			,
			new User { UserID = 13, UserName = "martintind", PS4RealName = "Martin Nor" }
			,
			new User { UserID = 14, UserName = "mathex190583", PS4RealName = "Martin Norho" }
			,
			new User { UserID = 15, UserName = "mathex83woi2", PS4RealName = "" }
		};

		////Gemmes til jeg finder en løsning med id baseret på UserName - indtil da brug sql
		//public static List<UserCoin> UserCoins = new()
		//{
		//	new UserCoin { Coins = 6400, DraftsBought = 0, FUTgameID = 17, UserID = 1 }
		//	,
		//	new UserCoin { Coins = 8100, DraftsBought = 1, FUTgameID = 17, UserID = 2 }
		//};

		public static List<EAsFCxp> Xps = new()
		{
			new EAsFCxp { NextLevel = 2, XPThreshold = 500 }
			,
			new EAsFCxp { NextLevel = 3, XPThreshold = 1100 }
			,
			new EAsFCxp { NextLevel = 4, XPThreshold = 1800 }
			,
			new EAsFCxp { NextLevel = 5, XPThreshold = 2700 }
			,
			new EAsFCxp { NextLevel = 6, XPThreshold = 3700 }
			,
			new EAsFCxp { NextLevel = 7, XPThreshold = 4900 }
			,
			new EAsFCxp { NextLevel = 8, XPThreshold = 6400 }
			,
			new EAsFCxp { NextLevel = 9, XPThreshold = 8000 }
			,
			new EAsFCxp { NextLevel = 10, XPThreshold = 9600 }
			,
			new EAsFCxp { NextLevel = 11, XPThreshold = 11300 }
			,
			new EAsFCxp { NextLevel = 12, XPThreshold = 13100 }
			,
			new EAsFCxp { NextLevel = 13, XPThreshold = 15000 }
			,
			new EAsFCxp { NextLevel = 14, XPThreshold = 17000 }
			,
			new EAsFCxp { NextLevel = 15, XPThreshold = 19100 }
			,
			new EAsFCxp { NextLevel = 16, XPThreshold = 21300 }
			,
			new EAsFCxp { NextLevel = 17, XPThreshold = 23600 }
			,
			new EAsFCxp { NextLevel = 18, XPThreshold = 26000 }
			,
			new EAsFCxp { NextLevel = 19, XPThreshold = 28600 }
			,
			new EAsFCxp { NextLevel = 20, XPThreshold = 31300 }
			,
			new EAsFCxp { NextLevel = 21, XPThreshold = 34100 }
			,
			new EAsFCxp { NextLevel = 85, XPThreshold = 870967 }
			,
			new EAsFCxp { NextLevel = 86, XPThreshold = 904967 }
		};

		
	}
}
