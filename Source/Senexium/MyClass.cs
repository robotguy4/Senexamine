using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// Always needed
using RimWorld;
using Verse;

//using Verse.AI;

namespace Senexium
{
	public class Hediff_AccellAge: Verse.HediffWithComps
	{
		private bool IsPregnant {
			get {
//				Hediff hediffs = this.pawn.health.hediffSet.GetFirstHediffOfDef (HediffDefOf.Pregnant);
				if (this.pawn.health.hediffSet.GetFirstHediffOfDef (HediffDefOf.Pregnant) != null)
					return true;
				else
					return false;
			}
		}

		public override string DebugString {
			get {
				StringBuilder stringBuilder = new StringBuilder ();
				stringBuilder.Append (base.DebugString);
				stringBuilder.AppendLine ("Preg: " + this.IsPregnant.ToString ());
				return stringBuilder.ToString ();
			}
		}

		#region Ticker
		
		public override void Tick ()
		{
			base.Tick ();
			this.pawn.ageTracker.AgeBiologicalTicks += (long)this.Severity - 1;
			Hediff_Pregnant hediffpreg = this.pawn.health.hediffSet.GetFirstHediffOfDef (HediffDefOf.Pregnant) as Hediff_Pregnant;
			if (hediffpreg != null) {
				hediffpreg.Severity += (this.Severity - 1f) / (this.pawn.RaceProps.gestationPeriodDays * 60000f);
			}

		}
		#endregion
	}

}
