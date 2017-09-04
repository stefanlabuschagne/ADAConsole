using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

static class modAccessControl
{

	public static DirectorySecurity AddSecurityAccessRule()
	{

		DirectorySecurity securityRules = new DirectorySecurity();
		securityRules.AddAccessRule(new FileSystemAccessRule(GetDomainame().Trim() + "\\" + GetUsername().Trim(), FileSystemRights.FullControl, AccessControlType.Allow));
		return securityRules;

	}

	public static string GetDomainame()
	{

		string strDomain = null;
		strDomain = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
		strDomain = Strings.Mid(strDomain, 1, Strings.InStr(strDomain, "\\") - 1);
		return strDomain;

	}

	public static string GetUsername()
	{
		return (System.Environment.UserName);
	}

}
