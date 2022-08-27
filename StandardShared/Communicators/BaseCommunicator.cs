using StandardShared.Misc;

namespace StandardShared.Communicators
{
    public abstract class BaseCommunicator
    {
        protected readonly RequestInfoGeneric RequestInfo;
        public BaseCommunicator(RequestInfoGeneric requestInfo)
        {
            RequestInfo = requestInfo;
        }
    }
}
