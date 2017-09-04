Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

Namespace BMC8

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="PortSoapBinding", [Namespace]:="urn:LOG_DM_Customer_Information_BasicWS__c")> _
    Partial Public Class LOG_DM_Customer_Information_BasicWS__cService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        Private authenticationInfoValueField As AuthenticationInfo
        Private CreateOperationCompleted As System.Threading.SendOrPostCallback
        Private GetOperationCompleted As System.Threading.SendOrPostCallback
        Private SetOperationCompleted As System.Threading.SendOrPostCallback
        Private ServiceOperationCompleted As System.Threading.SendOrPostCallback
        Private GetListOperationCompleted As System.Threading.SendOrPostCallback
        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = "http://prodlgremv1/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_DM_Customer_Information_BasicWS__c"
        End Sub

        Public Property AuthenticationInfoValue() As AuthenticationInfo
            Get
                Return Me.authenticationInfoValueField
            End Get
            Set(ByVal value As AuthenticationInfo)
                Me.authenticationInfoValueField = value
            End Set
        End Property

        Public Event CreateCompleted As CreateCompletedEventHandler
        Public Event GetCompleted As GetCompletedEventHandler
        Public Event SetCompleted As SetCompletedEventHandler
        Public Event ServiceCompleted As ServiceCompletedEventHandler
        Public Event GetListCompleted As GetListCompletedEventHandler
        <System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticationInfoValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:LOG_DM_Customer_Information_BasicWS__c/Create", RequestNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", ResponseNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function Create( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As Record_StatusType, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    <System.Xml.Serialization.XmlElementAttribute("E-Mail"), System.ComponentModel.DefaultValueAttribute("None")> ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As Remote_Access_AvailabilityType, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    <System.Xml.Serialization.XmlElementAttribute("zDispRe-AssignCallsOpen")> ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-FMS")> ByVal PreFMS As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-EFT")> ByVal PreEFT As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-PER")> ByVal PrePER As String, _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True), System.Xml.Serialization.XmlIgnoreAttribute()> ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String) As <System.Xml.Serialization.XmlElementAttribute("Entry_ID")> String
            Dim results() As Object = Me.Invoke("Create", New Object() {Submitter, Department_Name, Record_Status, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginCreate( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As Record_StatusType, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As Remote_Access_AvailabilityType, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String, _
                    ByVal callback As System.AsyncCallback, _
                    ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("Create", New Object() {Submitter, Department_Name, Record_Status, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndCreate(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub CreateAsync( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As Record_StatusType, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As Remote_Access_AvailabilityType, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String)
            Me.CreateAsync(Submitter, Department_Name, Record_Status, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub CreateAsync( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As Record_StatusType, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As Remote_Access_AvailabilityType, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String, _
                    ByVal userState As Object)
            If (Me.CreateOperationCompleted Is Nothing) Then
                Me.CreateOperationCompleted = AddressOf Me.OnCreateOperationCompleted
            End If
            Me.InvokeAsync("Create", New Object() {Submitter, Department_Name, Record_Status, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field}, Me.CreateOperationCompleted, userState)
        End Sub

        Private Sub OnCreateOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateCompleted(Me, New CreateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticationInfoValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:LOG_DM_Customer_Information_BasicWS__c/Get", RequestNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", ResponseNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function [Get]( _
                    ByRef Entry_ID As String, _
                    ByRef Create_Date As Date, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef Create_DateSpecified As Boolean, _
                    ByRef Department_Name As String, _
                    ByRef Last_Modified_By As String, _
                    ByRef Modified_Date As Date, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef Modified_DateSpecified As Boolean, _
                    ByRef Record_Status As Record_StatusType, _
                    ByRef Persal_Number As String, _
                    ByRef Status_History As String, _
                    ByRef First_Name As String, _
                    ByRef Last_Name As String, _
                    ByRef Telephone As String, _
                    ByRef Fax_Number As String, _
                    <System.Xml.Serialization.XmlElementAttribute("E-Mail"), System.ComponentModel.DefaultValueAttribute("None")> ByRef EMail As String, _
                    ByRef Title As String, _
                    ByRef Department_Type As String, _
                    ByRef VULINDLELA_Role As String, _
                    ByRef Initial As String, _
                    ByRef Comments As String, _
                    ByRef Nickname As String, _
                    ByRef Remote_Access_Availability As Remote_Access_AvailabilityType, _
                    ByRef LOGIS_Store_Number As String, _
                    ByRef Rank As String, _
                    ByRef LOGIS_Role As String, _
                    ByRef zDispPersalNo As Integer, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef zDispPersalNoSpecified As Boolean, _
                    ByRef zDispChangeStoreNo As String, _
                    ByRef zDispUserResponse As String, _
                    ByRef zDispDefaultDateForNew As Date, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef zDispDefaultDateForNewSpecified As Boolean, _
                    ByRef Postal_Address As String, _
                    ByRef City As String, _
                    ByRef Province As String, _
                    ByRef Postal_Code As String, _
                    ByRef zDispCheckDuplicate As String, _
                    ByRef zDispClose As String, _
                    ByRef zDispCallsOpen As String, _
                    <System.Xml.Serialization.XmlElementAttribute("zDispRe-AssignCallsOpen")> ByRef zDispReAssignCallsOpen As String, _
                    ByRef zDispOldPersalNo As String, _
                    ByRef zDispWrongDept As String, _
                    ByRef BAS_Store_Number As String, _
                    ByRef VULIN_Store_Number As String, _
                    ByRef zDispStoreNo As String, _
                    ByRef zDispSystemGroup As String, _
                    ByRef BAS_Role As String, _
                    ByRef zDispNoStoreNumber As String, _
                    ByRef zDispRole As String, _
                    ByRef Region As String, _
                    ByRef Cellphone As String, _
                    ByRef Extension As String, _
                    ByRef Billing_Code As String, _
                    ByRef PERSAL_Store_Number As String, _
                    ByRef FMS_Store_Number As String, _
                    ByRef PERSAL_Role As String, _
                    ByRef FMS_Role As String, _
                    ByRef zDispReAssignPersalNo As String, _
                    ByRef Database As String, _
                    ByRef User_Code As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-FMS")> ByRef PreFMS As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-EFT")> ByRef PreEFT As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-PER")> ByRef PrePER As String, _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByRef zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True), System.Xml.Serialization.XmlIgnoreAttribute()> ByRef zDispInternal_Specified As Boolean, _
                    ByRef zValidPersalNumber As String, _
                    ByRef Temp_Postal_Address As String, _
                    ByRef Temp_Postal_Code As String, _
                    ByRef Character_Field As String) As <System.Xml.Serialization.XmlElementAttribute("Submitter")> String
            Dim results() As Object = Me.Invoke("Get", New Object() {Entry_ID})
            Entry_ID = CType(results(1), String)
            Create_Date = CType(results(2), Date)
            Create_DateSpecified = CType(results(3), Boolean)
            Department_Name = CType(results(4), String)
            Last_Modified_By = CType(results(5), String)
            Modified_Date = CType(results(6), Date)
            Modified_DateSpecified = CType(results(7), Boolean)
            Record_Status = CType(results(8), Record_StatusType)
            Persal_Number = CType(results(9), String)
            Status_History = CType(results(10), String)
            First_Name = CType(results(11), String)
            Last_Name = CType(results(12), String)
            Telephone = CType(results(13), String)
            Fax_Number = CType(results(14), String)
            EMail = CType(results(15), String)
            Title = CType(results(16), String)
            Department_Type = CType(results(17), String)
            VULINDLELA_Role = CType(results(18), String)
            Initial = CType(results(19), String)
            Comments = CType(results(20), String)
            Nickname = CType(results(21), String)
            Remote_Access_Availability = CType(results(22), Remote_Access_AvailabilityType)
            LOGIS_Store_Number = CType(results(23), String)
            Rank = CType(results(24), String)
            LOGIS_Role = CType(results(25), String)
            zDispPersalNo = CType(results(26), Integer)
            zDispPersalNoSpecified = CType(results(27), Boolean)
            zDispChangeStoreNo = CType(results(28), String)
            zDispUserResponse = CType(results(29), String)
            zDispDefaultDateForNew = CType(results(30), Date)
            zDispDefaultDateForNewSpecified = CType(results(31), Boolean)
            Postal_Address = CType(results(32), String)
            City = CType(results(33), String)
            Province = CType(results(34), String)
            Postal_Code = CType(results(35), String)
            zDispCheckDuplicate = CType(results(36), String)
            zDispClose = CType(results(37), String)
            zDispCallsOpen = CType(results(38), String)
            zDispReAssignCallsOpen = CType(results(39), String)
            zDispOldPersalNo = CType(results(40), String)
            zDispWrongDept = CType(results(41), String)
            BAS_Store_Number = CType(results(42), String)
            VULIN_Store_Number = CType(results(43), String)
            zDispStoreNo = CType(results(44), String)
            zDispSystemGroup = CType(results(45), String)
            BAS_Role = CType(results(46), String)
            zDispNoStoreNumber = CType(results(47), String)
            zDispRole = CType(results(48), String)
            Region = CType(results(49), String)
            Cellphone = CType(results(50), String)
            Extension = CType(results(51), String)
            Billing_Code = CType(results(52), String)
            PERSAL_Store_Number = CType(results(53), String)
            FMS_Store_Number = CType(results(54), String)
            PERSAL_Role = CType(results(55), String)
            FMS_Role = CType(results(56), String)
            zDispReAssignPersalNo = CType(results(57), String)
            Database = CType(results(58), String)
            User_Code = CType(results(59), String)
            PreFMS = CType(results(60), String)
            PreEFT = CType(results(61), String)
            PrePER = CType(results(62), String)
            zDispInternal_ = CType(results(63), System.Nullable(Of zDispInternal_Type))
            zDispInternal_Specified = CType(results(64), Boolean)
            zValidPersalNumber = CType(results(65), String)
            Temp_Postal_Address = CType(results(66), String)
            Temp_Postal_Code = CType(results(67), String)
            Character_Field = CType(results(68), String)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginGet(ByVal Entry_ID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("Get", New Object() {Entry_ID}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndGet( _
                    ByVal asyncResult As System.IAsyncResult, _
                    ByRef Entry_ID As String, _
                    ByRef Create_Date As Date, _
                    ByRef Create_DateSpecified As Boolean, _
                    ByRef Department_Name As String, _
                    ByRef Last_Modified_By As String, _
                    ByRef Modified_Date As Date, _
                    ByRef Modified_DateSpecified As Boolean, _
                    ByRef Record_Status As Record_StatusType, _
                    ByRef Persal_Number As String, _
                    ByRef Status_History As String, _
                    ByRef First_Name As String, _
                    ByRef Last_Name As String, _
                    ByRef Telephone As String, _
                    ByRef Fax_Number As String, _
                    ByRef EMail As String, _
                    ByRef Title As String, _
                    ByRef Department_Type As String, _
                    ByRef VULINDLELA_Role As String, _
                    ByRef Initial As String, _
                    ByRef Comments As String, _
                    ByRef Nickname As String, _
                    ByRef Remote_Access_Availability As Remote_Access_AvailabilityType, _
                    ByRef LOGIS_Store_Number As String, _
                    ByRef Rank As String, _
                    ByRef LOGIS_Role As String, _
                    ByRef zDispPersalNo As Integer, _
                    ByRef zDispPersalNoSpecified As Boolean, _
                    ByRef zDispChangeStoreNo As String, _
                    ByRef zDispUserResponse As String, _
                    ByRef zDispDefaultDateForNew As Date, _
                    ByRef zDispDefaultDateForNewSpecified As Boolean, _
                    ByRef Postal_Address As String, _
                    ByRef City As String, _
                    ByRef Province As String, _
                    ByRef Postal_Code As String, _
                    ByRef zDispCheckDuplicate As String, _
                    ByRef zDispClose As String, _
                    ByRef zDispCallsOpen As String, _
                    ByRef zDispReAssignCallsOpen As String, _
                    ByRef zDispOldPersalNo As String, _
                    ByRef zDispWrongDept As String, _
                    ByRef BAS_Store_Number As String, _
                    ByRef VULIN_Store_Number As String, _
                    ByRef zDispStoreNo As String, _
                    ByRef zDispSystemGroup As String, _
                    ByRef BAS_Role As String, _
                    ByRef zDispNoStoreNumber As String, _
                    ByRef zDispRole As String, _
                    ByRef Region As String, _
                    ByRef Cellphone As String, _
                    ByRef Extension As String, _
                    ByRef Billing_Code As String, _
                    ByRef PERSAL_Store_Number As String, _
                    ByRef FMS_Store_Number As String, _
                    ByRef PERSAL_Role As String, _
                    ByRef FMS_Role As String, _
                    ByRef zDispReAssignPersalNo As String, _
                    ByRef Database As String, _
                    ByRef User_Code As String, _
                    ByRef PreFMS As String, _
                    ByRef PreEFT As String, _
                    ByRef PrePER As String, _
                    ByRef zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByRef zDispInternal_Specified As Boolean, _
                    ByRef zValidPersalNumber As String, _
                    ByRef Temp_Postal_Address As String, _
                    ByRef Temp_Postal_Code As String, _
                    ByRef Character_Field As String) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Entry_ID = CType(results(1), String)
            Create_Date = CType(results(2), Date)
            Create_DateSpecified = CType(results(3), Boolean)
            Department_Name = CType(results(4), String)
            Last_Modified_By = CType(results(5), String)
            Modified_Date = CType(results(6), Date)
            Modified_DateSpecified = CType(results(7), Boolean)
            Record_Status = CType(results(8), Record_StatusType)
            Persal_Number = CType(results(9), String)
            Status_History = CType(results(10), String)
            First_Name = CType(results(11), String)
            Last_Name = CType(results(12), String)
            Telephone = CType(results(13), String)
            Fax_Number = CType(results(14), String)
            EMail = CType(results(15), String)
            Title = CType(results(16), String)
            Department_Type = CType(results(17), String)
            VULINDLELA_Role = CType(results(18), String)
            Initial = CType(results(19), String)
            Comments = CType(results(20), String)
            Nickname = CType(results(21), String)
            Remote_Access_Availability = CType(results(22), Remote_Access_AvailabilityType)
            LOGIS_Store_Number = CType(results(23), String)
            Rank = CType(results(24), String)
            LOGIS_Role = CType(results(25), String)
            zDispPersalNo = CType(results(26), Integer)
            zDispPersalNoSpecified = CType(results(27), Boolean)
            zDispChangeStoreNo = CType(results(28), String)
            zDispUserResponse = CType(results(29), String)
            zDispDefaultDateForNew = CType(results(30), Date)
            zDispDefaultDateForNewSpecified = CType(results(31), Boolean)
            Postal_Address = CType(results(32), String)
            City = CType(results(33), String)
            Province = CType(results(34), String)
            Postal_Code = CType(results(35), String)
            zDispCheckDuplicate = CType(results(36), String)
            zDispClose = CType(results(37), String)
            zDispCallsOpen = CType(results(38), String)
            zDispReAssignCallsOpen = CType(results(39), String)
            zDispOldPersalNo = CType(results(40), String)
            zDispWrongDept = CType(results(41), String)
            BAS_Store_Number = CType(results(42), String)
            VULIN_Store_Number = CType(results(43), String)
            zDispStoreNo = CType(results(44), String)
            zDispSystemGroup = CType(results(45), String)
            BAS_Role = CType(results(46), String)
            zDispNoStoreNumber = CType(results(47), String)
            zDispRole = CType(results(48), String)
            Region = CType(results(49), String)
            Cellphone = CType(results(50), String)
            Extension = CType(results(51), String)
            Billing_Code = CType(results(52), String)
            PERSAL_Store_Number = CType(results(53), String)
            FMS_Store_Number = CType(results(54), String)
            PERSAL_Role = CType(results(55), String)
            FMS_Role = CType(results(56), String)
            zDispReAssignPersalNo = CType(results(57), String)
            Database = CType(results(58), String)
            User_Code = CType(results(59), String)
            PreFMS = CType(results(60), String)
            PreEFT = CType(results(61), String)
            PrePER = CType(results(62), String)
            zDispInternal_ = CType(results(63), System.Nullable(Of zDispInternal_Type))
            zDispInternal_Specified = CType(results(64), Boolean)
            zValidPersalNumber = CType(results(65), String)
            Temp_Postal_Address = CType(results(66), String)
            Temp_Postal_Code = CType(results(67), String)
            Character_Field = CType(results(68), String)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub GetAsync(ByVal Entry_ID As String)
            Me.GetAsync(Entry_ID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub GetAsync(ByVal Entry_ID As String, ByVal userState As Object)
            If (Me.GetOperationCompleted Is Nothing) Then
                Me.GetOperationCompleted = AddressOf Me.OnGetOperationCompleted
            End If
            Me.InvokeAsync("Get", New Object() {Entry_ID}, Me.GetOperationCompleted, userState)
        End Sub

        Private Sub OnGetOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetCompleted(Me, New GetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticationInfoValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:LOG_DM_Customer_Information_BasicWS__c/Set", RequestNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", ResponseNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub [Set]( _
                    <System.ComponentModel.DefaultValueAttribute("$USER$")> ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByVal Record_Status As System.Nullable(Of Record_StatusType), _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True), System.Xml.Serialization.XmlIgnoreAttribute()> ByVal Record_StatusSpecified As Boolean, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    <System.Xml.Serialization.XmlElementAttribute("E-Mail"), System.ComponentModel.DefaultValueAttribute("None")> ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByVal Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True), System.Xml.Serialization.XmlIgnoreAttribute()> ByVal Remote_Access_AvailabilitySpecified As Boolean, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    <System.Xml.Serialization.XmlElementAttribute("zDispRe-AssignCallsOpen")> ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-FMS")> ByVal PreFMS As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-EFT")> ByVal PreEFT As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-PER")> ByVal PrePER As String, _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True), System.Xml.Serialization.XmlIgnoreAttribute()> ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String, _
                    ByRef Entry_ID As String)
            Dim results() As Object = Me.Invoke("Set", New Object() {Submitter, Department_Name, Record_Status, Record_StatusSpecified, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, Remote_Access_AvailabilitySpecified, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field, Entry_ID})
            Entry_ID = CType(results(0), String)
        End Sub

        '''<remarks/>
        Public Function BeginSet( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As System.Nullable(Of Record_StatusType), _
                    ByVal Record_StatusSpecified As Boolean, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    ByVal Remote_Access_AvailabilitySpecified As Boolean, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String, _
                    ByVal Entry_ID As String, _
                    ByVal callback As System.AsyncCallback, _
                    ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("Set", New Object() {Submitter, Department_Name, Record_Status, Record_StatusSpecified, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, Remote_Access_AvailabilitySpecified, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field, Entry_ID}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndSet(ByVal asyncResult As System.IAsyncResult, ByRef Entry_ID As String)
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Entry_ID = CType(results(0), String)
        End Sub

        '''<remarks/>
        Public Overloads Sub SetAsync( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As System.Nullable(Of Record_StatusType), _
                    ByVal Record_StatusSpecified As Boolean, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    ByVal Remote_Access_AvailabilitySpecified As Boolean, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String, _
                    ByVal Entry_ID As String)
            Me.SetAsync(Submitter, Department_Name, Record_Status, Record_StatusSpecified, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, Remote_Access_AvailabilitySpecified, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field, Entry_ID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub SetAsync( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As System.Nullable(Of Record_StatusType), _
                    ByVal Record_StatusSpecified As Boolean, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    ByVal Remote_Access_AvailabilitySpecified As Boolean, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String, _
                    ByVal Entry_ID As String, _
                    ByVal userState As Object)
            If (Me.SetOperationCompleted Is Nothing) Then
                Me.SetOperationCompleted = AddressOf Me.OnSetOperationCompleted
            End If
            Me.InvokeAsync("Set", New Object() {Submitter, Department_Name, Record_Status, Record_StatusSpecified, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, Remote_Access_AvailabilitySpecified, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field, Entry_ID}, Me.SetOperationCompleted, userState)
        End Sub

        Private Sub OnSetOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetCompleted(Me, New SetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticationInfoValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:LOG_DM_Customer_Information_BasicWS__c/Service", RequestNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", ResponseNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function Service( _
                    <System.ComponentModel.DefaultValueAttribute("$USER$")> ByRef Submitter As String, _
                    ByRef Department_Name As String, _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByRef Record_Status As System.Nullable(Of Record_StatusType), _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True), System.Xml.Serialization.XmlIgnoreAttribute()> ByRef Record_StatusSpecified As Boolean, _
                    ByRef Persal_Number As String, _
                    ByRef First_Name As String, _
                    ByRef Last_Name As String, _
                    ByRef Telephone As String, _
                    ByRef Fax_Number As String, _
                    <System.Xml.Serialization.XmlElementAttribute("E-Mail"), System.ComponentModel.DefaultValueAttribute("None")> ByRef EMail As String, _
                    ByRef Title As String, _
                    ByRef Department_Type As String, _
                    ByRef VULINDLELA_Role As String, _
                    ByRef Initial As String, _
                    ByRef Comments As String, _
                    ByRef Nickname As String, _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByRef Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True), System.Xml.Serialization.XmlIgnoreAttribute()> ByRef Remote_Access_AvailabilitySpecified As Boolean, _
                    ByRef LOGIS_Store_Number As String, _
                    ByRef Rank As String, _
                    ByRef LOGIS_Role As String, _
                    ByRef zDispPersalNo As Integer, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef zDispPersalNoSpecified As Boolean, _
                    ByRef zDispChangeStoreNo As String, _
                    ByRef zDispUserResponse As String, _
                    ByRef zDispDefaultDateForNew As Date, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef zDispDefaultDateForNewSpecified As Boolean, _
                    ByRef Postal_Address As String, _
                    ByRef City As String, _
                    ByRef Province As String, _
                    ByRef Postal_Code As String, _
                    ByRef zDispCheckDuplicate As String, _
                    ByRef zDispClose As String, _
                    ByRef zDispCallsOpen As String, _
                    <System.Xml.Serialization.XmlElementAttribute("zDispRe-AssignCallsOpen")> ByRef zDispReAssignCallsOpen As String, _
                    ByRef zDispOldPersalNo As String, _
                    ByRef zDispWrongDept As String, _
                    ByRef BAS_Store_Number As String, _
                    ByRef VULIN_Store_Number As String, _
                    ByRef zDispStoreNo As String, _
                    ByRef zDispSystemGroup As String, _
                    ByRef BAS_Role As String, _
                    ByRef zDispNoStoreNumber As String, _
                    ByRef zDispRole As String, _
                    ByRef Region As String, _
                    ByRef Cellphone As String, _
                    ByRef Extension As String, _
                    ByRef Billing_Code As String, _
                    ByRef PERSAL_Store_Number As String, _
                    ByRef FMS_Store_Number As String, _
                    ByRef PERSAL_Role As String, _
                    ByRef FMS_Role As String, _
                    ByRef zDispReAssignPersalNo As String, _
                    ByRef Database As String, _
                    ByRef User_Code As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-FMS")> ByRef PreFMS As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-EFT")> ByRef PreEFT As String, _
                    <System.Xml.Serialization.XmlElementAttribute("Pre-PER")> ByRef PrePER As String, _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByRef zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True), System.Xml.Serialization.XmlIgnoreAttribute()> ByRef zDispInternal_Specified As Boolean, _
                    ByRef zValidPersalNumber As String, _
                    ByRef Temp_Postal_Address As String, _
                    ByRef Temp_Postal_Code As String, _
                    ByRef Character_Field As String, _
                    ByRef Create_Date As Date, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef Create_DateSpecified As Boolean, _
                    ByRef Last_Modified_By As String, _
                    ByRef Modified_Date As Date, _
                    <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef Modified_DateSpecified As Boolean, _
                    ByRef Status_History As String) As <System.Xml.Serialization.XmlElementAttribute("Entry_ID")> String
            Dim results() As Object = Me.Invoke("Service", New Object() {Submitter, Department_Name, Record_Status, Record_StatusSpecified, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, Remote_Access_AvailabilitySpecified, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field})
            Submitter = CType(results(1), String)
            Department_Name = CType(results(2), String)
            Record_Status = CType(results(3), System.Nullable(Of Record_StatusType))
            Record_StatusSpecified = CType(results(4), Boolean)
            Persal_Number = CType(results(5), String)
            First_Name = CType(results(6), String)
            Last_Name = CType(results(7), String)
            Telephone = CType(results(8), String)
            Fax_Number = CType(results(9), String)
            EMail = CType(results(10), String)
            Title = CType(results(11), String)
            Department_Type = CType(results(12), String)
            VULINDLELA_Role = CType(results(13), String)
            Initial = CType(results(14), String)
            Comments = CType(results(15), String)
            Nickname = CType(results(16), String)
            Remote_Access_Availability = CType(results(17), System.Nullable(Of Remote_Access_AvailabilityType))
            Remote_Access_AvailabilitySpecified = CType(results(18), Boolean)
            LOGIS_Store_Number = CType(results(19), String)
            Rank = CType(results(20), String)
            LOGIS_Role = CType(results(21), String)
            zDispPersalNo = CType(results(22), Integer)
            zDispPersalNoSpecified = CType(results(23), Boolean)
            zDispChangeStoreNo = CType(results(24), String)
            zDispUserResponse = CType(results(25), String)
            zDispDefaultDateForNew = CType(results(26), Date)
            zDispDefaultDateForNewSpecified = CType(results(27), Boolean)
            Postal_Address = CType(results(28), String)
            City = CType(results(29), String)
            Province = CType(results(30), String)
            Postal_Code = CType(results(31), String)
            zDispCheckDuplicate = CType(results(32), String)
            zDispClose = CType(results(33), String)
            zDispCallsOpen = CType(results(34), String)
            zDispReAssignCallsOpen = CType(results(35), String)
            zDispOldPersalNo = CType(results(36), String)
            zDispWrongDept = CType(results(37), String)
            BAS_Store_Number = CType(results(38), String)
            VULIN_Store_Number = CType(results(39), String)
            zDispStoreNo = CType(results(40), String)
            zDispSystemGroup = CType(results(41), String)
            BAS_Role = CType(results(42), String)
            zDispNoStoreNumber = CType(results(43), String)
            zDispRole = CType(results(44), String)
            Region = CType(results(45), String)
            Cellphone = CType(results(46), String)
            Extension = CType(results(47), String)
            Billing_Code = CType(results(48), String)
            PERSAL_Store_Number = CType(results(49), String)
            FMS_Store_Number = CType(results(50), String)
            PERSAL_Role = CType(results(51), String)
            FMS_Role = CType(results(52), String)
            zDispReAssignPersalNo = CType(results(53), String)
            Database = CType(results(54), String)
            User_Code = CType(results(55), String)
            PreFMS = CType(results(56), String)
            PreEFT = CType(results(57), String)
            PrePER = CType(results(58), String)
            zDispInternal_ = CType(results(59), System.Nullable(Of zDispInternal_Type))
            zDispInternal_Specified = CType(results(60), Boolean)
            zValidPersalNumber = CType(results(61), String)
            Temp_Postal_Address = CType(results(62), String)
            Temp_Postal_Code = CType(results(63), String)
            Character_Field = CType(results(64), String)
            Create_Date = CType(results(65), Date)
            Create_DateSpecified = CType(results(66), Boolean)
            Last_Modified_By = CType(results(67), String)
            Modified_Date = CType(results(68), Date)
            Modified_DateSpecified = CType(results(69), Boolean)
            Status_History = CType(results(70), String)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginService( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As System.Nullable(Of Record_StatusType), _
                    ByVal Record_StatusSpecified As Boolean, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    ByVal Remote_Access_AvailabilitySpecified As Boolean, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String, _
                    ByVal callback As System.AsyncCallback, _
                    ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("Service", New Object() {Submitter, Department_Name, Record_Status, Record_StatusSpecified, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, Remote_Access_AvailabilitySpecified, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndService( _
                    ByVal asyncResult As System.IAsyncResult, _
                    ByRef Submitter As String, _
                    ByRef Department_Name As String, _
                    ByRef Record_Status As System.Nullable(Of Record_StatusType), _
                    ByRef Record_StatusSpecified As Boolean, _
                    ByRef Persal_Number As String, _
                    ByRef First_Name As String, _
                    ByRef Last_Name As String, _
                    ByRef Telephone As String, _
                    ByRef Fax_Number As String, _
                    ByRef EMail As String, _
                    ByRef Title As String, _
                    ByRef Department_Type As String, _
                    ByRef VULINDLELA_Role As String, _
                    ByRef Initial As String, _
                    ByRef Comments As String, _
                    ByRef Nickname As String, _
                    ByRef Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    ByRef Remote_Access_AvailabilitySpecified As Boolean, _
                    ByRef LOGIS_Store_Number As String, _
                    ByRef Rank As String, _
                    ByRef LOGIS_Role As String, _
                    ByRef zDispPersalNo As Integer, _
                    ByRef zDispPersalNoSpecified As Boolean, _
                    ByRef zDispChangeStoreNo As String, _
                    ByRef zDispUserResponse As String, _
                    ByRef zDispDefaultDateForNew As Date, _
                    ByRef zDispDefaultDateForNewSpecified As Boolean, _
                    ByRef Postal_Address As String, _
                    ByRef City As String, _
                    ByRef Province As String, _
                    ByRef Postal_Code As String, _
                    ByRef zDispCheckDuplicate As String, _
                    ByRef zDispClose As String, _
                    ByRef zDispCallsOpen As String, _
                    ByRef zDispReAssignCallsOpen As String, _
                    ByRef zDispOldPersalNo As String, _
                    ByRef zDispWrongDept As String, _
                    ByRef BAS_Store_Number As String, _
                    ByRef VULIN_Store_Number As String, _
                    ByRef zDispStoreNo As String, _
                    ByRef zDispSystemGroup As String, _
                    ByRef BAS_Role As String, _
                    ByRef zDispNoStoreNumber As String, _
                    ByRef zDispRole As String, _
                    ByRef Region As String, _
                    ByRef Cellphone As String, _
                    ByRef Extension As String, _
                    ByRef Billing_Code As String, _
                    ByRef PERSAL_Store_Number As String, _
                    ByRef FMS_Store_Number As String, _
                    ByRef PERSAL_Role As String, _
                    ByRef FMS_Role As String, _
                    ByRef zDispReAssignPersalNo As String, _
                    ByRef Database As String, _
                    ByRef User_Code As String, _
                    ByRef PreFMS As String, _
                    ByRef PreEFT As String, _
                    ByRef PrePER As String, _
                    ByRef zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByRef zDispInternal_Specified As Boolean, _
                    ByRef zValidPersalNumber As String, _
                    ByRef Temp_Postal_Address As String, _
                    ByRef Temp_Postal_Code As String, _
                    ByRef Character_Field As String, _
                    ByRef Create_Date As Date, _
                    ByRef Create_DateSpecified As Boolean, _
                    ByRef Last_Modified_By As String, _
                    ByRef Modified_Date As Date, _
                    ByRef Modified_DateSpecified As Boolean, _
                    ByRef Status_History As String) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Submitter = CType(results(1), String)
            Department_Name = CType(results(2), String)
            Record_Status = CType(results(3), System.Nullable(Of Record_StatusType))
            Record_StatusSpecified = CType(results(4), Boolean)
            Persal_Number = CType(results(5), String)
            First_Name = CType(results(6), String)
            Last_Name = CType(results(7), String)
            Telephone = CType(results(8), String)
            Fax_Number = CType(results(9), String)
            EMail = CType(results(10), String)
            Title = CType(results(11), String)
            Department_Type = CType(results(12), String)
            VULINDLELA_Role = CType(results(13), String)
            Initial = CType(results(14), String)
            Comments = CType(results(15), String)
            Nickname = CType(results(16), String)
            Remote_Access_Availability = CType(results(17), System.Nullable(Of Remote_Access_AvailabilityType))
            Remote_Access_AvailabilitySpecified = CType(results(18), Boolean)
            LOGIS_Store_Number = CType(results(19), String)
            Rank = CType(results(20), String)
            LOGIS_Role = CType(results(21), String)
            zDispPersalNo = CType(results(22), Integer)
            zDispPersalNoSpecified = CType(results(23), Boolean)
            zDispChangeStoreNo = CType(results(24), String)
            zDispUserResponse = CType(results(25), String)
            zDispDefaultDateForNew = CType(results(26), Date)
            zDispDefaultDateForNewSpecified = CType(results(27), Boolean)
            Postal_Address = CType(results(28), String)
            City = CType(results(29), String)
            Province = CType(results(30), String)
            Postal_Code = CType(results(31), String)
            zDispCheckDuplicate = CType(results(32), String)
            zDispClose = CType(results(33), String)
            zDispCallsOpen = CType(results(34), String)
            zDispReAssignCallsOpen = CType(results(35), String)
            zDispOldPersalNo = CType(results(36), String)
            zDispWrongDept = CType(results(37), String)
            BAS_Store_Number = CType(results(38), String)
            VULIN_Store_Number = CType(results(39), String)
            zDispStoreNo = CType(results(40), String)
            zDispSystemGroup = CType(results(41), String)
            BAS_Role = CType(results(42), String)
            zDispNoStoreNumber = CType(results(43), String)
            zDispRole = CType(results(44), String)
            Region = CType(results(45), String)
            Cellphone = CType(results(46), String)
            Extension = CType(results(47), String)
            Billing_Code = CType(results(48), String)
            PERSAL_Store_Number = CType(results(49), String)
            FMS_Store_Number = CType(results(50), String)
            PERSAL_Role = CType(results(51), String)
            FMS_Role = CType(results(52), String)
            zDispReAssignPersalNo = CType(results(53), String)
            Database = CType(results(54), String)
            User_Code = CType(results(55), String)
            PreFMS = CType(results(56), String)
            PreEFT = CType(results(57), String)
            PrePER = CType(results(58), String)
            zDispInternal_ = CType(results(59), System.Nullable(Of zDispInternal_Type))
            zDispInternal_Specified = CType(results(60), Boolean)
            zValidPersalNumber = CType(results(61), String)
            Temp_Postal_Address = CType(results(62), String)
            Temp_Postal_Code = CType(results(63), String)
            Character_Field = CType(results(64), String)
            Create_Date = CType(results(65), Date)
            Create_DateSpecified = CType(results(66), Boolean)
            Last_Modified_By = CType(results(67), String)
            Modified_Date = CType(results(68), Date)
            Modified_DateSpecified = CType(results(69), Boolean)
            Status_History = CType(results(70), String)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub ServiceAsync( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As System.Nullable(Of Record_StatusType), _
                    ByVal Record_StatusSpecified As Boolean, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    ByVal Remote_Access_AvailabilitySpecified As Boolean, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String)
            Me.ServiceAsync(Submitter, Department_Name, Record_Status, Record_StatusSpecified, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, Remote_Access_AvailabilitySpecified, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ServiceAsync( _
                    ByVal Submitter As String, _
                    ByVal Department_Name As String, _
                    ByVal Record_Status As System.Nullable(Of Record_StatusType), _
                    ByVal Record_StatusSpecified As Boolean, _
                    ByVal Persal_Number As String, _
                    ByVal First_Name As String, _
                    ByVal Last_Name As String, _
                    ByVal Telephone As String, _
                    ByVal Fax_Number As String, _
                    ByVal EMail As String, _
                    ByVal Title As String, _
                    ByVal Department_Type As String, _
                    ByVal VULINDLELA_Role As String, _
                    ByVal Initial As String, _
                    ByVal Comments As String, _
                    ByVal Nickname As String, _
                    ByVal Remote_Access_Availability As System.Nullable(Of Remote_Access_AvailabilityType), _
                    ByVal Remote_Access_AvailabilitySpecified As Boolean, _
                    ByVal LOGIS_Store_Number As String, _
                    ByVal Rank As String, _
                    ByVal LOGIS_Role As String, _
                    ByVal zDispPersalNo As Integer, _
                    ByVal zDispPersalNoSpecified As Boolean, _
                    ByVal zDispChangeStoreNo As String, _
                    ByVal zDispUserResponse As String, _
                    ByVal zDispDefaultDateForNew As Date, _
                    ByVal zDispDefaultDateForNewSpecified As Boolean, _
                    ByVal Postal_Address As String, _
                    ByVal City As String, _
                    ByVal Province As String, _
                    ByVal Postal_Code As String, _
                    ByVal zDispCheckDuplicate As String, _
                    ByVal zDispClose As String, _
                    ByVal zDispCallsOpen As String, _
                    ByVal zDispReAssignCallsOpen As String, _
                    ByVal zDispOldPersalNo As String, _
                    ByVal zDispWrongDept As String, _
                    ByVal BAS_Store_Number As String, _
                    ByVal VULIN_Store_Number As String, _
                    ByVal zDispStoreNo As String, _
                    ByVal zDispSystemGroup As String, _
                    ByVal BAS_Role As String, _
                    ByVal zDispNoStoreNumber As String, _
                    ByVal zDispRole As String, _
                    ByVal Region As String, _
                    ByVal Cellphone As String, _
                    ByVal Extension As String, _
                    ByVal Billing_Code As String, _
                    ByVal PERSAL_Store_Number As String, _
                    ByVal FMS_Store_Number As String, _
                    ByVal PERSAL_Role As String, _
                    ByVal FMS_Role As String, _
                    ByVal zDispReAssignPersalNo As String, _
                    ByVal Database As String, _
                    ByVal User_Code As String, _
                    ByVal PreFMS As String, _
                    ByVal PreEFT As String, _
                    ByVal PrePER As String, _
                    ByVal zDispInternal_ As System.Nullable(Of zDispInternal_Type), _
                    ByVal zDispInternal_Specified As Boolean, _
                    ByVal zValidPersalNumber As String, _
                    ByVal Temp_Postal_Address As String, _
                    ByVal Temp_Postal_Code As String, _
                    ByVal Character_Field As String, _
                    ByVal userState As Object)
            If (Me.ServiceOperationCompleted Is Nothing) Then
                Me.ServiceOperationCompleted = AddressOf Me.OnServiceOperationCompleted
            End If
            Me.InvokeAsync("Service", New Object() {Submitter, Department_Name, Record_Status, Record_StatusSpecified, Persal_Number, First_Name, Last_Name, Telephone, Fax_Number, EMail, Title, Department_Type, VULINDLELA_Role, Initial, Comments, Nickname, Remote_Access_Availability, Remote_Access_AvailabilitySpecified, LOGIS_Store_Number, Rank, LOGIS_Role, zDispPersalNo, zDispPersalNoSpecified, zDispChangeStoreNo, zDispUserResponse, zDispDefaultDateForNew, zDispDefaultDateForNewSpecified, Postal_Address, City, Province, Postal_Code, zDispCheckDuplicate, zDispClose, zDispCallsOpen, zDispReAssignCallsOpen, zDispOldPersalNo, zDispWrongDept, BAS_Store_Number, VULIN_Store_Number, zDispStoreNo, zDispSystemGroup, BAS_Role, zDispNoStoreNumber, zDispRole, Region, Cellphone, Extension, Billing_Code, PERSAL_Store_Number, FMS_Store_Number, PERSAL_Role, FMS_Role, zDispReAssignPersalNo, Database, User_Code, PreFMS, PreEFT, PrePER, zDispInternal_, zDispInternal_Specified, zValidPersalNumber, Temp_Postal_Address, Temp_Postal_Code, Character_Field}, Me.ServiceOperationCompleted, userState)
        End Sub

        Private Sub OnServiceOperationCompleted(ByVal arg As Object)
            If (Not (Me.ServiceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ServiceCompleted(Me, New ServiceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticationInfoValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:LOG_DM_Customer_Information_BasicWS__c/GetList", RequestNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", ResponseNamespace:="urn:LOG_DM_Customer_Information_BasicWS__c", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetList(ByVal Qualification As String, ByVal startRecord As String, ByVal maxLimit As String) As <System.Xml.Serialization.XmlElementAttribute("getListValues")> OutputMapping5GetListValues()
            Dim results() As Object = Me.Invoke("GetList", New Object() {Qualification, startRecord, maxLimit})
            Return CType(results(0), OutputMapping5GetListValues())
        End Function

        '''<remarks/>
        Public Function BeginGetList(ByVal Qualification As String, ByVal startRecord As String, ByVal maxLimit As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetList", New Object() {Qualification, startRecord, maxLimit}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndGetList(ByVal asyncResult As System.IAsyncResult) As OutputMapping5GetListValues()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), OutputMapping5GetListValues())
        End Function

        '''<remarks/>
        Public Overloads Sub GetListAsync(ByVal Qualification As String, ByVal startRecord As String, ByVal maxLimit As String)
            Me.GetListAsync(Qualification, startRecord, maxLimit, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub GetListAsync(ByVal Qualification As String, ByVal startRecord As String, ByVal maxLimit As String, ByVal userState As Object)
            If (Me.GetListOperationCompleted Is Nothing) Then
                Me.GetListOperationCompleted = AddressOf Me.OnGetListOperationCompleted
            End If
            Me.InvokeAsync("GetList", New Object() {Qualification, startRecord, maxLimit}, Me.GetListOperationCompleted, userState)
        End Sub

        Private Sub OnGetListOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetListCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetListCompleted(Me, New GetListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:LOG_DM_Customer_Information_BasicWS__c"), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="urn:LOG_DM_Customer_Information_BasicWS__c", IsNullable:=False)> _
    Partial Public Class AuthenticationInfo
        Inherits System.Web.Services.Protocols.SoapHeader

        Private userNameField As String

        Private passwordField As String

        Private authenticationField As String

        Private localeField As String

        Private timeZoneField As String

        '''<remarks/>
        Public Property userName() As String
            Get
                Return Me.userNameField
            End Get
            Set(ByVal value As String)
                Me.userNameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property password() As String
            Get
                Return Me.passwordField
            End Get
            Set(ByVal value As String)
                Me.passwordField = value
            End Set
        End Property

        '''<remarks/>
        Public Property authentication() As String
            Get
                Return Me.authenticationField
            End Get
            Set(ByVal value As String)
                Me.authenticationField = value
            End Set
        End Property

        '''<remarks/>
        Public Property locale() As String
            Get
                Return Me.localeField
            End Get
            Set(ByVal value As String)
                Me.localeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property timeZone() As String
            Get
                Return Me.timeZoneField
            End Get
            Set(ByVal value As String)
                Me.timeZoneField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:LOG_DM_Customer_Information_BasicWS__c")> _
    Public Enum Record_StatusType

        '''<remarks/>
        Incomplete

        '''<remarks/>
        Complete
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:LOG_DM_Customer_Information_BasicWS__c")> _
    Public Enum Remote_Access_AvailabilityType

        '''<remarks/>
        Active

        '''<remarks/>
        Inactive
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:LOG_DM_Customer_Information_BasicWS__c")> _
    Public Enum zDispInternal_Type

        '''<remarks/>
        Yes

        '''<remarks/>
        No
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="urn:LOG_DM_Customer_Information_BasicWS__c")> _
    Partial Public Class OutputMapping5GetListValues

        Private entry_IDField As String

        Private submitterField As String

        Private create_DateField As Date

        Private create_DateFieldSpecified As Boolean

        Private department_NameField As String

        Private last_Modified_ByField As String

        Private modified_DateField As Date

        Private modified_DateFieldSpecified As Boolean

        Private record_StatusField As Record_StatusType

        Private persal_NumberField As String

        Private status_HistoryField As String

        Private first_NameField As String

        Private last_NameField As String

        Private telephoneField As String

        Private fax_NumberField As String

        Private eMailField As String

        Private titleField As String

        Private department_TypeField As String

        Private vULINDLELA_RoleField As String

        Private initialField As String

        Private commentsField As String

        Private nicknameField As String

        Private remote_Access_AvailabilityField As System.Nullable(Of Remote_Access_AvailabilityType)

        Private lOGIS_Store_NumberField As String

        Private rankField As String

        Private lOGIS_RoleField As String

        Private zDispPersalNoField As Integer

        Private zDispPersalNoFieldSpecified As Boolean

        Private zDispChangeStoreNoField As String

        Private zDispUserResponseField As String

        Private zDispDefaultDateForNewField As Date

        Private zDispDefaultDateForNewFieldSpecified As Boolean

        Private postal_AddressField As String

        Private cityField As String

        Private provinceField As String

        Private postal_CodeField As String

        Private zDispCheckDuplicateField As String

        Private zDispCloseField As String

        Private zDispCallsOpenField As String

        Private zDispReAssignCallsOpenField As String

        Private zDispOldPersalNoField As String

        Private zDispWrongDeptField As String

        Private bAS_Store_NumberField As String

        Private vULIN_Store_NumberField As String

        Private zDispStoreNoField As String

        Private zDispSystemGroupField As String

        Private bAS_RoleField As String

        Private zDispNoStoreNumberField As String

        Private zDispRoleField As String

        Private regionField As String

        Private cellphoneField As String

        Private extensionField As String

        Private billing_CodeField As String

        Private pERSAL_Store_NumberField As String

        Private fMS_Store_NumberField As String

        Private pERSAL_RoleField As String

        Private fMS_RoleField As String

        Private zDispReAssignPersalNoField As String

        Private databaseField As String

        Private user_CodeField As String

        Private preFMSField As String

        Private preEFTField As String

        Private prePERField As String

        Private zDispInternal_Field As System.Nullable(Of zDispInternal_Type)

        Private zDispInternal_FieldSpecified As Boolean

        Private zValidPersalNumberField As String

        Private temp_Postal_AddressField As String

        Private temp_Postal_CodeField As String

        Private character_FieldField As String

        Public Sub New()
            MyBase.New()
            Me.eMailField = "None"
        End Sub

        '''<remarks/>
        Public Property Entry_ID() As String
            Get
                Return Me.entry_IDField
            End Get
            Set(ByVal value As String)
                Me.entry_IDField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Submitter() As String
            Get
                Return Me.submitterField
            End Get
            Set(ByVal value As String)
                Me.submitterField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Create_Date() As Date
            Get
                Return Me.create_DateField
            End Get
            Set(ByVal value As Date)
                Me.create_DateField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property Create_DateSpecified() As Boolean
            Get
                Return Me.create_DateFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.create_DateFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property Department_Name() As String
            Get
                Return Me.department_NameField
            End Get
            Set(ByVal value As String)
                Me.department_NameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Last_Modified_By() As String
            Get
                Return Me.last_Modified_ByField
            End Get
            Set(ByVal value As String)
                Me.last_Modified_ByField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Modified_Date() As Date
            Get
                Return Me.modified_DateField
            End Get
            Set(ByVal value As Date)
                Me.modified_DateField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property Modified_DateSpecified() As Boolean
            Get
                Return Me.modified_DateFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.modified_DateFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property Record_Status() As Record_StatusType
            Get
                Return Me.record_StatusField
            End Get
            Set(ByVal value As Record_StatusType)
                Me.record_StatusField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Persal_Number() As String
            Get
                Return Me.persal_NumberField
            End Get
            Set(ByVal value As String)
                Me.persal_NumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Status_History() As String
            Get
                Return Me.status_HistoryField
            End Get
            Set(ByVal value As String)
                Me.status_HistoryField = value
            End Set
        End Property

        '''<remarks/>
        Public Property First_Name() As String
            Get
                Return Me.first_NameField
            End Get
            Set(ByVal value As String)
                Me.first_NameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Last_Name() As String
            Get
                Return Me.last_NameField
            End Get
            Set(ByVal value As String)
                Me.last_NameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set(ByVal value As String)
                Me.telephoneField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Fax_Number() As String
            Get
                Return Me.fax_NumberField
            End Get
            Set(ByVal value As String)
                Me.fax_NumberField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("E-Mail"), _
         System.ComponentModel.DefaultValueAttribute("None")> _
        Public Property EMail() As String
            Get
                Return Me.eMailField
            End Get
            Set(ByVal value As String)
                Me.eMailField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Title() As String
            Get
                Return Me.titleField
            End Get
            Set(ByVal value As String)
                Me.titleField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Department_Type() As String
            Get
                Return Me.department_TypeField
            End Get
            Set(ByVal value As String)
                Me.department_TypeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property VULINDLELA_Role() As String
            Get
                Return Me.vULINDLELA_RoleField
            End Get
            Set(ByVal value As String)
                Me.vULINDLELA_RoleField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Initial() As String
            Get
                Return Me.initialField
            End Get
            Set(ByVal value As String)
                Me.initialField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Comments() As String
            Get
                Return Me.commentsField
            End Get
            Set(ByVal value As String)
                Me.commentsField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Nickname() As String
            Get
                Return Me.nicknameField
            End Get
            Set(ByVal value As String)
                Me.nicknameField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> _
        Public Property Remote_Access_Availability() As System.Nullable(Of Remote_Access_AvailabilityType)
            Get
                Return Me.remote_Access_AvailabilityField
            End Get
            Set(ByVal value As System.Nullable(Of Remote_Access_AvailabilityType))
                Me.remote_Access_AvailabilityField = value
            End Set
        End Property

        '''<remarks/>
        Public Property LOGIS_Store_Number() As String
            Get
                Return Me.lOGIS_Store_NumberField
            End Get
            Set(ByVal value As String)
                Me.lOGIS_Store_NumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Rank() As String
            Get
                Return Me.rankField
            End Get
            Set(ByVal value As String)
                Me.rankField = value
            End Set
        End Property

        '''<remarks/>
        Public Property LOGIS_Role() As String
            Get
                Return Me.lOGIS_RoleField
            End Get
            Set(ByVal value As String)
                Me.lOGIS_RoleField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispPersalNo() As Integer
            Get
                Return Me.zDispPersalNoField
            End Get
            Set(ByVal value As Integer)
                Me.zDispPersalNoField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property zDispPersalNoSpecified() As Boolean
            Get
                Return Me.zDispPersalNoFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.zDispPersalNoFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispChangeStoreNo() As String
            Get
                Return Me.zDispChangeStoreNoField
            End Get
            Set(ByVal value As String)
                Me.zDispChangeStoreNoField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispUserResponse() As String
            Get
                Return Me.zDispUserResponseField
            End Get
            Set(ByVal value As String)
                Me.zDispUserResponseField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispDefaultDateForNew() As Date
            Get
                Return Me.zDispDefaultDateForNewField
            End Get
            Set(ByVal value As Date)
                Me.zDispDefaultDateForNewField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property zDispDefaultDateForNewSpecified() As Boolean
            Get
                Return Me.zDispDefaultDateForNewFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.zDispDefaultDateForNewFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property Postal_Address() As String
            Get
                Return Me.postal_AddressField
            End Get
            Set(ByVal value As String)
                Me.postal_AddressField = value
            End Set
        End Property

        '''<remarks/>
        Public Property City() As String
            Get
                Return Me.cityField
            End Get
            Set(ByVal value As String)
                Me.cityField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Province() As String
            Get
                Return Me.provinceField
            End Get
            Set(ByVal value As String)
                Me.provinceField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Postal_Code() As String
            Get
                Return Me.postal_CodeField
            End Get
            Set(ByVal value As String)
                Me.postal_CodeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispCheckDuplicate() As String
            Get
                Return Me.zDispCheckDuplicateField
            End Get
            Set(ByVal value As String)
                Me.zDispCheckDuplicateField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispClose() As String
            Get
                Return Me.zDispCloseField
            End Get
            Set(ByVal value As String)
                Me.zDispCloseField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispCallsOpen() As String
            Get
                Return Me.zDispCallsOpenField
            End Get
            Set(ByVal value As String)
                Me.zDispCallsOpenField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("zDispRe-AssignCallsOpen")> _
        Public Property zDispReAssignCallsOpen() As String
            Get
                Return Me.zDispReAssignCallsOpenField
            End Get
            Set(ByVal value As String)
                Me.zDispReAssignCallsOpenField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispOldPersalNo() As String
            Get
                Return Me.zDispOldPersalNoField
            End Get
            Set(ByVal value As String)
                Me.zDispOldPersalNoField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispWrongDept() As String
            Get
                Return Me.zDispWrongDeptField
            End Get
            Set(ByVal value As String)
                Me.zDispWrongDeptField = value
            End Set
        End Property

        '''<remarks/>
        Public Property BAS_Store_Number() As String
            Get
                Return Me.bAS_Store_NumberField
            End Get
            Set(ByVal value As String)
                Me.bAS_Store_NumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property VULIN_Store_Number() As String
            Get
                Return Me.vULIN_Store_NumberField
            End Get
            Set(ByVal value As String)
                Me.vULIN_Store_NumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispStoreNo() As String
            Get
                Return Me.zDispStoreNoField
            End Get
            Set(ByVal value As String)
                Me.zDispStoreNoField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispSystemGroup() As String
            Get
                Return Me.zDispSystemGroupField
            End Get
            Set(ByVal value As String)
                Me.zDispSystemGroupField = value
            End Set
        End Property

        '''<remarks/>
        Public Property BAS_Role() As String
            Get
                Return Me.bAS_RoleField
            End Get
            Set(ByVal value As String)
                Me.bAS_RoleField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispNoStoreNumber() As String
            Get
                Return Me.zDispNoStoreNumberField
            End Get
            Set(ByVal value As String)
                Me.zDispNoStoreNumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispRole() As String
            Get
                Return Me.zDispRoleField
            End Get
            Set(ByVal value As String)
                Me.zDispRoleField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Region() As String
            Get
                Return Me.regionField
            End Get
            Set(ByVal value As String)
                Me.regionField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Cellphone() As String
            Get
                Return Me.cellphoneField
            End Get
            Set(ByVal value As String)
                Me.cellphoneField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Extension() As String
            Get
                Return Me.extensionField
            End Get
            Set(ByVal value As String)
                Me.extensionField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Billing_Code() As String
            Get
                Return Me.billing_CodeField
            End Get
            Set(ByVal value As String)
                Me.billing_CodeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property PERSAL_Store_Number() As String
            Get
                Return Me.pERSAL_Store_NumberField
            End Get
            Set(ByVal value As String)
                Me.pERSAL_Store_NumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property FMS_Store_Number() As String
            Get
                Return Me.fMS_Store_NumberField
            End Get
            Set(ByVal value As String)
                Me.fMS_Store_NumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property PERSAL_Role() As String
            Get
                Return Me.pERSAL_RoleField
            End Get
            Set(ByVal value As String)
                Me.pERSAL_RoleField = value
            End Set
        End Property

        '''<remarks/>
        Public Property FMS_Role() As String
            Get
                Return Me.fMS_RoleField
            End Get
            Set(ByVal value As String)
                Me.fMS_RoleField = value
            End Set
        End Property

        '''<remarks/>
        Public Property zDispReAssignPersalNo() As String
            Get
                Return Me.zDispReAssignPersalNoField
            End Get
            Set(ByVal value As String)
                Me.zDispReAssignPersalNoField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Database() As String
            Get
                Return Me.databaseField
            End Get
            Set(ByVal value As String)
                Me.databaseField = value
            End Set
        End Property

        '''<remarks/>
        Public Property User_Code() As String
            Get
                Return Me.user_CodeField
            End Get
            Set(ByVal value As String)
                Me.user_CodeField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("Pre-FMS")> _
        Public Property PreFMS() As String
            Get
                Return Me.preFMSField
            End Get
            Set(ByVal value As String)
                Me.preFMSField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("Pre-EFT")> _
        Public Property PreEFT() As String
            Get
                Return Me.preEFTField
            End Get
            Set(ByVal value As String)
                Me.preEFTField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("Pre-PER")> _
        Public Property PrePER() As String
            Get
                Return Me.prePERField
            End Get
            Set(ByVal value As String)
                Me.prePERField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> _
        Public Property zDispInternal_() As System.Nullable(Of zDispInternal_Type)
            Get
                Return Me.zDispInternal_Field
            End Get
            Set(ByVal value As System.Nullable(Of zDispInternal_Type))
                Me.zDispInternal_Field = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property zDispInternal_Specified() As Boolean
            Get
                Return Me.zDispInternal_FieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.zDispInternal_FieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property zValidPersalNumber() As String
            Get
                Return Me.zValidPersalNumberField
            End Get
            Set(ByVal value As String)
                Me.zValidPersalNumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Temp_Postal_Address() As String
            Get
                Return Me.temp_Postal_AddressField
            End Get
            Set(ByVal value As String)
                Me.temp_Postal_AddressField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Temp_Postal_Code() As String
            Get
                Return Me.temp_Postal_CodeField
            End Get
            Set(ByVal value As String)
                Me.temp_Postal_CodeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Character_Field() As String
            Get
                Return Me.character_FieldField
            End Get
            Set(ByVal value As String)
                Me.character_FieldField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub CreateCompletedEventHandler(ByVal sender As Object, ByVal e As CreateCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class CreateCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub GetCompletedEventHandler(ByVal sender As Object, ByVal e As GetCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class GetCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Entry_ID() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Create_Date() As Date
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(2), Date)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Create_DateSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(3), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Department_Name() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(4), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Last_Modified_By() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(5), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Modified_Date() As Date
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(6), Date)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Modified_DateSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(7), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Record_Status() As Record_StatusType
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(8), Record_StatusType)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Persal_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(9), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Status_History() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(10), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property First_Name() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(11), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Last_Name() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(12), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Telephone() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(13), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Fax_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(14), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property EMail() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(15), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Title() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(16), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Department_Type() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(17), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property VULINDLELA_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(18), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Initial() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(19), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Comments() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(20), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Nickname() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(21), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Remote_Access_Availability() As Remote_Access_AvailabilityType
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(22), Remote_Access_AvailabilityType)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property LOGIS_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(23), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Rank() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(24), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property LOGIS_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(25), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispPersalNo() As Integer
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(26), Integer)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispPersalNoSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(27), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispChangeStoreNo() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(28), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispUserResponse() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(29), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispDefaultDateForNew() As Date
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(30), Date)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispDefaultDateForNewSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(31), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Postal_Address() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(32), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property City() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(33), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Province() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(34), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Postal_Code() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(35), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispCheckDuplicate() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(36), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispClose() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(37), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispCallsOpen() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(38), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispReAssignCallsOpen() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(39), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispOldPersalNo() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(40), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispWrongDept() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(41), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property BAS_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(42), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property VULIN_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(43), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispStoreNo() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(44), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispSystemGroup() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(45), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property BAS_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(46), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispNoStoreNumber() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(47), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispRole() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(48), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Region() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(49), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Cellphone() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(50), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Extension() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(51), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Billing_Code() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(52), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PERSAL_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(53), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property FMS_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(54), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PERSAL_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(55), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property FMS_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(56), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispReAssignPersalNo() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(57), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Database() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(58), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property User_Code() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(59), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PreFMS() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(60), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PreEFT() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(61), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PrePER() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(62), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispInternal_() As System.Nullable(Of zDispInternal_Type)
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(63), System.Nullable(Of zDispInternal_Type))
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispInternal_Specified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(64), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zValidPersalNumber() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(65), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Temp_Postal_Address() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(66), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Temp_Postal_Code() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(67), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Character_Field() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(68), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub SetCompletedEventHandler(ByVal sender As Object, ByVal e As SetCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class SetCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Entry_ID() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub ServiceCompletedEventHandler(ByVal sender As Object, ByVal e As ServiceCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class ServiceCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Submitter() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Department_Name() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(2), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Record_Status() As System.Nullable(Of Record_StatusType)
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(3), System.Nullable(Of Record_StatusType))
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Record_StatusSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(4), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Persal_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(5), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property First_Name() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(6), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Last_Name() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(7), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Telephone() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(8), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Fax_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(9), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property EMail() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(10), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Title() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(11), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Department_Type() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(12), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property VULINDLELA_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(13), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Initial() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(14), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Comments() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(15), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Nickname() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(16), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Remote_Access_Availability() As System.Nullable(Of Remote_Access_AvailabilityType)
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(17), System.Nullable(Of Remote_Access_AvailabilityType))
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Remote_Access_AvailabilitySpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(18), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property LOGIS_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(19), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Rank() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(20), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property LOGIS_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(21), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispPersalNo() As Integer
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(22), Integer)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispPersalNoSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(23), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispChangeStoreNo() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(24), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispUserResponse() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(25), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispDefaultDateForNew() As Date
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(26), Date)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispDefaultDateForNewSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(27), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Postal_Address() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(28), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property City() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(29), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Province() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(30), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Postal_Code() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(31), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispCheckDuplicate() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(32), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispClose() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(33), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispCallsOpen() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(34), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispReAssignCallsOpen() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(35), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispOldPersalNo() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(36), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispWrongDept() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(37), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property BAS_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(38), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property VULIN_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(39), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispStoreNo() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(40), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispSystemGroup() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(41), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property BAS_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(42), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispNoStoreNumber() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(43), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispRole() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(44), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Region() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(45), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Cellphone() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(46), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Extension() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(47), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Billing_Code() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(48), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PERSAL_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(49), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property FMS_Store_Number() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(50), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PERSAL_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(51), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property FMS_Role() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(52), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispReAssignPersalNo() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(53), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Database() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(54), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property User_Code() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(55), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PreFMS() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(56), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PreEFT() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(57), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property PrePER() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(58), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispInternal_() As System.Nullable(Of zDispInternal_Type)
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(59), System.Nullable(Of zDispInternal_Type))
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zDispInternal_Specified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(60), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property zValidPersalNumber() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(61), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Temp_Postal_Address() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(62), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Temp_Postal_Code() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(63), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Character_Field() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(64), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Create_Date() As Date
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(65), Date)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Create_DateSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(66), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Last_Modified_By() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(67), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Modified_Date() As Date
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(68), Date)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Modified_DateSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(69), Boolean)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Status_History() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(70), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub GetListCompletedEventHandler(ByVal sender As Object, ByVal e As GetListCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class GetListCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As OutputMapping5GetListValues()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), OutputMapping5GetListValues())
            End Get
        End Property
    End Class
End Namespace



''Imports System
''Imports System.Collections.Generic
''Imports System.Linq
''Imports System.Web
''Imports System.Web.Services.WebService

''Namespace BMC_WS

''    Public Class WS

''        ' Public Module Declarations (Available Throughout Module)
''        Public ARSServer As New BMC.ARSystem.Server
''        Public ARServerName As String
''        Public ARServerPort As String
''        Public ARUser As String
''        Public ARPassword As String

''        ' // Start of Main Routine in Module, Capture Input Parameters

''        Public Sub Main(ByVal CmdLineArgs() As String)

''            ' // This program will perform the following:
''            ' // 1. Create a new Incident Request via the HPD:IncidentInteface_Create form
''            ' // 2. Query the HPD:IncidentInteface_Create form for Incident Number
''            ' // 3. Query the HPD:IncidentInteface form for the Entry ID for use with the modify function
''            ' // 4. Send a Modify command and parameters the HPD:IncidentInteface form to Close the Incident Request


''            ' // Input Parameters are:  
''            ' // -s ARServer, -u ARUser, -p ARPassword, -t ARServerPort, -f RequesterFirstName, -l RequesterLastName
''            ' // ** Password cannot be blank **
''            ' // The Create Uses Auto Assignment.  Fill in the required fields to use manual Assignment.  
''            ' // Extra cmd line Parameters will be needed for Company, Org, Support Group if manual assignment required
''            ' // or they can be hardcoded.
''            ' // ARUser must be someone with Incident Modify permission (e.g. Incident Master) and be in the same
''            ' // Support Group as Assignment.
''            ' // Define the required variables

''            Dim ErrMsg As String = String.Empty
''            Dim ARForm As String = "HPD:IncidentInterface_Create"
''            Dim IntInterfaceEntryID As String
''            Dim strIncidentID As String
''            Dim strEntryID As String
''            Dim strSQL As String
''            Dim FieldList As New BMC.ARSystem.FieldValueList
''            Dim EntryFieldList = New BMC.ARSystem.EntryListFieldList
''            Dim EntryFieldValueList = New BMC.ARSystem.EntryFieldValueList
''            Dim strFirstName As String
''            Dim strLastName As String

''            Try
''                ' // Extract parameters from cmd line.
''                ARServerName = GetArgValue(CmdLineArgs, "-s", ErrMsg)
''                ARUser = GetArgValue(CmdLineArgs, "-u", ErrMsg)
''                ARPassword = GetArgValue(CmdLineArgs, "-p", ErrMsg)
''                ARServerPort = GetArgValue(CmdLineArgs, "-t", ErrMsg)
''                strFirstName = GetArgValue(CmdLineArgs, "-f", ErrMsg)
''                strLastName = GetArgValue(CmdLineArgs, "-l", ErrMsg)


''                ' Below is the list of Minimum Fields Required by HPD:IncidentInterface_Create to create an Entry in HPD:HelpDesk
''                ' ** Note - Auto Assignment Rule needed on Incident form, else you need to populate the following Fields: **
''                ' Support Company*
''                ' Support Organization*
''                ' Support Group*
''                ' Assigned Group Shift Name
''                ' Assignee
''                ' Login ID for Assignee

''                FieldList.Add(1000000076, "CREATE")                                     ' // Keyword Triggers the Create
''                FieldList.Add(1000000018, strLastName)                                  ' // Last_Name
''                FieldList.Add(1000000019, strFirstName)                                 ' // First_Name
''                FieldList.Add(7, 1)                                                     ' // Status
''                FieldList.Add(1000000099, 3)                                            ' // Service_Type
''                FieldList.Add(1000000163, 4000)                                         ' // Impact
''                FieldList.Add(1000000162, 4000)                                         ' // Urgency
''                FieldList.Add(1000000000, "Remedy Test Ticket From API")            ' // Description
''                FieldList.Add(1000000215, 10000)                                        ' // Reported Source

''                ' // Optional for SRM Request Creation
''                'FieldList.Add(301674600, "Yes")                                        '// Flag_Create_Request - Required to create SRM Request Entry

''                ' // ** Call Login Function within ARSHelper Class **
''                ARSServer = ARSInitialise.Login

''                ' // ** Create the Entry in HPD:IncidentInterface_Create with above Field List **
''                ' // ** Returns the Request ID (Field ID 1) from the HPD:IncidentInterface_Create Form **
''                IntInterfaceEntryID = ARSServer.CreateEntry(ARForm, FieldList)

''                ' // ** Create SQL Query for GetListEntryWithFields Method **
''                ' // We are wanting to use the ID returned in the Create above - this is our reference
''                ' // * Example Query * 
''                ' // e.g. strSQL = "'1' = " & "00000000000006"
''                strSQL = "'1' = " & IntInterfaceEntryID

''                ' // Add The Field(s) We Want To Bring Back From The Form to the Entry Field List to parse in the method 
''                ' // e.g. Incident Number
''                EntryFieldList.AddField(1000000161) '//Incident Number
''                'EntryFieldList.AddField(1000000560) '//Reported Date*
''                'EntryFieldList.AddField(301572100)  '//SRID
''                'EntryFieldList.AddField(1000000082) '//Contact Company*
''                'EntryFieldList.AddField(1000000164) '//Priority

''                ' // ** Return the Incident ID* from the call
''                'EntryFieldValueList = ARSServer.GetListEntryWithFields("HPD:IncidentInterface_Create", strSQL, EntryFieldList, 0, 50)
''                strIncidentID = ""


''                ' // If returning more than one entry, use a for loop
''                For Each entryFieldValue In EntryFieldValueList
''                    strIncidentID = entryFieldValue.FieldValues(1000000161)
''                    Console.Write("Incident ID* = ")
''                    Console.WriteLine(entryFieldValue.FieldValues(1000000161))
''                Next

''                ' // NOTE: Query required for HPD:IncidentInterface differs from above as we are specifying a particular field by name
''                ' // Example SQL Query ** Note: Inverted Commas Needed or SQL Will Fail**
''                ' // strSQL = "'Incident Number' = ""INC000000000093"""
''                strSQL = "'Incident Number' = """ + strIncidentID + """"

''                ' // Retrieve Required Entry ID from HPD:IncidentInterface for Modify (Close) Action
''                EntryFieldList.Clear()
''                EntryFieldList.AddField(1)          '//Entry ID

''                'EntryFieldValueList = ARSServer.GetListEntryWithFields("HPD:Help Desk", strSQL, EntryFieldList, 0, 1)
''                strEntryID = ""

''                For Each entryFieldValue In EntryFieldValueList
''                    strEntryID = entryFieldValue.FieldValues(1)
''                    Console.Write("EntryID = ")
''                    Console.WriteLine(entryFieldValue.FieldValues(1))
''                Next


''                ' // Close Out the Incident by supplying Resolution, Status, Status Reason and Assignee information
''                ' // Assignee information is required on different setups, so best to include it for safety
''                FieldList.Clear()
''                FieldList.Add(1000000076, "MODIFY")                                     ' // Keyword Triggers the Modify
''                FieldList.Add(1000000156, "API Automatic Resolution")               ' // Resolution
''                FieldList.Add(1000000150, "No Further Action Required")                 ' // Status Reason
''                FieldList.Add(7, "Closed")                                              ' // Status
''                FieldList.Add(1000000218, (strFirstName & " " & strLastName))           ' // Asignee
''                FieldList.Add(4, ARUser)                                                ' // Login ID of Assignee
''                strSQL = strEntryID                                                     ' // Entry ID of HPD:IncidentInterface


''                ARSServer.SetEntry("HPD:IncidentInterface", strSQL, FieldList)          ' // Close Incident

''            Catch ex As BMC.ARSystem.ARException

''                Throw New System.Exception(ex.Message, ex.InnerException)
''                Exit Sub

''            Catch ir As Exception

''                Throw New System.Exception(ir.Message, ir.InnerException)

''            End Try
''        End Sub

''        ' // Function to return values from command line.
''        Function GetArgValue(ByRef ArgArray() As String, ByVal SwitchValue As String, ByRef ErrMsg As String) As String
''            ' Return switch values from command line.
''            ' Switches and values must only come in pairs, ie. -u User -p Password -s Server
''            Try
''                For i As Integer = 0 To UBound(ArgArray) Step 2
''                    If ArgArray(i) = SwitchValue Then
''                        Return ArgArray(i + 1)
''                    End If
''                Next
''            Catch ex As Exception
''                ErrMsg = ex.Message
''            End Try
''            Return String.Empty
''        End Function

''        ' // Class To Log Into ARServer 
''        Public Class ARSInitialise
''            ' // Parameters Obtained From Cmd Line Input
''            Public Shared Function Login() As ARSystem.Server
''                Try

''                    Dim RemedyServer As New ARSystem.Server
''                    'RemedyServer.Login(server:=, user:=, password:=, port:=) 
''                    RemedyServer.Login(ARServerName, ARUser, ARPassword)
''                    'RemedyServer.SetServerPort(port:=, rpcProgramNum:=)
''                    RemedyServer.SetServerPort(ARServerPort, 0)

''                    Dim UserInfo() As ARSystem.UserInfo = RemedyServer.GetListUser(ARSystem.Server.UserListType.Myself, New Date(2000, 1, 1))

''                    Return RemedyServer

''                Catch ex As Exception

''                    Throw New System.Exception(ex.Message, ex.InnerException)
''                    Exit Function

''                End Try

''            End Function

''            Public Sub test()

''                RemedyWebServiceCreate.HPD_IncidentInterface_Create_WSPortTypePortTypeClientService = New HPD_IncidentInterface_Create_WSPortTypePortTypeClient()
''                Dim Param0 As String
''                Param0 = "Test,Test"
''                Dim Param1 As RemedyWebServiceCreate.AuthenticationInfo = New AuthenticationInfo()
''                Param1.userName = "148596"
''                Param1.password = "TestPassword"
''                Param1.locale = [String].Empty
''                Param1.timeZone = String.Empty
''                Dim Param2 As String() = Param0.Split(","c)
''                Dim Param3 As String = "Test"
''                Dim Param4 As String = String.Empty
''                Dim Param5 As String = String.Empty
''                Dim Param6 As String = String.Empty
''                Dim Param7 As String = String.Empty
''                Dim Param8 As String = String.Empty
''                Dim Param9 As String = String.Empty
''                Dim Param10 As String = String.Empty
''                Dim Param11 As String = String.Empty
''                Dim Param12 As String = String.Empty
''                Dim Param13 As String = String.Empty
''                Dim Param14 As String = String.Empty
''                Dim Param15 As String = String.Empty
''                Dim Param16 As String = String.Empty
''                Dim Param17 As String = String.Empty
''                Dim Param18 As String = "James"

''                Dim Param19 As RemedyWebServiceCreate.ImpactType = New ImpactType()
''                Param19 = ImpactType.Item3ModerateLimited

''                Dim Param20 As String = "Johnson"
''                Dim Param21 As String = [String].Empty
''                Dim Param22 As String = [String].Empty
''                Dim Param23 As String = [String].Empty
''                Dim Param24 As String = [String].Empty
''                Dim Param25 As String = [String].Empty
''                Dim Param26 As String = [String].Empty
''                Dim Param27 As String = [String].Empty
''                Dim Param28 As RemedyWebServiceCreate.Reported_SourceType = New Reported_SourceType()
''                Param28 = Reported_SourceType.Email

''                Dim Param29 As String = [String].Empty
''                Dim Param30 As String = [String].Empty
''                Dim Param31 As String = [String].Empty
''                Dim Param32 As String = [String].Empty

''                Dim Param33 As RemedyWebServiceCreate.Service_TypeType = New Service_TypeType()
''                Param33 = Service_TypeType.UserServiceRestoration

''                Dim Param34 As RemedyWebServiceCreate.StatusType = New StatusType()
''                Param34 = StatusType.Assigned
''                Dim Param35 As String = "Create"

''                Dim Param36 As RemedyWebServiceCreate.Create_RequestType = New Create_RequestType()
''                Param36 = Create_RequestType.Yes
''                Dim Param37 As String = "Test Summary"
''                Dim Param38 As String = [String].Empty

''                Dim Param39 As RemedyWebServiceCreate.UrgencyType = New UrgencyType()
''                Param39 = UrgencyType.Item3Medium
''                Dim Param40 As String = [String].Empty
''                Dim Param41 As String = [String].Empty

''                Dim Param42 As RemedyWebServiceCreate.Work_Info_TypeType = New Work_Info_TypeType()
''                Param42 = Work_Info_TypeType.EmailSystem
''                Dim Param43 As New DateTime(2005, 9, 17)

''                Dim Param44 As RemedyWebServiceCreate.Work_Info_SourceType = New Work_Info_SourceType()
''                Param44 = Work_Info_SourceType.Email

''                Dim Param45 As RemedyWebServiceCreate.Create_RequestType = New Create_RequestType()
''                Param45 = Create_RequestType.No

''                Dim Param46 As RemedyWebServiceCreate.Work_Info_View_AccessType = New Work_Info_View_AccessType()
''                Param46 = Work_Info_View_AccessType.Internal
''                Dim Param47 As String() = Param0.Split(","c)

''                Dim Param48 As RemedyWebServiceCreate.Status_ReasonType = New Status_ReasonType()
''                Param48 = Status_ReasonType.Request

''                Dim Param49 As String = "James"
''                Dim Param50 As String = [String].Empty
''                Dim Param51 As String = "Johnson"
''                Dim Param52 As String = [String].Empty
''                Dim Param53 As String = [String].Empty
''                Dim Param54 As String = [String].Empty
''                Dim Param55 As String = [String].Empty
''                Dim Param56 As String = [String].Empty
''                Dim Param57 As String = [String].Empty

''                Service.Open()
''                Service.HelpDesk_Submit_Service(Param1, Param2, Param3, Param4, Param5, Param6, _
''                 Param7, Param8, Param9, Param10, Param11, Param12, _
''                 Param13, Param14, Param15, Param16, Param17, Param18, _
''                 Param19, Param20, Param21, Param22, Param23, Param24, _
''                 Param25, Param26, Param27, Param28, Param29, Param30, _
''                 Param31, Param32, Param33, Param34, Param35, Param36, _
''                 Param37, Param38, Param39, Param40, Param41, Param42, _
''                 Param43, Param44, Param45, Param46, Param47, Param48, _
''                 Param49, Param50, Param51, Param52, Param53, Param54, _
''                 Param55, Param56, Param57)

''                Service.Close()

''            End Sub

''        End Class

''End Namespace
