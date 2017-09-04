<%@ Page Language="VB" MasterPageFile="~/Webmentor.master" AutoEventWireup="false" CodeFile="ReferaFriend.aspx.vb" Inherits="ReferaFriend" %>
<%@ OutputCache Duration="1" Location="Client" VaryByParam="none" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <title>ReferralsHelp - Refer a Friend</title>
        <meta name="Description" content="Referralshelp - Refer a Friend" /> 
        <meta name="Keywords" content="Referralshelp.com - Refer a Friend" /> 
        <meta name="Copyright" content="Copyright (c) 2010, Omnus Business Trust" /> 
        <link href="style.css" rel="stylesheet" type="text/css" />
	</head>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server" defaultbutton="SubmitButton" 
    defaultfocus="txtYourEMail" target="_self" style="width: 761px">
    <p>
        <table align="center" border="0" cellpadding="1" cellspacing="1" 
            style="width: 752px; height: 457px;">
            <tr>
                <td align="justify" colspan="3" class="NormalVerdana" 
                    style="height: 24px; font-size: large; font-weight: bold; color: #009933;">
                    Refer me to your family / friends
                    </td>
            </tr>
            <tr>
                <td align="center" class="style22" colspan="3" style="height: 50px">
                    <br />
                    <span class="GreenVerdanaBoldCenter">Insert your own details below</span></td>
            </tr>
            <tr align="center">
                <td align="right" class="tdRight" colspan="2">
                    Your Name :
                </td>
                <td align="left" class="MyTdLeft">
                    <asp:TextBox ID="tRefererName" runat="server" CssClass="NormalLeftVerdana" 
                        TabIndex="1" Width="218px" Height="20px" BackColor="#FFFF99"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="tRefererName" ErrorMessage="*" Font-Bold="True" 
                        InitialValue=" " CssClass="ValidatorRED"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr align="center">
                <td align="right" class="tdRight" colspan="2">
                    Your EMail
                    :
                </td>
                <td align="left" class="MyTdLeft">
                    <asp:TextBox ID="tRefererEmail" runat="server" CssClass="NormalLeftVerdana" 
                        TabIndex="2" Width="218px" Height="20px" BackColor="#FFFF99"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="tRefererEmail" ErrorMessage="*" Font-Bold="True" 
                        InitialValue=" " CssClass="ValidatorRED" Font-Names="verdana" 
                        Font-Size="10pt"></asp:RequiredFieldValidator>
                    &nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                        ControlToValidate="tRefererEmail" ErrorMessage="**" Font-Bold="True" ForeColor="Blue" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        CssClass="ValidatorBLUE"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="center" class="style22" colspan="3" style="height: 30px">
                    <span class="GreenVerdanaBoldCenter">Now insert your friends&#39; details below</span></td>
            </tr>
            <tr>
                <td class="tdRight">Name #1 :</td>
                <td class="tdLeft" colspan="2" width=50%>
                    <asp:TextBox ID="tToName1" runat="server" CssClass="NormalLeftVerdana" TabIndex="3" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="tToName1" ErrorMessage="*" Font-Bold="True" 
                        InitialValue=" " CssClass="ValidatorRED" Font-Names="verdana" 
                        Font-Size="10pt"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="tdRight">EMail #1 :</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToEmail1" runat="server" CssClass="NormalLeftVerdana" TabIndex="4" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="tToEmail1" ErrorMessage="*" Font-Bold="True" 
                        Font-Size="10pt" InitialValue=" " CssClass="ValidatorRED" 
                        Font-Names="verdana"></asp:RequiredFieldValidator>
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator11" 
                        runat="server" ControlToValidate="tToEmail1" ErrorMessage="**" 
                        Font-Bold="True" ForeColor="Blue" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        CssClass="ValidatorBLUE"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="tdRight">Phone #1:</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToPhone1" runat="server" CssClass="NormalLeftVerdana" TabIndex="5" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                </td>
            </tr>
            <tr align="right" class="tdRight">
                <td class="tdCenter" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr align="right">
                <td class="tdRight">
                    Name #2 :</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToName2" runat="server" CssClass="NormalLeftVerdana" TabIndex="6" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                &nbsp;
                </td>
            </tr>
            <tr align="right">
                <td class="tdRight">
                    EMail #2 :</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToEmail2" runat="server" CssClass="NormalLeftVerdana" TabIndex="7" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
&nbsp; 
                </td>
            </tr>
            <tr align="right">
                <td class="tdRight">
                    Phone #2:</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToPhone2" runat="server" CssClass="NormalLeftVerdana" TabIndex="8" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdRight">
                <td class="tdCenter" colspan="3">
                    &nbsp;</td>
                </tr>
            <tr align="right">
                <td class="tdRight">Name #3 :</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToName3" runat="server" CssClass="NormalLeftVerdana" TabIndex="9" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                &nbsp;
                </td>
            </tr>
            <tr align="right">
                <td class="tdRight">EMail #3 :</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToEmail3" runat="server" CssClass="NormalLeftVerdana" TabIndex="10" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                    &nbsp;
                </td>
            </tr>
            <tr align="right">
                <td class="tdRight">Phone #3:</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToPhone3" runat="server" CssClass="NormalLeftVerdana" TabIndex="11" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdRight">
                <td class="tdCenter" colspan="3">
                    &nbsp;</td>
                </tr>
            <tr align="right">
                <td class="tdRight">
                    Name#4 :</td>
                <td class="tdLeft" colspan="2" style="height: 17px">
                    <asp:TextBox ID="tToName4" runat="server" CssClass="NormalLeftVerdana" TabIndex="12" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                &nbsp;
                </td>
            </tr>
            <tr align="right">
                <td class="tdRight">
                    EMail #4 :</td>
                <td class="tdLeft" colspan="2" style="height: 17px">
                    <asp:TextBox ID="tToEmail4" runat="server" CssClass="NormalLeftVerdana" TabIndex="13" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                    &nbsp;
                </td>
            </tr>
            <tr align="right">
                <td class="tdRight">
                    Phone #4:</td>
                <td class="tdLeft" colspan="2" style="height: 17px">
                    <asp:TextBox ID="tToPhone4" runat="server" CssClass="NormalLeftVerdana" TabIndex="14" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                </td>
            </tr>
            <tr class="tdRight">
                <td class="tdCenter" colspan="3">
                    &nbsp;</td>
                </tr>
            <tr align="right">
                <td class="tdRight">
                    Name#5 :</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToName5" runat="server" CssClass="NormalLeftVerdana" TabIndex="15" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                &nbsp;
                </td>
            </tr>
            <tr align="right">
                <td class="tdRight">
                    EMail #5 :</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToEmail5" runat="server" CssClass="NormalLeftVerdana" TabIndex="16" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                    &nbsp;
                </td>
            </tr>
            <tr align="right">
                <td class="tdRight">
                    Phone #5:</td>
                <td class="tdLeft" colspan="2">
                    <asp:TextBox ID="tToPhone5" runat="server" CssClass="NormalLeftVerdana" TabIndex="17" 
                        Width="233px" Wrap="False" Height="20px" BackColor="#99FF99"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="3">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:ImageButton ID="SubmitButton" runat="server" 
                        ImageUrl="~/Images/recommend me.png" 
                        TabIndex="18" AlternateText="Invite Them" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    </form>
</asp:Content>

