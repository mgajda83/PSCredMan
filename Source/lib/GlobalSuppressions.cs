// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

// Based on project credentialmanagement by ilyalozovyy
// https://github.com/ilyalozovyy/credentialmanagement/

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "CredentialManagement.BaseCredentialsPrompt.#CreateCREDUI_INFO(System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "CredentialManagement.CredentialSet.#LoadInternal()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable", Scope = "type", Target = "CredentialManagement.NativeMethods+CREDENTIAL")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member", Target = "CredentialManagement.NativeMethods+CREDUI_INFO.#hwndParent")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member", Target = "CredentialManagement.NativeMethods+CREDUI_INFO.#hbmBanner")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "6", Scope = "member", Target = "CredentialManagement.NativeMethods.#CredUIPromptForCredentials(CredentialManagement.NativeMethods+CREDUI_INFO&,System.String,System.IntPtr,System.Int32,System.Text.StringBuilder,System.Int32,System.Text.StringBuilder,System.Int32,System.Boolean&,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "4", Scope = "member", Target = "CredentialManagement.NativeMethods.#CredUIPromptForCredentials(CredentialManagement.NativeMethods+CREDUI_INFO&,System.String,System.IntPtr,System.Int32,System.Text.StringBuilder,System.Int32,System.Text.StringBuilder,System.Int32,System.Boolean&,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "1", Scope = "member", Target = "CredentialManagement.NativeMethods.#CredUIPromptForCredentials(CredentialManagement.NativeMethods+CREDUI_INFO&,System.String,System.IntPtr,System.Int32,System.Text.StringBuilder,System.Int32,System.Text.StringBuilder,System.Int32,System.Boolean&,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "7", Scope = "member", Target = "CredentialManagement.NativeMethods.#CredUnPackAuthenticationBuffer(System.Int32,System.IntPtr,System.UInt32,System.Text.StringBuilder,System.Int32&,System.Text.StringBuilder,System.Int32&,System.Text.StringBuilder,System.Int32&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "5", Scope = "member", Target = "CredentialManagement.NativeMethods.#CredUnPackAuthenticationBuffer(System.Int32,System.IntPtr,System.UInt32,System.Text.StringBuilder,System.Int32&,System.Text.StringBuilder,System.Int32&,System.Text.StringBuilder,System.Int32&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "3", Scope = "member", Target = "CredentialManagement.NativeMethods.#CredUnPackAuthenticationBuffer(System.Int32,System.IntPtr,System.UInt32,System.Text.StringBuilder,System.Int32&,System.Text.StringBuilder,System.Int32&,System.Text.StringBuilder,System.Int32&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "CredentialManagement.SecureStringHelper.#CreateString(System.Security.SecureString)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "CredentialManagement.VistaPrompt.#ShowDialog(System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke", Scope = "member", Target = "CredentialManagement.VistaPrompt.#ShowDialog(System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "CredentialManagement.XPPrompt.#CreateCREDUI_INFO(System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "CredentialManagement.XPPrompt.#ShowDialog(System.IntPtr)")]
