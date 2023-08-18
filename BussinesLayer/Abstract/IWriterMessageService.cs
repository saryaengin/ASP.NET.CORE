using BussinesLayer.Abtract;
using EntityLayer.Concrete;

namespace BussinesLayer.Abstract;

public interface IWriterMessageService : IGenericService<WriterMessage>
{
    List<WriterMessage> GetListSenderMessage(string p);
    List<WriterMessage> GetListReceiverMessage(string p);
}