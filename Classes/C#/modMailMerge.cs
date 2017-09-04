using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

static class modMailMerge
{

	public static string ParseFile_Email_Batch(string TemplateFilePath, Collection FieldAndValues, Collection colTO, Collection colCC, string returnaddress, string persalnumber, [System.Runtime.InteropServices.OptionalAttribute, System.Runtime.InteropServices.DefaultParameterValueAttribute("")]  // ERROR: Optional parameters aren't supported in C#
string subject)
	{

		TextReader t = null;
		int i = 0;
		int j = 0;
		string[] a = null;
		string fil = null;
		MailMessage EmailMessage = new MailMessage();
		string thisusername = null;
		thisusername = Get_ValidUsername(persalnumber);

		t = new StreamReader(modFunctions.AppPath() + TemplateFilePath);
		fil = t.ReadToEnd();
		t.Close();
		t.Dispose();

		for (i = 1; i <= FieldAndValues.Count; i++) {
			a = Strings.Split(FieldAndValues[i], "~~");
			for (j = 0; j <= Information.UBound(a); j++) {
				if (j % 2 == 0) {
					fil = Strings.Replace(fil, "[[" + a[j] + "]]", a[j + 1]);
				}
			}
		}

		if (colTO.Count > 0) {
			for (i = 1; i <= colTO.Count; i++) {
				EmailMessage.To.Add(colTO[i].ToString().Trim());
			}
		}
		if (colCC.Count > 0) {
			for (i = 1; i <= colCC.Count; i++) {
				EmailMessage.CC.Add(colCC[i].ToString().Trim());
			}
		}

		EmailMessage.From = new MailAddress(returnaddress);
		if (string.IsNullOrEmpty(subject.Trim())) {
			EmailMessage.Subject = Strings.Replace(TemplateFilePath, ".htt", "") + " : " + thisusername.Trim();
		} else {
			EmailMessage.Subject = subject;
		}
		EmailMessage.Body = fil;
		EmailMessage.Priority = MailPriority.High;
		EmailMessage.IsBodyHtml = true;

		SmtpClient smtp = new SmtpClient(My.Settings.SMPTServerIPAddress.Trim);
		smtp.Send(EmailMessage);
		smtp = null;


	}

	public static string ParseFile_Email(string TemplateFilePath, Collection FieldAndValues, Collection colTO, Collection colCC, string returnaddress, [System.Runtime.InteropServices.OptionalAttribute, System.Runtime.InteropServices.DefaultParameterValueAttribute("")]  // ERROR: Optional parameters aren't supported in C#
string subject)
	{

		TextReader t = null;
		int i = 0;
		int j = 0;
		string[] a = null;
		string fil = null;
		MailMessage EmailMessage = new MailMessage();
		string thisusername = null;
		string apppath = null;
		if (frmEnvironment.ChildFormPRD.Visible) {
			thisusername = Get_ValidUsername(frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim.ToUpper);
		} else {
			thisusername = Get_ValidUsername(frmEnvironment.childformQA.txtPersalNumber.Text.Trim.ToUpper);
		}

		t = new StreamReader(apppath + TemplateFilePath);
		fil = t.ReadToEnd();
		t.Close();
		t.Dispose();

		for (i = 1; i <= FieldAndValues.Count; i++) {
			a = Strings.Split(FieldAndValues[i], "~~");
			for (j = 0; j <= Information.UBound(a); j++) {
				if (j % 2 == 0) {
					fil = Strings.Replace(fil, "[[" + a[j] + "]]", a[j + 1]);
				}
			}
		}

		if (colTO.Count > 0) {
			for (i = 1; i <= colTO.Count; i++) {
				EmailMessage.To.Add(colTO[i].ToString().Trim());
			}
		}

		if (colCC.Count > 0) {
			for (i = 1; i <= colCC.Count; i++) {
				EmailMessage.CC.Add(colCC[i].ToString().Trim());
			}
		}

		EmailMessage.From = new MailAddress(returnaddress);
		if (string.IsNullOrEmpty(subject.Trim())) {
			EmailMessage.Subject = Strings.Replace(TemplateFilePath, ".htt", "") + " : " + thisusername.Trim();
		} else {
			EmailMessage.Subject = subject;
		}
		EmailMessage.Body = fil;
		EmailMessage.Priority = MailPriority.High;
		EmailMessage.IsBodyHtml = true;
		//Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString("<img src=cid:ntlogo>", Nothing, "text/html")
		AlternateView htmlView = AlternateView.CreateAlternateViewFromString(EmailMessage.Body, null, "text/html");
		apppath = System.AppDomain.CurrentDomain.BaseDirectory;
		LinkedResource logo = new LinkedResource(apppath + "NTlogo.jpg");
		LinkedResource explain = new LinkedResource(apppath + "ResetPassAnnotate.jpg");
		logo.ContentId = "ntlogo";
		explain.ContentId = "ntexplain";
		htmlView.LinkedResources.Add(logo);
		htmlView.LinkedResources.Add(explain);
		EmailMessage.AlternateViews.Add(htmlView);

		SmtpClient smtp = new SmtpClient(My.Settings.SMPTServerIPAddress.Trim);
		smtp.Send(EmailMessage);

		smtp = null;
		logo = null;
		explain = null;

	}

	public static void EmbedImages()
	{
		//create the mail message
		MailMessage mail = new MailMessage();

		//set the addresses
		mail.From = new MailAddress("me@mycompany.com");
		mail.To.Add("you@yourcompany.com");

		//set the content
		mail.Subject = "This is an email";

		//first we create the Plain Text part
		AlternateView plainView = AlternateView.CreateAlternateViewFromString("This is my plain text content, viewable by those clients that don't support html", null, "text/plain");

		//then we create the Html part
		//to embed images, we need to use the prefix 'cid' in the img src value
		//the cid value will map to the Content-Id of a Linked resource.
		//thus <img src='cid:companylogo'> will map to a LinkedResource with a ContentId of 'companylogo'
		AlternateView htmlView = AlternateView.CreateAlternateViewFromString("Here is an embedded image.<img src=cid:companylogo>", null, "text/html");

		//create the LinkedResource (embedded image)
		LinkedResource logo = new LinkedResource("c:\\temp\\logo.gif");
		logo.ContentId = "companylogo";
		//add the LinkedResource to the appropriate view
		htmlView.LinkedResources.Add(logo);

		//add the views
		mail.AlternateViews.Add(plainView);
		mail.AlternateViews.Add(htmlView);


		//send the message
		SmtpClient smtp = new SmtpClient("127.0.0.1");
		//specify the mail server address
		smtp.Send(mail);
	}
	//EmbedImages

	public static string ParseFile_EMail_To_Verify_Against_Establishment(string TemplateFilePath, Collection FieldAndValues)
	{

		TextReader t = null;
		int i = 0;
		int j = 0;
		string[] a = null;
		string fil = null;
		MailMessage EmailMessage = new MailMessage();
		string thisusername = null;
		if (frmEnvironment.ChildFormPRD.Visible) {
			thisusername = Get_ValidUsername(frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim.ToUpper);
		} else {
			thisusername = Get_ValidUsername(frmEnvironment.childformQA.txtPersalNumber.Text.Trim.ToUpper);
		}

		// This portion is used to merge the HTT file into HTML format
		t = new StreamReader(TemplateFilePath);
		fil = t.ReadToEnd();
		t.Close();
		t.Dispose();

		for (i = 1; i <= FieldAndValues.Count; i++) {
			a = Strings.Split(FieldAndValues[i], "=");
			for (j = 0; j <= Information.UBound(a); j++) {
				if (j % 2 == 0) {
					fil = Strings.Replace(fil, "[[" + a[j] + "]]", a[j + 1]);
				}
			}
		}

		// This portion is used to merge the [1.email.addresses] file 
		// to be used in a collection for the addresses
		TextReader k = new StreamReader(modFunctions.AppPath() + "EMail To Verify Against Establishment.email.addresses");

		//b1 - Posistion the pointer after the first line in the file
		string[] b1 = null;
		b1 = Strings.Split(k.ReadLine(), ";");
		for (i = 0; i <= Information.UBound(b1); i++) {
			EmailMessage.To.Add(b1[i]);
		}

		//b2 - Carbon Copy 
		string[] b2 = null;
		b2 = Strings.Split(k.ReadLine(), ";");
		for (i = 0; i <= Information.UBound(b2); i++) {
			EmailMessage.CC.Add(b2[i]);
		}

		//b3 - ReturnMailAddress 
		string b3 = null;
		b3 = k.ReadLine();
		EmailMessage.From = new MailAddress(b3);

		//b4 - Subject line
		string b4 = null;
		b4 = k.ReadLine();
		EmailMessage.Subject = b4 + " : " + thisusername.Trim();
		EmailMessage.Body = fil;
		EmailMessage.Priority = MailPriority.High;
		EmailMessage.IsBodyHtml = true;
		SmtpClient smtp = new SmtpClient(My.Settings.SMPTServerIPAddress.Trim);
		smtp.Send(EmailMessage);
		smtp = null;
		k.Dispose();

	}

	public static string ParseFile_Vulindlela_User_Account_Reset(string TemplateFilePath, Collection FieldAndValues)
	{

		TextReader t = null;
		int i = 0;
		int j = 0;
		string[] a = null;
		string fil = null;
		MailMessage EmailMessage = new MailMessage();
		string thisusername = null;
		if (frmEnvironment.ChildFormPRD.Visible) {
			thisusername = Get_ValidUsername(frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim.ToUpper);
		} else {
			thisusername = Get_ValidUsername(frmEnvironment.childformQA.txtPersalNumber.Text.Trim.ToUpper);
		}

		// This portion is used to merge the HTT file into HTML format
		t = new StreamReader(TemplateFilePath);
		fil = t.ReadToEnd();
		t.Close();
		t.Dispose();

		for (i = 1; i <= FieldAndValues.Count; i++) {
			a = Strings.Split(FieldAndValues[i], "=");
			for (j = 0; j <= Information.UBound(a); j++) {
				if (j % 2 == 0) {
					fil = Strings.Replace(fil, "[[" + a[j] + "]]", a[j + 1]);
				}
			}
		}

		// This portion is used to merge the [1.email.addresses] file 
		// to be used in a collection for the addresses
		TextReader k = new StreamReader(modFunctions.AppPath() + "Vulindlela User Account Reset.email.addresses");

		//Posistion the pointer after the first line in the file
		k.ReadLine();
		// Gets the value from FieldAndValues that gets passed here
		EmailMessage.To.Add(Strings.Replace(FieldAndValues[3], "EMail_Address=", ""));

		//b2 is the Carbon Copy 
		string[] b2 = null;
		b2 = Strings.Split(k.ReadLine(), ";");
		for (i = 0; i <= Information.UBound(b2); i++) {
			EmailMessage.CC.Add(b2[i]);
		}

		//b3 ReturnMailAddress 
		string b3 = null;
		b3 = k.ReadLine();
		EmailMessage.From = new MailAddress(b3);

		//b4 is the Subject line
		string b4 = null;
		b4 = k.ReadLine();
		EmailMessage.Subject = b4 + " : " + thisusername.Trim();
		EmailMessage.Body = fil;
		EmailMessage.Priority = MailPriority.High;
		EmailMessage.IsBodyHtml = true;
		SmtpClient smtp = new SmtpClient(My.Settings.SMPTServerIPAddress.Trim);
		if (Interaction.MsgBox("Force a Password change as well?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "System Message") == MsgBoxResult.Yes) {
			Do_ExpirePasswordNow(thisusername);
		}
		smtp.Send(EmailMessage);
		smtp = null;
		k.Dispose();

	}

	public static string ParseFileAspTags(string TemplateFilePath, Collection FieldAndValues)
	{

		TextReader t = null;
		int i = 0;
		int j = 0;
		string[] a = null;
		string fil = null;
		MailMessage EmailMessage = new MailMessage();
		Microsoft.VisualBasic.Collection fc = new Microsoft.VisualBasic.Collection();
		string thisusername = null;
		if (frmEnvironment.ChildFormPRD.Visible) {
			thisusername = Get_ValidUsername(frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim.ToUpper);
		} else {
			thisusername = Get_ValidUsername(frmEnvironment.childformQA.txtPersalNumber.Text.Trim.ToUpper);
		}

		// This portion is used to merge the HTT file into HTML format
		t = new StreamReader(TemplateFilePath);
		fil = t.ReadToEnd();
		t.Close();
		t.Dispose();

		for (i = 1; i <= FieldAndValues.Count; i++) {
			a = Strings.Split(FieldAndValues[i], "=");
			for (j = 0; j <= Information.UBound(a); j++) {
				if (j % 2 == 0) {
					fil = Strings.Replace(fil, "<%" + a[j] + "%>", a[j + 1]);
				}
			}
		}

		// This portion is used to merge the [1.email.addresses] file 
		// to be used in a collection for the addresses
		TextReader k = new StreamReader(modFunctions.AppPath() + "Vulindlela User Account Reset.email.addresses");

		//Posistion the pointer after the first line in the file
		k.ReadLine();
		// Gets the value from FieldAndValues that gets passed here
		EmailMessage.To.Add(Strings.Replace(FieldAndValues[3], "EMail_Address=", ""));

		//b2 is the Carbon Copy 
		string[] b2 = null;
		b2 = Strings.Split(k.ReadLine(), ";");
		for (i = 0; i <= Information.UBound(b2); i++) {
			EmailMessage.CC.Add(b2[i]);
		}

		//b3 ReturnMailAddress 
		string b3 = null;
		b3 = k.ReadLine();
		EmailMessage.From = new MailAddress(b3);

		//b4 is the Subject line
		string b4 = null;
		b4 = k.ReadLine();
		EmailMessage.Subject = b4 + " : " + thisusername.Trim();
		EmailMessage.Body = fil;
		EmailMessage.Priority = MailPriority.High;
		EmailMessage.IsBodyHtml = true;
		SmtpClient smtp = new SmtpClient(My.Settings.SMPTServerIPAddress.Trim);
		if (Interaction.MsgBox("Force a Password change as well?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "System Message") == MsgBoxResult.Yes) {
			Do_ExpirePasswordNow(thisusername);
		}
		smtp.Send(EmailMessage);
		smtp = null;
		k.Dispose();

	}

}
