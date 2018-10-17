using System;
using System.Collections.Generic;
using System.Linq;
using Tupy;

namespace Tupy.Logger
{
    public class ProviderManager
    {
        private List<IProvider> providers;

        public List<WriteStatus> StatusList { get; private set; }

        public ProviderManager()
        {
            providers = new List<IProvider>();
            StatusList = new List<WriteStatus>();
        }

        public IEnumerable<IProvider> List()
        {
            return providers;
        }

        public bool Add(IProvider provider)
        {
            var result = false;

            if (providers.Where(r => r.ID == provider.ID).Count() == 0)
            {
                providers.Add(provider);
                result = true;
            }
            return result;
        }

        public bool Remove(string ID)
        {
            var result = false;

            var provider = providers.Where(r => r.ID == ID).FirstOrDefault();

            if (provider != null)
            {
                providers.Remove(provider);
                result = true;
            }
            return result;
        }

        public bool WriteEntry(EventEntry entry)
        {
            ExecutionResponse response = null;
            string message = null;

            StatusList.Clear();

            foreach (var item in providers)
            {
                message = null;

                try
                {
                    response = item.WriteEntry(entry);
                }
                catch (Exception ex)
                {
                    response = new ExecutionResponse(false, ex.Message);
                }

                if (response.IsSuccess == false)
                {
                    var status = new WriteStatus()
                    {
                        ProviderID = item.ID,
                        ProviderType = item.Type,
                        Message = message ?? "An error has occurred during log entry writing."
                    };

                    StatusList.Add(status);
                }
            }

            bool result = StatusList.Count() > 0;
            return result;
        }
    }
}
