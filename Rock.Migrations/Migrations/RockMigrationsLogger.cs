using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Migrations
{
    /// <summary>
    /// 
    /// </summary>
    public class RockMigrationsLogger : System.Data.Entity.Migrations.Infrastructure.MigrationsLogger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RockMigrationsLogger"/> class.
        /// </summary>
        public RockMigrationsLogger()
        {
            InfoMessages = new List<string>();
            VerboseMessages = new List<string>();
            WarningMessages = new List<string>();
        }

        /// <summary>
        /// Gets or sets the information messages.
        /// </summary>
        /// <value>
        /// The information messages.
        /// </value>
        public List<string> InfoMessages { get; set; }
        
        /// <summary>
        /// Gets or sets the verbose messages.
        /// </summary>
        /// <value>
        /// The verbose messages.
        /// </value>
        public List<string> VerboseMessages { get; set; }

        /// <summary>
        /// Gets or sets the warning messages.
        /// </summary>
        /// <value>
        /// The warning messages.
        /// </value>
        public List<string> WarningMessages { get; set; }

        #region Implementation of MigrationsLogger

        /// <summary>
        /// Logs an informational message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        public override void Info( string message )
        {
            InfoMessages.Add( message );
        }

        /// <summary>
        /// Logs some additional information that should only be presented to the user if they request verbose output.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        public override void Verbose( string message )
        {
            VerboseMessages.Add( message );
        }

        /// <summary>
        /// Logs a warning that the user should be made aware of.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        public override void Warning( string message )
        {
            WarningMessages.Add( message );
        }

        #endregion
    }
}
