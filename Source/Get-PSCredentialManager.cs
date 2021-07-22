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

                PSCredential psCredential = new PSCredential(credential.Username, credential.SecurePassword);
                WriteObject(psCredential);
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
