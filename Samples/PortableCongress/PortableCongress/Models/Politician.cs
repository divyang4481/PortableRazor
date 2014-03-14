﻿using System;

namespace PortableCongress
{
	public class Politician
	{
		public string Name { get; set; }
		public string ImageName { get; set; }
		public string BioGuideId { get; set; } //this is used to index the photos
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string OfficeAddress { get; set; }
		public string GovTrackId { get; set; }
		public string Phone {get; set; }
		public string TwitterId { get; set; }
		public string YoutubeUrl { get; set; }
		public string WebSite { get; set; }
		public string Party { get; set; }
		public string State { get; set; }

		int id;
		public int Id {
			get {
				id = int.Parse (GovTrackId);
				return id;
			}
			set{ id = value; }
		}
	}
}