namespace Dotnet.Observer
{
    public class ConcreteSubject : Subject
    {
        public string subjectState;
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}