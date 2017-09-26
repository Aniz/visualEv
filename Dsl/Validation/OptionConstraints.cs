using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;

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
            //Validar se speaker reviewer e  organizer foi definido sem user 
            foreach (Option op1 in this.EvModel.Elements)
            {
                foreach (Option op2 in this.EvModel.Elements)
                {
                    if (op1.OptionType == op2.OptionType && op1.Id != op2.Id)
                    {
                        context.LogError("Duplicated OptionType in" + op1.OptionType.ToString(), "Err 04", op1);
                    }
                    
                }
            }
        }
    }
}
