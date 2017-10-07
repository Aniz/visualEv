using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;
using System.Linq;

namespace Ufba.Ev
{
    [ValidationState(ValidationState.Enabled)]
    public partial class Option
    {
        // Identify the method as a validation method:  
        [ValidationMethod
        ( // Specify which events cause the method to be invoked:  
          ValidationCategories.Open // On file load.  
        | ValidationCategories.Save // On save to file.  
        | ValidationCategories.Menu // On user menu command.  
        )]
        private void DuplicatedEntry(ValidationContext context)
        {
            foreach (Option op2 in this.EvModel.Elements)
            {
                if (this.OptionType == op2.OptionType && this.Id != op2.Id)
                {
                    context.LogError("Duplicated OptionType in" + this.OptionType.ToString(), "Err 04", this);
                }
            }
        }

		// Identify the method as a validation method:  
		[ValidationMethod
		( // Specify which events cause the method to be invoked:  
		  ValidationCategories.Open // On file load.  
		| ValidationCategories.Save // On save to file.  
		| ValidationCategories.Menu // On user menu command.  
		)]
		private void MissingDependency(ValidationContext context)
		{
			if(this.OptionType.ToString() == "Speaker")
			{
				bool hasU = this.EvModel.Elements.Any(op => op.OptionType.ToString() == "User");
				if(!hasU)
					context.LogError("[Dependency] Speaker's dependency (User) not found", "Err 01", this);
			}

			if (this.OptionType.ToString() == "Organizer")
			{
				bool hasU = this.EvModel.Elements.Any(op => op.OptionType.ToString() == "User");
				if (!hasU)
					context.LogError("[Dependency] Organizer's dependency (User) not found", "Err 01", this);
			}

			if (this.OptionType.ToString() == "Reviewer")
			{
				bool hasU = this.EvModel.Elements.Any(op => op.OptionType.ToString() == "User");
				if (!hasU)
					context.LogError("[Dependency] Reviewer's dependency (User) not found", "Err 01", this);
			}
			if (this.OptionType.ToString() == "Author")
			{
				bool hasU = this.EvModel.Elements.Any(op => op.OptionType.ToString() == "User");
				if (!hasU)
					context.LogError("[Dependency] Author's dependency (User) not found", "Err 01", this);
			}
		}
	}
}
