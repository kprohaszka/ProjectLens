using System;
using System.Collections.Generic;

public interface IPictureStorage {
	IEnumerable<Picture> GetAllPictures();
	void AddPicture(Picture picture);
	void DeletePicture(Picture picture);
	IEnumerable<Picture> GetAllPicturesByCategory(PictureCategory category);
	IEnumerable<Picture> GetAllPicturesByUser(User username);
	void AddNewComment(Guid pictureID,User username,Comment comment);
	void IncreaseViews(Guid pictureID);
	void IncreaseLikes(Guid pictureID);
	void IncreaseDownloads(Guid pictureID);

}
