using System;
using System.Collections.Generic;

public class Picture {
	
	private string _route;
	private string _uploadDate;
	private PictureCategory _category;
	private User _nameOfUploader;
	private List<Comment> _comments;
	private int _views;
	private int _likes;
	private int _yearTaken;
	private int _downloads;

	public Picture(string name, string route, Guid id,
	string uploadDate, PictureCategory category,
	User nameOfUploader, int yearTaken)
	{
		Name = name;
		_route = route;
		Id = id;
		_uploadDate = uploadDate;
		_category = category;
		_nameOfUploader = nameOfUploader;
		_yearTaken = yearTaken;
	}

    public Guid Id { get; private set;}
	public string Route { get => _route; }
	public string Name { get;}

	public void AddComment(Comment comment, User username) {
		throw new System.NotImplementedException("Not implemented");
	}
}
