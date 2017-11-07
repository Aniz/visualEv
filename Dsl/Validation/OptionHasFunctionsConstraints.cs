using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;
using System;
using System.Linq;

namespace Ufba.Ev
{
    [ValidationState(ValidationState.Enabled)]
    public partial class OptionHasFunctions
    {
        // Identify the method as a validation method:  
        [ValidationMethod
        ( // Specify which events cause the method to be invoked:  
          ValidationCategories.Open // On file load.  
        | ValidationCategories.Save // On save to file.  
        | ValidationCategories.Menu // On user menu command.  
        )]
        private void NeedsParameter(ValidationContext context)
        {
            var func = this.Function;
            var op = this.Option;

                var OptionsArray = new[] { "Speaker", "Organizer", "Reviewer", "Activity", "Author", "Receipt" };
                if (OptionsArray.Contains(func.Name.ToString()))
                    context.LogWarning("[Function] Invalid function: " + func.Name.ToString() + " on " + op.OptionType.ToString(), "Err 03", func);

                if (op.OptionType.ToString() == "Registration")
                {
                    if (!String.IsNullOrEmpty(this.Param))
                        context.LogWarning("[Function - Parameter] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " dont use parameter", "Err 02", func);

                    var RegistrationArray = new[] { "reportsFrequencyPerActivity", "reportsListofAuthors" };
                    if (!RegistrationArray.Contains(func.Name.ToString()))
                        context.LogError("[Function] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " not allowed", "Err 03", func);

                }
                if (op.OptionType.ToString() == "Event")
                {
                    if (!String.IsNullOrEmpty(this.Param))
                        context.LogWarning("[Function - Parameter] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " dont use parameter", "Err 02", func);

                    var EventArray = new[] { "eventProgram", "eventImportantDates", "reportsFrequencyPerEvent" };
                    if (!EventArray.Contains(func.Name.ToString()))
                        context.LogError("[Function] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " not allowed", "Err 03", func);

                }
				if (op.OptionType.ToString() == "Reviewer")
				{
					var EventArray = new[] { "reviewerRoundofReview"};
					if (!EventArray.Contains(func.Name.ToString()))
						context.LogError("[Function] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " not allowed", "Err 03", func);
				}
				if (op.OptionType.ToString() == "Assigment")
                {
                    if (!String.IsNullOrEmpty(this.Param))
                        context.LogWarning("[Function - Parameter] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " dont use parameter", "Err 02", func);

                    var AssigmentArray = new[] { "notificationsDeadline", "notificationsPaperAssignemnt", "notificationsAceptanceRejection", "assignmentInterestConflict" };
                    if (!AssigmentArray.Contains(func.Name.ToString()))
                        context.LogError("[Function] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " not allowed", "Err 03", func);

                }
                if (op.OptionType.ToString() == "User")
                {
                    if (!String.IsNullOrEmpty(this.Param))
                        context.LogWarning("[Function - Parameter] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " dont use parameter", "Err 02", func);
                    if (func.Name.ToString() != "userSendBugTrackEmail")
                        context.LogError("[Function] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " not allowed", "Err 03", func);
                 }

                //Needs Parameters
                if (op.OptionType.ToString() == "Submission")
                {
                    if (String.IsNullOrEmpty(this.Param) && func.Name.ToString() == "submissionInsertAttachment")
                    {
                        context.LogError("[Function - Parameter] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " needs a parameter", "Err 02", func);
                    }
                    var SubmissionArray = new[] { "submissionInsertAttachment", "submissionCompleteInsert", "submissionPartialInsert" };
                    if (!SubmissionArray.Contains(func.Name.ToString()))
                        context.LogError("[Function] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " not allowed", "Err 03", func);

                }
                if (op.OptionType.ToString() == "CheckingCopy")
                {
                    if (String.IsNullOrEmpty(this.Param))
                    {
                        context.LogError("[Function - Parameter] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " needs a parameter", "Err 02", func);
                    }
                    var CheckingCopyArray = new[] { "checkingCopyAtestado", "checkingCopyCertificado" };
                    if (!CheckingCopyArray.Contains(func.Name.ToString()))
                        context.LogError("[Function] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " not allowed", "Err 03", func);

                }
                if (op.OptionType.ToString() == "Payment")
                {
                    if (String.IsNullOrEmpty(this.Param))
                    {
                        context.LogError("[Function - Parameter] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " needs a parameter", "Err 02", func);
                    }
                    var PaymentArray = new[] { "generateCarne", "generateBoleto", "askCardInfo" };
                    if (!PaymentArray.Contains(func.Name.ToString()))
                        context.LogError("[Function] " + func.Name.ToString() + " on " + op.OptionType.ToString() + " not allowed", "Err 03", func);
                }
        }
    }
}
