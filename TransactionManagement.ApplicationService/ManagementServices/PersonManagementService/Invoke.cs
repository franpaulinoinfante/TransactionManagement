namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public class Invoke
    {
        private readonly ICommand[] _command = new ICommand[4];

        public Invoke(IPersonManagementService personManagementService, PersonDto personDto)
        {
            _command[0] = new CreatePersonCommand(personManagementService, personDto);
        }

        public void Run(int indice)
        {
            _command[indice].Execute();
        }
    }
}
