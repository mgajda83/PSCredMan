using System.Management.Automation;
using CredentialManagement;


namespace PSCredentialManager
{
    [Cmdlet("Get", "PSCredentialManager", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    public class GetPSCredentialManager : Cmdlet
    {
        /// <summary>
        /// <para type="description">Target name.</para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string Target { get; set; }

        private string _Output = "PSCredential";
        /// <summary>
        /// <para type="description">Set output format: PSCredential, SecureString or ClearText.</para>
        /// </summary>
        [Parameter()]
        [ValidateSet("PSCredential", "SecureString", "ClearText")]
        public string Output
        {
            get { return _Output; }
            set { _Output = value; }
        }

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
            using (var credential = new Credential())
            {
                credential.Target = Target;
                credential.Load();
                WriteVerbose("Credential loaded.");

                switch (Output)
                {
                    case "PSCredential":
                        WriteObject(new PSCredential(credential.Username, credential.SecurePassword));
                        break;
                    case "SecureString":
                        WriteObject(credential.SecurePassword);
                        break;
                    case "ClearText":
                        WriteObject(credential.Password);
                        break;
                    default:
                        WriteObject(new PSCredential(credential.Username, credential.SecurePassword));
                        break;
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
