﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class AccountNoteTests : TestBase
	{
		[TestMethod]
		public void GetAllAccountNotes()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var accountNotes = api.AccountNoteRequest.Get();
		}

		[TestMethod]
		public void GetAccountNote()
		{
			int accountNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var accountNote = api.AccountNoteRequest.Get(accountNoteId);
		}

		[TestMethod]
		public void SaveAccountNote()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var accountNote = new AccountNote
			{
				AccountId = 0,
				ActionDate = DateTime.Now.ToShortDateString(),
				EntryDate = DateTime.Now.ToShortDateString(),
				Status = true,
				Subject = "A new note about this account",
				Note = "A Note Here."
			};
			var newAccountNote = api.AccountNoteRequest.Save(accountNote);
		}

		[TestMethod]
		public void DeleteAccountNote()
		{
			int accountNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.AccountNoteRequest.Delete(accountNoteId);
		}
	}
}
