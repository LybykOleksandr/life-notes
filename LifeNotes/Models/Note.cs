using System;
namespace LifeNotes.Models
{
	public class Note
	{
		public int Id { get; set; }
		public string Comment { get; set; }
		public short WeatherCriteriaRating { get; set; }
		public short MoodCriteriaRating { get; set; }
		public short ProductivityCriteriaRating { get; set; }
		public short GeneralCriteriaRating { get; set; }

		public int DateId { get; set; }
		public int NextDateId { get; set; }
		public int PreviousDateId { get; set; }

		public int UserId { get; set; }

		public User User { get; set; }


		public Note(string comment,short weatherCriteriaRating,short moodCriteriaRating,short productivityCriteriaRating,short generalCriteriaRating,int dateId,int nextDateId,int previousDateId,int userId)
		{
			this.Comment = comment;
			this.WeatherCriteriaRating = weatherCriteriaRating;
			this.MoodCriteriaRating = moodCriteriaRating;
			this.ProductivityCriteriaRating = productivityCriteriaRating;
			this.GeneralCriteriaRating = generalCriteriaRating;
			this.DateId = dateId;
			this.NextDateId = nextDateId;
			this.PreviousDateId = previousDateId;
			this.UserId = userId;
		}


	}
}


//	public class Note
//	{
		

//		public void Update(NoteDTO noteDTO)
//		{
//			this.Comment = noteDTO.Comment;
//			this.WeatherCriteriaRating = noteDTO.Weather;
//			this.MoodCriteriaRating = noteDTO.Mood;
//			this.ProductivityCriteriaRating = noteDTO.Productivity;
//			this.GeneralCriteriaRating = noteDTO.General;
//		}

		
		
//	}
//}