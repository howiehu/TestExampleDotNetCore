using ExpenseService.Exceptions;
using ExpenseService.Models.Expense;
using ExpenseService.Models.Project;
using static ExpenseService.Models.Expense.ExpenseType;
using static ExpenseService.Models.Project.ProjectType;

namespace ExpenseService
{
    public class ExpenseService
    {
        public static ExpenseType GetExpenseCodeByProjectTypeAndName(Project project)
        {
            if (project.Type == Internal)
            {
                return InternalProjectExpense;
            }

            if (project.Type == External)
            {
                if (project.Name.Equals("Project A"))
                {
                    return ExpenseTypeA;
                }

                if (project.Name.Equals("Project B"))
                {
                    return ExpenseTypeB;
                }

                return OtherExpense;
            }

            throw new UnexpectedProjectTypeException("You enter invalid project type");
        }
    }
}
