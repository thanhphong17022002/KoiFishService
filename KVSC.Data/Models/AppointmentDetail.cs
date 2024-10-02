﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KVSC.Data.Models;

public partial class AppointmentDetail
{
    public int AppointmentDetailId { get; set; }

    public int? AppointmentId { get; set; }

    public int? DoctorId { get; set; }

    public string ServiceNotes { get; set; }

    public string Result { get; set; }

    public string Prescription { get; set; }

    public string ServiceFeedback { get; set; }

    public DateTime? CompletionDate { get; set; }

    public int? Rating { get; set; }

    public DateTime? NextAppointmentDate { get; set; }

    public string FollowUpInstructions { get; set; }

    public virtual Appointment Appointment { get; set; }

    public virtual Doctor Doctor { get; set; }
}