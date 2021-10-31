using System;
using System.Security.Cryptography;

public class User {
	private string _username;
	private Rfc2898DeriveBytes _password;
	private Guid _userId;

	public Rfc2898DeriveBytes HashPassword(string password) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void ChangePassword(string newPassword) {
		throw new System.NotImplementedException("Not implemented");
	}

}
