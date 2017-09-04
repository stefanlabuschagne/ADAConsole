using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

 // ERROR: Not supported in C#: OptionDeclaration
using System.Data.SqlClient;

static class modADSExport
{


	public static void Create_Snapshot()
	{
		object authenticate = null;
		object mvarsError = null;
		object memberOF = null;
		object mstr = null;
		object f = null;
		//oCont)
		string appstr = null;
		string govstr = null;
		string strc = null;
		string strDepartment = null;
		ActiveDs.IADsUser oUser = default(ActiveDs.IADsUser);
		ActiveDs.IADsContainer oContainer = default(ActiveDs.IADsContainer);
		ActiveDs.IADsOpenDSObject dso = default(ActiveDs.IADsOpenDSObject);
		string xas = null;
		string appl = null;
		string[] a = null;
		string[] temparray = null;
		string tempstr = null;
		string[] aGovernment = null;
		object entry = null;
		int temporaryDate2 = 0;
		int date2 = 0;
		int i = 0;
		int y = 0;
		int mcount = 0;
		object mmax = null;
		string strApps = null;
		string strGovt = null;
		int UCount = 0;
		Microsoft.VisualBasic.Collection colGovernment = new Microsoft.VisualBasic.Collection();
		Microsoft.VisualBasic.Collection colApplications = new Microsoft.VisualBasic.Collection();
		string memberOFS = "";
		SqlConnection cnVIP_EXP = new SqlConnection();

		cnVIP_EXP.ConnectionString = My.Settings.VIP_EXPANDEDConnectionString;

		SqlConnection cnADS2 = new SqlConnection();
		SqlConnection cnADS = new SqlConnection();

		cnADS.ConnectionString = My.Settings.AdsConnectionString;
		cnADS2.ConnectionString = My.Settings.AdsConnectionString;

		SqlCommand cmdADS2 = new SqlCommand("AD_SNAPSHOT_ALL_INSERT", cnADS);
		SqlCommand cmdADS3 = new SqlCommand("AD_SNAPSHOT_ALL_DELETE_ALL", cnADS);
		SqlCommand cmdADS4 = new SqlCommand("GetPROVDescription", cnADS2);
		SqlCommand cmdADS5 = new SqlCommand("GetSNAMEDept", cnADS2);

		cmdADS2.CommandType = CommandType.StoredProcedure;
		cmdADS3.CommandType = CommandType.StoredProcedure;
		cmdADS4.CommandType = CommandType.StoredProcedure;
		cmdADS5.CommandType = CommandType.StoredProcedure;

		SqlParameter pUCount = new SqlParameter("@UCount", SqlDbType.BigInt);
		SqlParameter pPersalnr = new SqlParameter("@PersalNr", SqlDbType.VarChar, 8);
		SqlParameter pAccountNr = new SqlParameter("@AccountNr", SqlDbType.VarChar, 9);
		SqlParameter pNatProv = new SqlParameter("@NatProv ", SqlDbType.VarChar, 20);
		SqlParameter pVote = new SqlParameter("@Vote", SqlDbType.VarChar, 55);
		SqlParameter pDeptCode = new SqlParameter("@DeptCode", SqlDbType.VarChar, 9);
		SqlParameter pEMail = new SqlParameter("@EMail", SqlDbType.VarChar, 150);
		SqlParameter pCell = new SqlParameter("@Cell", SqlDbType.VarChar, 20);
		SqlParameter pPhone = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
		SqlParameter pFirstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 20);
		SqlParameter pLastname = new SqlParameter("@Lastname", SqlDbType.VarChar, 40);
		SqlParameter pApplMember = new SqlParameter("@ApplMember", SqlDbType.VarChar, 500);
		SqlParameter pDeptMember = new SqlParameter("@DeptMember", SqlDbType.VarChar, 4000);
		SqlParameter pDepartment = new SqlParameter("@Department", SqlDbType.VarChar, 10);
		SqlParameter pAccountDisabled = new SqlParameter("@AccountDisabled", SqlDbType.SmallInt);
		SqlParameter pLOGIS = new SqlParameter("@LOGIS", SqlDbType.SmallInt);
		SqlParameter pHR = new SqlParameter("@HR", SqlDbType.SmallInt);
		SqlParameter pFINANCIALS = new SqlParameter("@FINANCIALS", SqlDbType.SmallInt);
		SqlParameter pGFS = new SqlParameter("@GFS", SqlDbType.SmallInt);
		SqlParameter pDPSA = new SqlParameter("@DPSA", SqlDbType.SmallInt);
		SqlParameter pSNAME = new SqlParameter("@SNAME", SqlDbType.VarChar, 9);

		ClsCrypto enc = new ClsCrypto();

		dso = Interaction.GetObject("LDAP:");
		oContainer = dso.OpenDSObject("LDAP://" + My.Settings.IP_ADDRESS_PRD + "/" + My.Settings.AD_USERS_PRD, My.Settings.ADSMasterUsername_PRD, enc.Dekodeer128(My.Settings.ADSMasterPassword_PRD.ToString), 0);
		cnADS.Open();
		cmdADS3.ExecuteNonQuery();

		foreach ( oUser in oContainer) {
			UCount += 1;
			pUCount.Value = UCount;
			mcount = mcount + 1;
			switch (Strings.LCase(oUser.Class)) {

				case "user":

					if ((Strings.Trim(oUser.SAMaccountname) != null)) {
						frmMain.tsADPosition.Text = oUser.samaccountname;
						pSNAME.Value = oUser.Department.ToLower.ToString.Trim + "";
						cmdADS5.Parameters.Add(pSNAME);
						cnADS2.Open();
						pVote.Value = cmdADS5.ExecuteScalar().ToString() + "";
						cnADS2.Close();
						cmdADS5.Parameters.Remove(pSNAME);

						 // ERROR: Not supported in C#: OnErrorStatement

						pAccountNr.Value = oUser.SAMaccountname.ToString.Trim + "";
						cmdADS4.Parameters.Add(pSNAME);
						cnADS2.Open();
						pNatProv.Value = cmdADS4.ExecuteScalar().ToString() + "";
						cnADS2.Close();
						cmdADS4.Parameters.Remove(pSNAME);

						pDeptCode.Value = pSNAME.Value + "";

						if (Information.IsDBNull(Strings.Trim(oUser.EmailAddress))) {
							pEMail.Value = "No Email";
						} else {
							pEMail.Value = oUser.EmailAddress.ToLower.Trim + "";
						}

						if (Information.IsDBNull(Convert.ToString(oUser.TelephoneMobile)) | (oUser.TelephoneMobile == null)) {
							pCell.Value = "No Mobile";
						} else {
							pCell.Value = Strings.Replace(Strings.Replace(Convert.ToString(oUser.TelephoneMobile), "(", ""), ")", "");
						}

						if (Information.IsDBNull(Convert.ToString(oUser.TelephoneNumber))) {
							pPhone.Value = "No TelephoneNumber";
						} else {
							pPhone.Value = Strings.Replace(Strings.Replace(oUser.TelephoneNumber.ToString, "(", ""), ")", "") + "";
						}

						if (Information.IsDBNull(oUser.FirstName)) {
							pFirstName.Value = "No Firstname";
						} else {
							pFirstName.Value = oUser.FirstName.Trim + "";
						}

						if (Information.IsDBNull(oUser.LastName)) {
							pLastname.Value = "No LastName";
						} else {
							pLastname.Value = oUser.LastName.Trim + "";
						}

						memberOF = oUser.GetEx("MemberOf");

						if (Err().Number == -2147463155) {
							colApplications.Add("INVALID USER");
							colGovernment.Add("INVALID USER");
							pLOGIS.Value = 0;
							pDPSA.Value = 0;
							pGFS.Value = 0;
							pHR.Value = 0;
							pFINANCIALS.Value = 0;
						} else {
							// Start with the new structure.
							memberOFS = "";

							foreach (object entry_loopVariable in memberOF) {
								entry = entry_loopVariable;
								//Clear collections

								if ((Strings.InStr(1, Strings.UCase(entry), "GOVERNMENT") > 0 | Strings.InStr(1, Strings.UCase(entry), "VUL TS USERS") > 0 | Strings.InStr(1, Strings.UCase(entry), "APPLICATION") > 0) & Strings.InStr(1, Strings.UCase(entry), "CN=") > 0) {
									entry = Strings.Replace(Strings.Replace(entry, "OU=", ""), "CN=", "");

									temparray = Strings.Split(entry, ",");
									tempstr = Strings.Replace(temparray[0], "_ACCESS_ALL", "");
									tempstr = Strings.Replace(tempstr, "_ALL_ACCESS", "");
									tempstr = Strings.Replace(tempstr, "_SEC32", "");

									if (Strings.InStr(1, Strings.UCase(entry), "GOVERNMENT") > 0) {
										colGovernment.Add(tempstr);
									} else if (Strings.InStr(1, Strings.UCase(entry), "APPLICATION") > 0 | Strings.InStr(1, Strings.UCase(entry), "VUL TS USERS") > 0) {
										memberOFS = memberOFS + " " + tempstr + "";
										colApplications.Add(tempstr);
									}

								}

							}

							pLOGIS.Value = (Strings.InStr(1, memberOFS, "LOGIS.") > 0 ? 1 : 0);
							pDPSA.Value = (Strings.InStr(1, memberOFS, "DPSA.") > 0 ? 1 : 0);
							pGFS.Value = (Strings.InStr(1, memberOFS, "GFS.") > 0 ? 1 : 0);
							pHR.Value = (Strings.InStr(1, memberOFS, "HR.") > 0 ? 1 : 0);
							pFINANCIALS.Value = (Strings.InStr(1, memberOFS, "FINANCIALS.") > 0 ? 1 : 0);

						}

						strApps = "";
						for (y = 1; y <= colApplications.Count(); y++) {
							if (Strings.Len(strApps) == 0) {
								strApps = colApplications[y];
							} else {
								strApps = strApps + "," + colApplications[y] + "";
							}
						}

						if (Strings.Len(Strings.Trim(strApps)) == 0) {
							strApps = "INVALID USER";
						}
						pApplMember.Value = strApps;

						strGovt = "";
						for (y = 1; y <= colGovernment.Count(); y++) {
							if (Strings.Len(strGovt) == 0) {
								strGovt = colGovernment[y];
							} else {
								strGovt = strGovt + "," + colGovernment[y] + "";
							}
						}
						pDeptMember.Value = strGovt;
						strDepartment = "";
						strDepartment = oUser.Department + "";
						if (Strings.Len(Strings.Trim(strDepartment)) == 0) {
							pDepartment.Value = "No Department";
						} else {
							pDepartment.Value = oUser.Department + "";
						}
						if ((Convert.ToString(oUser.AccountDisabled)).ToUpper().Trim() == "TRUE") {
							pAccountDisabled.Value = 1;
						} else {
							pAccountDisabled.Value = 0;
						}
						//pAccountDisabled.Value = CStr(oUser.AccountDisabled)

						cmdADS2.Parameters.Add(pAccountNr);
						cmdADS2.Parameters.Add(pNatProv);
						cmdADS2.Parameters.Add(pVote);
						cmdADS2.Parameters.Add(pDeptCode);
						cmdADS2.Parameters.Add(pEMail);
						cmdADS2.Parameters.Add(pCell);
						cmdADS2.Parameters.Add(pPhone);
						cmdADS2.Parameters.Add(pFirstName);
						cmdADS2.Parameters.Add(pLastname);
						cmdADS2.Parameters.Add(pApplMember);
						cmdADS2.Parameters.Add(pDeptMember);
						cmdADS2.Parameters.Add(pDepartment);
						cmdADS2.Parameters.Add(pAccountDisabled);
						cmdADS2.Parameters.Add(pLOGIS);
						cmdADS2.Parameters.Add(pHR);
						cmdADS2.Parameters.Add(pFINANCIALS);
						cmdADS2.Parameters.Add(pGFS);
						cmdADS2.Parameters.Add(pDPSA);
						cmdADS2.Parameters.Add(pUCount);
						//cmdADS2.Parameters.Add(pAccCreated)
						//cmdADS2.Parameters.Add(pAccModified)


						//**************************    

						cmdADS2.ExecuteNonQuery();

						//**************************    
						cmdADS2.Parameters.Remove(pAccountNr);
						cmdADS2.Parameters.Remove(pNatProv);
						cmdADS2.Parameters.Remove(pVote);
						cmdADS2.Parameters.Remove(pDeptCode);
						cmdADS2.Parameters.Remove(pEMail);
						cmdADS2.Parameters.Remove(pCell);
						cmdADS2.Parameters.Remove(pPhone);
						cmdADS2.Parameters.Remove(pFirstName);
						cmdADS2.Parameters.Remove(pLastname);
						cmdADS2.Parameters.Remove(pApplMember);
						cmdADS2.Parameters.Remove(pDeptMember);
						cmdADS2.Parameters.Remove(pDepartment);
						cmdADS2.Parameters.Remove(pAccountDisabled);
						cmdADS2.Parameters.Remove(pLOGIS);
						cmdADS2.Parameters.Remove(pHR);
						cmdADS2.Parameters.Remove(pFINANCIALS);
						cmdADS2.Parameters.Remove(pGFS);
						cmdADS2.Parameters.Remove(pDPSA);

						colGovernment.Clear();
						colApplications.Clear();

					}

					break;
			}

			Err().Clear();

		}

		frmMain.tsADPosition.Text = "";
		CloseMe:

		goto cleanup;
		err_handler:

		mvarsError = "{ADS4.authenticate} authenticate: (" + Err().Number + ") " + Err().Description;
		Err().Clear();
		authenticate = false;
		cleanup:

		oUser = null;
		memberOF = null;
		oContainer = null;
		oUser = null;
		dso = null;
		colGovernment = null;
		colApplications = null;
		cnADS.Close();
		cnADS = null;

	}

}
