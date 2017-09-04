using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using ARUser;
using System.IO;
using System.Text.RegularExpressions;

static class modFunctions
{
	static string userid;

	static string pwd;

	public static void OpenRemedyCustomer1(ref DataGridView TheGrid, object sender, System.Windows.Forms.DataGridViewCellEventArgs e, ARUSER.OpenMode eOpenMode, string frmFrom)
	{
		//System.Windows.Forms.DataGridViewCellEventArgs

		int i = 0;
		string MyEntryID = null;
		ARUSER.COMAppObj a = default(ARUSER.COMAppObj);
		Process RemedyProcess = null;
		VariantType SessionID = default(VariantType);
		ARUSER.ICOMFormWnd RemedyForm = default(ARUSER.ICOMFormWnd);
		ARUSER.COMQueryResult MyResultForm = default(ARUSER.COMQueryResult);
		ARUSER.ICOMQueryResultSet RemedyQueryObject = default(ARUSER.ICOMQueryResultSet);
		Process[] RemedyProcesses = Process.GetProcessesByName("ARUSER");

		wrong_department = "";

		if (frmEnvironment.ChildFormPRD.Visible) {
			frmEnvironment.ChildFormPRD.timerCOUNTS.Stop();
		} else {
			frmEnvironment.childformQA.timerCOUNTS.Stop();
		}
		a = new ARUSER.COMAppObj();

		try {
			RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, false);
		} catch (Exception ex) {
			if (Err().Number == -2147216284) {
				foreach (Process RemedyProcess_loopVariable in RemedyProcesses) {
					RemedyProcess = RemedyProcess_loopVariable;
					RemedyProcess.Kill();
				}
			}
			if (Err().Number == -2147216287 | Err().Number == -2147023174) {
				for (i = 1; i <= 3; i++) {
					userid = Interaction.InputBox("Please enter your Remedy User ID Please?", "System Message", "T0005630");
					pwd = Interaction.InputBox("Enter your password please", "System Message", "logik007");
					if (string.IsNullOrEmpty(userid) | string.IsNullOrEmpty(pwd)) {
						Interaction.MsgBox("You did not enter valid values", MsgBoxStyle.OkOnly);
						if (frmEnvironment.ChildFormPRD.Visible) {
							frmEnvironment.ChildFormPRD.timerCOUNTS.Start();
						} else {
							frmEnvironment.childformQA.timerCOUNTS.Start();
						}
						return;
					}
					SessionID = a.Login(userid.ToString(), pwd, false);
					if (Err().Number == -2147467259) {
						Interaction.MsgBox(Err().Description);
						a.Logout(0);
						a = null;
					} else {
						break; // TODO: might not be correct. Was : Exit For
					}
				}
			}
		}

		string persalnumber = null;
		// frmResetPassword
		persalnumber = Strings.Replace(TheGrid["PersalNrDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper(), "P", "");
		persalnumber = Strings.Replace(persalnumber, "p", "");

		try {
			RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, false);
			RemedyForm.GetField("Persal Number").Value = persalnumber.Trim();
			RemedyQueryObject = RemedyForm.Query("");
			if (RemedyQueryObject.Count > 0) {
				MyResultForm = RemedyQueryObject.Item(1);
				MyEntryID = MyResultForm.entryId;
				RemedyForm = a.LoadForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, eOpenMode, true);
				if (eOpenMode == ARUSER.OpenMode.ARModify) {
					RemedyForm.GetField("Last Name").Value = Strings.StrConv(TheGrid["SurnameDataGridViewTextBoxColumn", e.RowIndex].Value.ToString(), VbStrConv.ProperCase);
					RemedyForm.GetField("First Name").Value = Strings.StrConv(TheGrid["FirstnameDataGridViewTextBoxColumn", e.RowIndex].Value.ToString(), VbStrConv.ProperCase);
					RemedyForm.GetField("E-Mail").Value = TheGrid["EMailDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToLower();
					RemedyForm.GetField("Cellphone").Value = TheGrid["CellDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Fax Number").Value = TheGrid["FaxDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Telephone").Value = TheGrid["TelBDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Rank").Value = TheGrid["RankDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("VULINDLELA Role").Value = TheGrid["ResponsibilityDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();
					if (frmFrom == "frmResetPassword") {
					} else if (frmFrom == "frmNewUsers") {
						if (!string.IsNullOrEmpty(TheGrid["DeptDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper().Trim())) {
							RemedyForm.GetField("Department Name").Value = TheGrid["DeptDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
							RemedyForm.GetField("Department Type").Value = "";
							//TheGrid.Item(9, e.RowIndex).Value.ToString.ToUpper
						} else {
							wrong_department = TheGrid["DeptDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToLower();
							RemedyForm.GetField("Department Name").Value = TheGrid["DeptDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToLower();
							RemedyForm.GetField("Department Type").Value = "";
						}
					}
				}

			} else {
				if (Interaction.MsgBox("User Not Found! Do you want to populate the values into Remedy?", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "System Message") == MsgBoxResult.Yes) {
					RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARSubmit, 1);
					if (TheGrid["PersalNrDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper().Trim().Length == 8) {
						RemedyForm.GetField("Persal Number").Value = TheGrid["PersalNrDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					}
					RemedyForm.GetField("Last Name").Value = Strings.StrConv(TheGrid["SurnameDataGridViewTextBoxColumn", e.RowIndex].Value.ToString(), VbStrConv.ProperCase);
					RemedyForm.GetField("First Name").Value = Strings.StrConv(TheGrid["FirstnameDataGridViewTextBoxColumn", e.RowIndex].Value.ToString(), VbStrConv.ProperCase);
					RemedyForm.GetField("E-Mail").Value = TheGrid["EMailDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToLower();
					RemedyForm.GetField("Cellphone").Value = TheGrid["CellDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Fax Number").Value = TheGrid["FaxDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Telephone").Value = TheGrid["TelBDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Rank").Value = TheGrid["RankDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("VULINDLELA Role").Value = TheGrid["ResponsibilityDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();
					RemedyForm.GetField("Title").Value = TheGrid["TitleDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
					if (frmFrom == "frmResetPassword") {
					} else if (frmFrom == "frmNewUsers") {
						if (!string.IsNullOrEmpty(TheGrid["DeptDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper().Trim())) {
							RemedyForm.GetField("Department Name").Value = TheGrid["DeptDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToUpper();
							RemedyForm.GetField("Department Type").Value = "";
							//TheGrid.Item(9, e.RowIndex).Value.ToString.ToUpper
						} else {
							wrong_department = TheGrid["DeptDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToLower();
							RemedyForm.GetField("Department Name").Value = TheGrid["DeptDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().ToLower();
							RemedyForm.GetField("Department Type").Value = "";
						}
					}
					//RemedyForm = a.LoadForm(SessionID, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, ARUSER.OpenMode.ARDisplay, True)
				}
			}
			if (persalnumber.ToString().Trim().Length == 13) {
				Tnumber = Interaction.InputBox("Please supply the newly created temporary Remedy persal number", "Input Required", "").ToUpper();
				persalnumber = Tnumber;
			}

			if (frmEnvironment.ChildFormPRD.Visible) {
				{
					frmEnvironment.ChildFormPRD.txtPersalNumber.Text = persalnumber;
					frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e);
					frmEnvironment.ChildFormPRD.txtPersalNumber.Focus();
					frmEnvironment.ChildFormPRD.txtPersalNumber.SelectAll();
					frmEnvironment.ChildFormPRD.timerCOUNTS.Start();
				}
			} else {
				{
					frmEnvironment.childformQA.txtPersalNumber.Text = persalnumber;
					frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e);
					frmEnvironment.childformQA.txtPersalNumber.Focus();
					frmEnvironment.childformQA.txtPersalNumber.SelectAll();
					frmEnvironment.childformQA.timerCOUNTS.Start();
				}
			}

		} catch (Exception ex) {
			if (Err().Number == -2147216287) {
				Interaction.MsgBox("An internal error occured plese try again", MsgBoxStyle.Critical);
				if (frmEnvironment.ChildFormPRD.Visible) {
					frmEnvironment.ChildFormPRD.timerCOUNTS.Start();
				} else {
					frmEnvironment.childformQA.timerCOUNTS.Start();
				}
				return;
			}
		}
		if (frmEnvironment.ChildFormPRD.Visible) {
			frmEnvironment.ChildFormPRD.timerCOUNTS.Start();
		} else {
			frmEnvironment.childformQA.timerCOUNTS.Start();
		}
		frmEnvironment.WindowState = FormWindowState.Minimized;
	}

	/// <summary>
	/// Open a form in an already running BMC Remedy Windows Administrator Tool
	/// </summary>
	/// <param name="sessionId">Name of the server</param>
	/// <param name="server">The name of the server on which to open the form.</param>
	/// <param name="form">The name of the form to open</param>
	/// <param name="mode">Name of the server</param>
	/// <param name="visible">object to open</param>


	public static void OpenRemedyCustomer2(ref DataGridView TheGrid, object sender, System.Windows.Forms.DataGridViewCellEventArgs e, ARUSER.OpenMode eOpenMode, string frmFrom)
	{
		//System.Windows.Forms.DataGridViewCellEventArgs

		int i = 0;
		string MyEntryID = null;
		ARUSER.COMAppObj a = default(ARUSER.COMAppObj);
		Process RemedyProcess = null;
		VariantType SessionID = default(VariantType);
		ARUSER.ICOMFormWnd RemedyForm = default(ARUSER.ICOMFormWnd);
		ARUSER.COMQueryResult MyResultForm = default(ARUSER.COMQueryResult);
		ARUSER.ICOMQueryResultSet RemedyQueryObject = default(ARUSER.ICOMQueryResultSet);
		Process[] RemedyProcesses = Process.GetProcessesByName("ARUSER");

		wrong_department = "";

		if (frmEnvironment.ChildFormPRD.Visible) {
			frmEnvironment.ChildFormPRD.timerCOUNTS.Stop();
		} else {
			frmEnvironment.childformQA.timerCOUNTS.Stop();
		}
		a = new ARUSER.COMAppObj();

		try {
			RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, false);
		} catch (Exception ex1) {
			if (Err().Number == -2147216284) {
				foreach (Process RemedyProcess_loopVariable in RemedyProcesses) {
					RemedyProcess = RemedyProcess_loopVariable;
					RemedyProcess.Kill();
				}
			}
			if (Err().Number == -2147216287 | Err().Number == -2147023174) {
				for (i = 1; i <= 3; i++) {
					userid = Interaction.InputBox("Please enter your Remedy User ID Please?", "System Message", "T0005221");
					//userid = InputBox("Please enter your Remedy User ID Please?", "System Message", "Ronel.Ilsley")
					pwd = Interaction.InputBox("Enter your password please", "System Message", "logik007");
					//pwd = InputBox("Enter your password please", "System Message", "        ")
					if (string.IsNullOrEmpty(userid) | string.IsNullOrEmpty(pwd)) {
						Interaction.MsgBox("You did not enter valid values", MsgBoxStyle.OkOnly);
						if (frmEnvironment.ChildFormPRD.Visible) {
							frmEnvironment.ChildFormPRD.timerCOUNTS.Start();
						} else {
							frmEnvironment.childformQA.timerCOUNTS.Start();
						}
						return;
					}
					SessionID = a.Login(userid.ToString(), pwd, false);
					if (Err().Number == -2147467259) {
						a.Logout(0);
						a = null;
						Interaction.MsgBox(Err().Description);
					} else {
						break; // TODO: might not be correct. Was : Exit For
					}
				}
			}
		}

		string persalnumber = null;
		persalnumber = Strings.Replace(TheGrid["Persalnr", e.RowIndex].Value.ToString().ToUpper(), "P", "");
		persalnumber = Strings.Replace(persalnumber, "p", "");

		try {
			RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, false);
			RemedyForm.GetField("Persal Number").Value = persalnumber.Trim();
			RemedyQueryObject = RemedyForm.Query("");
			if (RemedyQueryObject.Count > 0) {
				MyResultForm = RemedyQueryObject.Item(1);
				MyEntryID = MyResultForm.entryId;
				RemedyForm = a.LoadForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, eOpenMode, true);

				if (eOpenMode == ARUSER.OpenMode.ARModify) {
					RemedyForm.GetField("Last Name").Value = Strings.StrConv(TheGrid["Surname", e.RowIndex].Value.ToString(), VbStrConv.ProperCase);
					RemedyForm.GetField("First Name").Value = Strings.StrConv(TheGrid["Firstname", e.RowIndex].Value.ToString(), VbStrConv.ProperCase);
					RemedyForm.GetField("E-Mail").Value = TheGrid["EMail", e.RowIndex].Value.ToString().ToLower();
					RemedyForm.GetField("Cellphone").Value = TheGrid["Cell", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Fax Number").Value = TheGrid["Fax", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Telephone").Value = TheGrid["TelB", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Rank").Value = TheGrid["Rank", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("VULINDLELA Role").Value = TheGrid["Responsibility", e.RowIndex].Value.ToString();

					if (!string.IsNullOrEmpty(TheGrid["Dept", e.RowIndex].Value.ToString().ToUpper().Trim())) {
						RemedyForm.GetField("Department Name").Value = TheGrid["Dept", e.RowIndex].Value.ToString().ToUpper();
						RemedyForm.GetField("Department Type").Value = TheGrid["Province", e.RowIndex].Value.ToString().ToUpper();
					} else {
						wrong_department = TheGrid["DEPARTMENT", e.RowIndex].Value.ToString().ToLower();
						RemedyForm.GetField("Department Name").Value = TheGrid["DEPARTMENT", e.RowIndex].Value.ToString().ToLower();
						RemedyForm.GetField("Department Type").Value = "";
					}

				}


			} else {

				if (Interaction.MsgBox("User Not Found! Do you want to populate the values into Remedy?", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "System Message") == MsgBoxResult.Yes) {
					RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARSubmit, 1);

					if (TheGrid["Persalnr", e.RowIndex].Value.ToString().ToUpper().Trim().Length == 8) {
						RemedyForm.GetField("Persal Number").Value = TheGrid["Persalnr", e.RowIndex].Value.ToString().ToUpper();
					}

					RemedyForm.GetField("Last Name").Value = Strings.StrConv(TheGrid["Surname", e.RowIndex].Value.ToString(), VbStrConv.ProperCase);
					RemedyForm.GetField("First Name").Value = Strings.StrConv(TheGrid["Firstname", e.RowIndex].Value.ToString(), VbStrConv.ProperCase);
					RemedyForm.GetField("E-Mail").Value = TheGrid["EMail", e.RowIndex].Value.ToString().ToLower();
					RemedyForm.GetField("Cellphone").Value = TheGrid["Cell", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Fax Number").Value = TheGrid["Fax", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Telephone").Value = TheGrid["TelB", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("Rank").Value = TheGrid["Rank", e.RowIndex].Value.ToString().ToUpper();
					RemedyForm.GetField("VULINDLELA Role").Value = TheGrid["Responsibility", e.RowIndex].Value.ToString();
					RemedyForm.GetField("Title").Value = TheGrid["Title", e.RowIndex].Value.ToString().ToUpper();

					if (frmFrom == "frmResetPassword") {
					} else if (frmFrom == "frmNewUsers") {
						if (!string.IsNullOrEmpty(TheGrid["Dept", e.RowIndex].Value.ToString().ToUpper().Trim())) {
							RemedyForm.GetField("Department Name").Value = TheGrid["Dept", e.RowIndex].Value.ToString().ToUpper();
							RemedyForm.GetField("Department Type").Value = TheGrid["Province", e.RowIndex].Value.ToString().ToUpper();
						} else {
							wrong_department = TheGrid["DEPARTMENT", e.RowIndex].Value.ToString().ToLower();
							RemedyForm.GetField("Department Name").Value = TheGrid["DEPARTMENT", e.RowIndex].Value.ToString().ToLower();
							RemedyForm.GetField("Department Type").Value = "";
						}
					}
				}
			}

			if (persalnumber.ToString().Trim().Length == 13) {
				Tnumber = Interaction.InputBox("Please supply the newly created temporary Remedy persal number", "Input Required", "").ToUpper();
				persalnumber = Tnumber;
			}

			if (frmEnvironment.ChildFormPRD.Visible) {
				{
					frmEnvironment.ChildFormPRD.txtPersalNumber.Text = persalnumber;
					frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e);
					frmEnvironment.ChildFormPRD.txtPersalNumber.Focus();
					frmEnvironment.ChildFormPRD.txtPersalNumber.SelectAll();
					frmEnvironment.ChildFormPRD.timerCOUNTS.Start();
				}
				//Else
				{
					frmEnvironment.childformQA.txtPersalNumber.Text = persalnumber;
					frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e);
					frmEnvironment.childformQA.txtPersalNumber.Focus();
					frmEnvironment.childformQA.txtPersalNumber.SelectAll();
					frmEnvironment.childformQA.timerCOUNTS.Start();
				}
			}

		} catch (Exception ex) {
			if (Err().Number == -2147216287) {
				Interaction.MsgBox("An internal error occured please try again", MsgBoxStyle.Critical);
				if (frmEnvironment.ChildFormPRD.Visible) {
					frmEnvironment.ChildFormPRD.timerCOUNTS.Start();
				} else {
					frmEnvironment.childformQA.timerCOUNTS.Start();
				}
				return;
			} else {
				//MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.RetryCancel, "Remedy System Message")
				return;
			}
		}
		if (frmEnvironment.ChildFormPRD.Visible) {
			frmEnvironment.ChildFormPRD.timerCOUNTS.Start();
		} else {
			frmEnvironment.childformQA.timerCOUNTS.Start();
		}
		frmEnvironment.WindowState = FormWindowState.Minimized;
	}

	//Public Sub ChangeRemedyRequestStatus(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal eOpenMode As ARUSER.OpenMode, ByVal frmFrom As String)
	//End Sub

	public static string AppPath()
	{
		//AppPath = System.IO.Path.GetFullPath("..\")
		// Dis nou 'n baie elegante luigat manier om dit te doen
		return ExePath() + "\\";
	}

	public static string ExePath()
	{
		return System.IO.Path.GetFullPath(".");
	}

	public static string file2str(string PathAndFilename)
	{
		string functionReturnValue = null;

		try {
			// Create an instance of StreamReader to read from a file.
			using (StreamReader sr = new StreamReader(PathAndFilename)) {

				// Read in the entire file
				functionReturnValue = sr.ReadToEnd();
				sr.Close();
			}
		} catch (Exception E) {
			// Do nothing in case of an error
		}
		return functionReturnValue;

	}

	public static StreamReader file2stream(string PathAndFilename)
	{
		StreamReader functionReturnValue = null;

		try {
			StreamReader sr = new StreamReader(PathAndFilename);
			// Create an instance of StreamReader to read from a file.
			//Using sr As StreamReader = New StreamReader(PathAndFilename)

			// Read in the entire file
			functionReturnValue = sr;
			sr.Close();
		//End Using
		} catch (Exception E) {
			// Do nothing in case of an error
		}
		return functionReturnValue;

	}

	public static bool IsValidEmail(string strIn)
	{
		// Return true if strIn is in valid e-mail format.
		return Regex.IsMatch(strIn, "^(?(\")(\".+?\"@)|(([0-9a-zA-Z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-zA-Z])@))" + "(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,6}))$");
	}

}
