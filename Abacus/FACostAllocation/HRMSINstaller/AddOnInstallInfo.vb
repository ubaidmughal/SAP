'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace AddOnInstaller
    
    Public Class AddOnInstallInfo
        
        Public StrAddOnInstallPath As String
        
        Public AddOnName As String
        
        Public PartnerName As String
        
        Public ExeFile As String
        
        Public DIFile As String
        
        Public UIFile As String
        
        Public B1WizardBaseFile As String
        
        Public ExtraFiles As System.String()
        
        Public ExtraDirectories As System.String()

        Public RestartNeeded As Boolean
        
        Public Sub New()
            MyBase.New
            'INITIALIZATION CODE	...
            AddOnName = "FA Cost Allocation"
            PartnerName = "AbacusConsulting"
            RestartNeeded = False
            ExeFile = "FACostAllocation.exe"
            DIFile = "Interop.SAPbobsCOM.dll"
            UIFile = "Interop.SAPbouiCOM.dll"
            B1WizardBaseFile = "Interop.MSXML2.dll"

            ExtraFiles = New String() {"Msgs.res", "CFL.bmp", "Payroll.bmp", "mfmLicensing.dll"}

            ExtraDirectories = New String() {"", "", "", ""}

        End Sub
    End Class
End Namespace