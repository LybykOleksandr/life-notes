using System;
namespace LifeNotes.Models
{
    public class NoteDTO
    {
		public string Comment { get; set; }

		public short Weather { get; set; }
		public short Mood { get; set; }
		public short Productivity { get; set; }
		public short General { get; set; }

		public int Previous { get; set; }
		public int Next { get; set; }


		public NoteDTO(Note note)
		{
			this.Comment = note.Comment;

			this.Weather = note.WeatherCriteriaRating;
			this.Mood = note.MoodCriteriaRating;
			this.Productivity = note.ProductivityCriteriaRating;
			this.General = note.GeneralCriteriaRating;

			this.Previous = note.PreviousDateId;
			this.Next = note.NextDateId;
		}

	}
}

