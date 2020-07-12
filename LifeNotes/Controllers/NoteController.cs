using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeNotes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
		//private readonly AppDbContext _appDbContext;

		//public NotesController(AppDbContext appDbContext)
		//{
		//    this._appDbContext = appDbContext;
		//}

		//[HttpGet]
		//public IActionResult RequestNote([FromQuery] int userId, [FromQuery] int dateId)
		//{
		//	//Note userNote = this._appDbContext.Notes.ToArray().FirstOrDefault(
		//	//	predicate: note => note.UserId == userId && note.DateId == dateId
		//	//);
		//	//шукаєм в базі запис

		//	if (userNote == null)
		//	{
		//		userNote = this._appDbContext.Notes.ToArray().LastOrDefault(
		//			predicate: note => note.UserId == userId && note.DateId < dateId
		//		);

		//		if (userNote != null)
		//		{
		//			NoteDTO noteDTO = new NoteDTO
		//			{
		//				Previous = userNote.DateId
		//			};

		//			return this.Ok(value: noteDTO);
		//		}
		//		else
		//			return this.NoContent();
		//	}

		//	return this.Ok(value: new NoteDTO(note: userNote));
		//}




		//[HttpPost]
		//public IActionResult SaveNote([FromBody] NoteDTO noteDTO, [FromQuery] int userId, [FromQuery] int dateId)
		//{
		//	Note userNote = this._appDbContext.Notes.ToArray().FirstOrDefault(
		//		predicate: note => note.UserId == userId && note.DateId == dateId
		//	);

		//	if (userNote == null)
		//	{
		//		Note nextUserNote = this._appDbContext.Notes.ToArray().FirstOrDefault(
		//			predicate: note => note.UserId == userId && note.DateId > dateId
		//		);

		//		Note previousUserNote = this._appDbContext.Notes.ToArray().LastOrDefault(
		//			predicate: note => note.UserId == userId && note.DateId < dateId
		//		);

		//		userNote = new Note(
		//			comment: noteDTO.Comment,
		//			weatherCriteriaRating: noteDTO.Weather,
		//			moodCriteriaRating: noteDTO.Mood,
		//			productivityCriteriaRating: noteDTO.Productivity,
		//			generalCriteriaRating: noteDTO.General,
		//			dateId: int.Parse($"{DateTime.Now:yyyyMMdd}"),
		//			nextDateId: nextUserNote != null ? nextUserNote.DateId : 0,
		//			previousDateId: previousUserNote != null ? previousUserNote.DateId : 0,
		//			userId: userId
		//		);

		//		if (previousUserNote != null)
		//		{
		//			previousUserNote.NextDateId = userNote.DateId;

		//			//? Attach - tell EF about an object that already exists in the Db.
		//			//TODO: learn more about this concept on entityframework tutorials website.
		//			this._appDbContext.Notes.Attach(entity: previousUserNote);
		//			this._appDbContext.Entry(entity: previousUserNote).Property(
		//				propertyExpression: note => note.NextDateId
		//			).IsModified = true;
		//		}

		//		this._appDbContext.Notes.Add(entity: userNote);

		//		this._appDbContext.SaveChanges();

		//		return this.Created(uri: "", value: null);
		//	}

		//	userNote.Update(noteDTO: noteDTO);

		//	this._appDbContext.SaveChanges();

		//	return this.Ok();
		//}



	}
}