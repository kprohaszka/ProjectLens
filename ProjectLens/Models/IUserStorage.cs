using System;
using System.Collections.Generic;

public interface IUserStorage {
	void AddUser(User user);
	IEnumerable<User> GetAllUsers();
	User GetUserByUserId(Guid user_id);
	User GetUserByUsername(string username);

}
