using System;
using System.Management.Automation;
using CredentialManagement;
using System.Security;


namespace PSCredentialManager
{
    [Cmdlet("Set", "PSCredentialManager", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    public class SetPSCredentialManager : Cmdlet
    {
        /// <summary>
        /// <para type="description">Target name.</para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string Target { get; set; }

        /// <summary>
        /// <para type="description">User name.</para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string UserName { get; set; }

        /// <summary>
        /// <para type="description">Password in clear text. If null it prompt for secure string.</para>
        /// </summary>
        [Parameter()]
        public string Password { get; set; }

        /// <summary>
        /// <para type="description">Credential type.</para>
        /// </summary>
        [Parameter()]
        [ValidateSet("Generic", "DomainPassword", "DomainVisiblePassword")]
        private string Type { get; set; }

        /// <summary>
        /// <para type="description">Persistance type.</para>
        /// </summary>
        [Parameter()]
        [ValidateSet("LocalComputer", "Enterprise", "Session")]
        public string Persistance { get; set; }

        /// <summary>
        /// Begin
        /// </summary>
        protected override void BeginProcessing()
        {
        }


        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            /*
            CredentialType credentialType = new CredentialType();
            switch (Type)
            {
                case "Generic":
                    credentialType = CredentialType.Generic;
                    break;
                case "DomainPassword":
                    credentialType = CredentialType.DomainPassword;
                    break;
                case "DomainVisiblePassword":
                    credentialType = CredentialType.DomainVisiblePassword;
                    break;
                default:
                    credentialType = CredentialType.Generic;
                    break;
            }
            */

            PersistanceType persistanceType = new PersistanceType();
            switch (Persistance)
            {
                case "LocalComputer":
                    persistanceType = PersistanceType.LocalComputer;
                    break;
                case "Enterprise":
                    persistanceType = PersistanceType.Enterprise;
                    break;
                case "Session":
                    persistanceType = PersistanceType.Session;
                    break;
                default:
                    persistanceType = PersistanceType.LocalComputer;
                    break;
            }

            if (string.IsNullOrEmpty(Password))
            {
                // Instantiate the secure string.
                SecureString securePassword = new SecureString();
                ConsoleKeyInfo key;

                Console.Write("Enter password: ");
                do
                {
                    key = Console.ReadKey(true);

                    // Ignore any key out of range.
                    //if (((int)key.Key) >= 65 && ((int)key.Key <= 90))
                    //{
                        // Append the character to the password.
                        securePassword.AppendChar(key.KeyChar);
                        Console.Write("*");
                    //}
                    // Exit if Enter key is pressed.
                } while (key.Key != ConsoleKey.Enter);
                Console.WriteLine();

                // Save credential
                using (var credential = new Credential())
                {
                    credential.Target = Target;
                    WriteVerbose("Target: " + Target);

                    credential.Username = UserName;
                    WriteVerbose("Username: " + UserName);

                    credential.SecurePassword = securePassword;
                    credential.Type = CredentialType.Generic; //credentialType;
                    WriteVerbose("CredentialType: " + CredentialType.Generic);

                    credential.PersistanceType = persistanceType;
                    WriteVerbose("PersistanceType: " + persistanceType);

                    credential.Save();
                    WriteVerbose("Credential saved.");
                }
            } else
            {
                // Save credential
                using (var credential = new Credential())
                {
                    credential.Target = Target;
                    WriteVerbose("Target: " + Target);

                    credential.Username = UserName;
                    WriteVerbose("Username: " + UserName);

                    credential.Password = Password;
                    credential.Type = CredentialType.Generic; //credentialType;
                    WriteVerbose("CredentialType: " + CredentialType.Generic);

                    credential.PersistanceType = persistanceType;
                    WriteVerbose("PersistanceType: " + persistanceType);

                    credential.Save();
                    WriteVerbose("Credential saved.");
                }
            }

        }

        /// <summary>
        /// End
        /// </summary>
        protected override void EndProcessing()
        {
        }

        /// <summary>
        /// Stop
        /// </summary>
        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
