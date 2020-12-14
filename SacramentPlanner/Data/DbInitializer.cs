using SacramentPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Data
{
	public class DbInitializer
	{
		public static void Initialize(MeetingContext context)
		{
			if (context.Planner.Any())
			{
				return;
			}

			var bishopricMembers = new Bishopric[]
			{
				new Bishopric{BishopricName="Bishop Smith",Active=true},
				new Bishopric{BishopricName="Brother Brown",Active=true},
				new Bishopric{BishopricName="Brother White",Active=true}
			};
			foreach (Bishopric b in bishopricMembers)
			{
				context.Bishopric.Add(b);
			}
			context.SaveChanges();

			var planners = new Planner[]
			{
			new Planner{MeetingDate=DateTime.Parse("2020-12-13"),BishopricId=1,OpenPrayer="Betty Jones",ClosePrayer="Richard Blue"},
			new Planner{MeetingDate=DateTime.Parse("2020-12-20"),BishopricId=2,OpenPrayer="Dana Roberts",ClosePrayer="Elizabeth Taylor"}
			};
			foreach (Planner p in planners)
			{
				context.Planner.Add(p);
			}
			context.SaveChanges();

			var speakers = new Speaker[]
			{
			new Speaker{PlannerId=1,SpeakerName="Halle Harrison",SpeakerTopic="Christlike Love"},
			new Speaker{PlannerId=1,SpeakerName="Grayson Black",SpeakerTopic="Love and Service"},
			new Speaker{PlannerId=1,SpeakerName="Charlie Yellow",SpeakerTopic="Charity"},
			new Speaker{PlannerId=2,SpeakerName="Bekah Russell",SpeakerTopic="Forgiveness"},
			new Speaker{PlannerId=2,SpeakerName="Tyler Schmidt",SpeakerTopic="Obedience"}
			};
			foreach (Speaker s in speakers)
			{
				context.Speakers.Add(s);
			}
			context.SaveChanges();

			var songs = new Song[]
			{
			new Song{PlannerId=1,OpenSongNum=6,OpenSongTitle="Redeemer",SacramentSongNum=196,SacramentSongTitle="Jesus",CloseSongNum=2,CloseSongTitle="Spirit"},
			new Song{PlannerId=2,OpenSongNum=239,OpenSongTitle="Choose",SacramentSongNum=196,SacramentSongTitle="Jesus",CloseSongNum=240,CloseSongTitle="Know"}
			};
			foreach (Song s in songs)
			{
				context.Songs.Add(s);
			}
			context.SaveChanges();
		}
	}
}
