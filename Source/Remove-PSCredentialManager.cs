using System.Management.Automation;
using CredentialManagement;


namespace PSCredentialManager
{
    [Cmdlet("Remove", "PSCredentialManager", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    public class RemovePSCredentialManager : Cmdlet
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
                credential.Delete();
                WriteVerbose("Credential removed.");
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
