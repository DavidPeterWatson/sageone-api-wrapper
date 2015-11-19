﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class CustomerNoteTests : TestBase
	{
		[TestMethod]
		public void GetAllCustomerNotes()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var customerNotes = api.CustomerNoteRequest.Get(filter: "CustomerId eq 0");
		}

		[TestMethod]
		public void GetCustomerNote()
		{
			int customerNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var customerNote = api.CustomerNoteRequest.Get(customerNoteId);
		}

		[TestMethod]
		public void SaveCustomerNote()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
		    var customerNote = new CustomerNote
		    {
		        CustomerId = 0,
                NotePriority = 1,
                NoteType = 1,
                Status = true,
                ActionDate = DateTime.Now,
                EntryDate = DateTime.Now,
                HasAttachments = false,
                Subject = "A note about this customer",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at scelerisque tortor. Morbi facilisis vitae nulla a imperdiet. Curabitur molestie rhoncus aliquam. Mauris turpis nibh, lobortis non tincidunt a, ornare eget felis."
            };

		    var newCustomerNote = api.CustomerNoteRequest.Save(customerNote);
		}

		[TestMethod]
		public void DeleteCustomerNote()
		{
			int customerNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.CustomerNoteRequest.Delete(customerNoteId);
		}
	}
}
