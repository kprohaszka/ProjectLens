using System;
using System.Collections.Generic;

public class UserStorage : IUserStorage  {
	private HashSet<User> _users;

	public void AddUser(User user) {
		throw new System.NotImplementedException("Not implemented");
	}
	public IEnumerable<User> GetAllUsers() {
		throw new System.NotImplementedException("Not implemented");
	}
	public User GetUserByUserId(Guid user_id) {
		throw new System.NotImplementedException("Not implemented");
	}
	public User GetUserByUsername(string username) {
		throw new System.NotImplementedException("Not implemented");
	}

}
