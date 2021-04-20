Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace ThemePreloadwithSplashscreen
	Friend Module EmployeeImageHelper
		Public Const ImagesPath As String = "pack://application:,,,/DevExpress.Images.v" & AssemblyInfo.VersionShort & ";component/SvgImages/"
	End Module
	Public Enum PersonPrefix
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/Doctor.svg")>
		Dr
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/Customers.svg")>
		Mr
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/Mr.svg")>
		Ms
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/Miss.svg")>
		Miss
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/Mrs.svg")>
		Mrs
	End Enum

	Public Enum EmployeeStatus
		Salaried
		Commission
		Terminated
		OnLeave
	End Enum
	Public Enum EmployeeDepartment
		Sales
		Support
		Shipping
		Engineering
		HumanResources
		Management
		IT
	End Enum
	Public Enum StateEnum
		CA
		AR
		AL
		AK
		AZ
		CO
		CT
		DE
		DC
		FL
		GA
		HI
		ID
		IL
		[IN]
		IA
		KS
		KY
		LA
		[ME]
		MD
		MA
		MI
		MN
		MS
		MO
		MT
		NE
		NV
		NH
		NJ
		NM
		NY
		NC
		OH
		OK
		[OR]
		PA
		RI
		SC
		SD
		TN
		TX
		UT
		VT
		VA
		WA
		WV
		WI
		WY
		ND
	End Enum

	Public Enum EmployeeTaskPriority
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/LowPriority.svg")>
		Low
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/NormalPriority.svg")>
		Normal
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/MediumPriority.svg")>
		High
		<Image(EmployeeImageHelper.ImagesPath & "Outlook Inspired/HighPriority.svg")>
		Urgent
	End Enum

	Public Class EmployeeTask
		Public Property Completion() As Integer
		Public Property Description() As String
		Public Property DueDate() As DateTime?
		Public Property Priority() As EmployeeTaskPriority
		Public Property StartDate() As DateTime?
		Public Property Subject() As String
	End Class
	Public Class Evaluation
		Public Property CreatedOn() As DateTime
		Public Property Manager() As String
		Public Property Subject() As String
	End Class
	Public Class Address
		Inherits ViewModelBase

'INSTANT VB NOTE: The field city was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private city_Conflict As String
'INSTANT VB NOTE: The field line was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private line_Conflict As String
'INSTANT VB NOTE: The field state was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private state_Conflict As StateEnum
'INSTANT VB NOTE: The field zipCode was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private zipCode_Conflict As String
		Public Property City() As String
			Get
				Return city_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(city_Conflict, value, "City")
			End Set
		End Property
		Public Property Line() As String
			Get
				Return line_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(line_Conflict, value, "Line")
			End Set
		End Property
		Public Property State() As StateEnum
			Get
				Return state_Conflict
			End Get
			Set(ByVal value As StateEnum)
				SetProperty(state_Conflict, value, "State")
			End Set
		End Property
		Public Property ZipCode() As String
			Get
				Return zipCode_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(zipCode_Conflict, value, "ZipCode")
			End Set
		End Property
		Public Sub New()
			Initialize()
		End Sub
		Private Sub Initialize()
			Line = "6755 Newlin Ave"
			City = "Whittier"
			State = StateEnum.AK
			ZipCode = "90601"
		End Sub
	End Class

	Public Class EmployeeViewModel
		Inherits ViewModelBase
		Implements IDataErrorInfo

'INSTANT VB NOTE: The field address was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private address_Conflict As Address
'INSTANT VB NOTE: The field assignedTasks was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private assignedTasks_Conflict As List(Of EmployeeTask)
'INSTANT VB NOTE: The field birthDate was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private birthDate_Conflict? As DateTime
'INSTANT VB NOTE: The field department was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private department_Conflict As EmployeeDepartment
'INSTANT VB NOTE: The field email was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private email_Conflict As String
'INSTANT VB NOTE: The field evaluations was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private evaluations_Conflict As List(Of Evaluation)
'INSTANT VB NOTE: The field firstName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private firstName_Conflict As String
'INSTANT VB NOTE: The field hireDate was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private hireDate_Conflict? As DateTime
'INSTANT VB NOTE: The field homePhone was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private homePhone_Conflict As String
'INSTANT VB NOTE: The field lastName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private lastName_Conflict As String
'INSTANT VB NOTE: The field mobilePhone was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private mobilePhone_Conflict As String
'INSTANT VB NOTE: The field personalProfile was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private personalProfile_Conflict As String
'INSTANT VB NOTE: The field photo was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private photo_Conflict As ImageSource
'INSTANT VB NOTE: The field prefix was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private prefix_Conflict As PersonPrefix
'INSTANT VB NOTE: The field probationReason was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private probationReason_Conflict As String
'INSTANT VB NOTE: The field skype was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private skype_Conflict As String
'INSTANT VB NOTE: The field status was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private status_Conflict As EmployeeStatus
'INSTANT VB NOTE: The field title was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private title_Conflict As String
		Public Property Address() As Address
			Get
				Return address_Conflict
			End Get
			Set(ByVal value As Address)
				SetProperty(address_Conflict, value, "Address")
			End Set
		End Property
		Public Property AssignedTasks() As List(Of EmployeeTask)
			Get
				Return assignedTasks_Conflict
			End Get
			Set(ByVal value As List(Of EmployeeTask))
				SetProperty(assignedTasks_Conflict, value, "AssignedTasks")
			End Set
		End Property
		Public Property BirthDate() As DateTime?
			Get
				Return birthDate_Conflict
			End Get
			Set(ByVal value? As DateTime)
				SetProperty(birthDate_Conflict, value, "BirthDate")
			End Set
		End Property
		Public Property Department() As EmployeeDepartment
			Get
				Return department_Conflict
			End Get
			Set(ByVal value As EmployeeDepartment)
				SetProperty(department_Conflict, value, "Department")
			End Set
		End Property
		Public Property Email() As String
			Get
				Return email_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(email_Conflict, value, "Email")
			End Set
		End Property
		Public Property Evaluations() As List(Of Evaluation)
			Get
				Return evaluations_Conflict
			End Get
			Set(ByVal value As List(Of Evaluation))
				SetProperty(evaluations_Conflict, value, "Evaluations")
			End Set
		End Property
		Public Property FirstName() As String
			Get
				Return firstName_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(firstName_Conflict, value, "FirstName", AddressOf RaiseFullNamePropertyChanged)
			End Set
		End Property
		Public ReadOnly Property FullName() As String
			Get
				Return String.Format("{0} {1}", FirstName, LastName)
			End Get
		End Property
		Public Property HireDate() As DateTime?
			Get
				Return hireDate_Conflict
			End Get
			Set(ByVal value? As DateTime)
				SetProperty(hireDate_Conflict, value, "HireDate")
			End Set
		End Property
		Public Property HomePhone() As String
			Get
				Return homePhone_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(homePhone_Conflict, value, "HomePhone")
			End Set
		End Property
		Public Property LastName() As String
			Get
				Return lastName_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(lastName_Conflict, value, "LastName", AddressOf RaiseFullNamePropertyChanged)
			End Set
		End Property
		Public Property MobilePhone() As String
			Get
				Return mobilePhone_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(mobilePhone_Conflict, value, "MobilePhone")
			End Set
		End Property
		Public Property PersonalProfile() As String
			Get
				Return personalProfile_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(personalProfile_Conflict, value, "PersonalProfile")
			End Set
		End Property
		Public Property Photo() As ImageSource
			Get
				Return photo_Conflict
			End Get
			Set(ByVal value As ImageSource)
				SetProperty(photo_Conflict, value, "Photo")
			End Set
		End Property
		Public Property Prefix() As PersonPrefix
			Get
				Return prefix_Conflict
			End Get
			Set(ByVal value As PersonPrefix)
				SetProperty(prefix_Conflict, value, "Prefix")
			End Set
		End Property
		Public Property ProbationReason() As String
			Get
				Return probationReason_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(probationReason_Conflict, value, "ProbationReason")
			End Set
		End Property
		Public Property Skype() As String
			Get
				Return skype_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(skype_Conflict, value, "Skype")
			End Set
		End Property
		Public Property Status() As EmployeeStatus
			Get
				Return status_Conflict
			End Get
			Set(ByVal value As EmployeeStatus)
				SetProperty(status_Conflict, value, "Status")
			End Set
		End Property
		Public Property Title() As String
			Get
				Return title_Conflict
			End Get
			Set(ByVal value As String)
				SetProperty(title_Conflict, value, "Title")
			End Set
		End Property
		Public Sub New()
			Initialize()
		End Sub
		Private Sub Initialize()
			Address = New Address()
			FirstName = "Leah"
			LastName = "Simpson"
			BirthDate = New DateTime(1983, 4, 19)
			Title = "Test Coordinator"
			Prefix = PersonPrefix.Mrs
			HomePhone = "(562) 555-7372"
			MobilePhone = "(562) 559-5830"
			Email = "leahs@dx-email.com"
			Skype = "leahs_DX_skype"
			Department = EmployeeDepartment.Engineering
			Status = EmployeeStatus.Salaried
			HireDate = New DateTime(2009, 2, 14)
			Photo = New BitmapImage(New Uri("pack://application:,,,/ThemePreloadwithSplashscreen;component/Data/w03.jpg"))
			GenerateAssignedTasks()
			GenerateEvaluations()
		End Sub
		Private Sub RaiseFullNamePropertyChanged()
			RaisePropertyChanged("FullName")
		End Sub
		Private Sub GenerateAssignedTasks()
			AssignedTasks = New List(Of EmployeeTask)()
			Dim employeeTask1 As New EmployeeTask()
			employeeTask1.Priority = EmployeeTaskPriority.Normal
			employeeTask1.DueDate = DateTime.Now.Add(New TimeSpan(10, 10, 0, 0, 0))
			employeeTask1.Subject = String.Format("{0} QA Strategy Report", DateTime.Now.Year)
			employeeTask1.Description = String.Format("In final stages of the {0} R & D Report to Management.Need QA strategy report asap.Remember, {1} was a difficult year product quality-wise and we must step it up in {0}. Leah Simpson: Bart, my apologies about {1}.My report includes remedies to issues we encountered.", DateTime.Now.Year, DateTime.Now.Year - 1)
			employeeTask1.Completion = 100
			AssignedTasks.Add(employeeTask1)

			Dim employeeTask2 As New EmployeeTask()
			employeeTask2.Priority = EmployeeTaskPriority.Urgent
			employeeTask2.DueDate = DateTime.Now.Add(New TimeSpan(40, 10, 0, 0, 0))
			employeeTask2.Subject = "Review Training Course for any Commissions"
			employeeTask2.Description = "Leah, consider this most important item on your agenda. I need this new training material reviewed so it can be submitted to management. Leah Simpson: I only found a few spelling mistakes."
			employeeTask2.Completion = 70
			AssignedTasks.Add(employeeTask2)


			Dim employeeTask3 As New EmployeeTask()
			employeeTask3.Priority = EmployeeTaskPriority.Low
			employeeTask3.DueDate = DateTime.Now.Add(New TimeSpan(80, 10, 0, 0, 0))
			employeeTask3.Subject = "Review New Training Material"
			employeeTask3.Description = "Just getting ready to push out some new training material for our customers so they can better understand how our product line fits together.Can I get a review of the content so I can send it out to the printer ? Leah Simpson: Nat, I've reviewed everything and it looks really nice."
			employeeTask3.Completion = 55
			AssignedTasks.Add(employeeTask3)

			Dim employeeTask4 As New EmployeeTask()
			employeeTask4.Priority = EmployeeTaskPriority.High
			employeeTask4.DueDate = DateTime.Now.Add(New TimeSpan(95, 10, 0, 0, 0))
			employeeTask4.Subject = "Test New Automation App"
			employeeTask4.Description = "We are in a rush to ship this and you need to put all your energy behind finding bugs.If you do find bugs, use standard reporting mechanisms. We'll fix what we can as soon as we can."
			employeeTask4.Completion = 40
			AssignedTasks.Add(employeeTask4)

			Dim employeeTask5 As New EmployeeTask()
			employeeTask5.Priority = EmployeeTaskPriority.Urgent
			employeeTask5.DueDate = DateTime.Now.Add(New TimeSpan(30, 10, 0, 0, 0))
			employeeTask5.Subject = "Email Test Report on New Products"
			employeeTask5.Description = "Leah, we cannot fix our products until we get the test report from you.Please send everything you have by email to me so I can distribute it in the engineering dept. Leah Simpson: Still collecting these"
			employeeTask5.Completion = 15
			AssignedTasks.Add(employeeTask5)
		End Sub
		Private Sub GenerateEvaluations()
			Dim r As New Random()
			Evaluations = New List(Of Evaluation)()
			For i As Integer = HireDate.Value.Year To DateTime.Now.Year - 1
				Evaluations.Add(New Evaluation() With {
					.CreatedOn = New DateTime(i, r.Next(1, 12), r.Next(1, 25)),
					.Manager = "Bart Simpson",
					.Subject = String.Format("{0} Employee Review", i)
				})
			Next i
		End Sub
		Default Public ReadOnly Property Item(ByVal columnName As String) As String Implements IDataErrorInfo.Item
			Get
				If columnName = "FirstName" AndAlso String.IsNullOrEmpty(FirstName) Then
					Return "The First Name field is required."
				End If
				If columnName = "LastName" AndAlso String.IsNullOrEmpty(LastName) Then
					Return "The Last Name field is required."
				End If
				If columnName = "Title" AndAlso String.IsNullOrEmpty(Title) Then
					Return "The Title field is required."
				End If
				If columnName = "MobilePhone" AndAlso String.IsNullOrEmpty(MobilePhone) Then
					Return "The Mobile Phone field is required."
				End If
				If columnName = "Email" AndAlso String.IsNullOrEmpty(Email) Then
					Return "The Email field is required."
				End If
				Return Nothing
			End Get
		End Property
		Public ReadOnly Property [Error]() As String Implements IDataErrorInfo.Error
			Get
'INSTANT VB NOTE: The local variable error was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
				Dim error_Conflict As String = Me("FirstName") & Me("LastName") & Me("Title") & Me("MobilePhone") & Me("Email")
				If Not String.IsNullOrEmpty(error_Conflict) Then
					Return "Please check inputted data."
				End If
				Return Nothing
			End Get
		End Property
	End Class
	Public Class OverviewDemoViewModel
		Inherits ViewModelBase

		Public Property Employee() As EmployeeViewModel
	End Class

	Public Class EnumToItemSourceProvider
		Inherits MarkupExtension

		Public Property EnumType() As Type
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Dim result As New List(Of Object)()
			Dim values As Array = System.Enum.GetValues(EnumType)
			For Each value In values
				result.Add(New With {
					Key .Name = System.Enum.GetName(EnumType, value),
					Key .Value = value
				})
			Next value

			Return result
		End Function
	End Class
End Namespace
