//using CommunityCoreLibrary;
//using CommunityCoreLibrary.Controller;
//using CommunityCoreLibrary.Detour;
//using RimWorld;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using Verse;
//
////adapted from ReclaimFabric by Skullywag: https://github.com/Skullywag/ReclaimFabric/blob/master/Source/ReclaimFabric/DetourInjector.cs
//
//namespace Senexium
//{
//	public class DetourInjector : SpecialInjector
//	{
//		public override bool Inject()
//		{
//			MethodInfo method1 = typeof(Hediff_Alcohol).GetMethod("SmeltProducts", BindingFlags.Instance | BindingFlags.Public);
//			MethodInfo method2 = typeof(_Hediff_Alcohol).GetMethod("_SmeltProducts", BindingFlags.Static | BindingFlags.NonPublic);
//			if (!Detours.TryDetourFromTo(method1, method2))
//			{
//				return false;
//			}
//			return true;
//		}
//	}
//}