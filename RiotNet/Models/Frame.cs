﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;

namespace RiotNet.Models
{
    /// <summary>
    /// This object contains game frame information.
    /// </summary>
    public class Frame
    {
        /// <summary>
        /// Gets or sets list of events for this frame.
        /// </summary>
        public virtual List<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets each participant's information for the frame, mapped by the participant's ID.
        /// </summary>
        public virtual MatchParticipantFrameCollection ParticipantFrames { get; set; }

        /// <summary>
        /// Gets or sets game time at which the frame occurred.
        /// </summary>
        public TimeSpan Timestamp { get; set; }

#if DB_READY
        /// <summary>
        /// Gets or sets the ID of the <see cref="Frame"/>. This does NOT come from the Riot API; it is used as a key when storing this object in a database.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public long DatabaseId { get; set; }
#endif
    }
}