﻿using OrionClient.Helpers;
using OrionClient.Interfaces;
using OrionClient.Model;
using RestSharp;
using System;
using System.Collections.Generic;

namespace OrionClient.Compositions {

    public class BrokerDealerModule : IBrokerDealerModule {
        private IRestClient client = null;

        public BrokerDealerModule(IRestClient client) {
            this.client = client;
        }

        public IEnumerable<BrokerDealer> GetAll(int top = 1000, int skip = 0, bool? IsActive = default(bool?)) {
            var request = new RestRequest("Portfolio/BrokerDealers/Verbose", Method.GET);
            QueryHelpers.AddTopSkipQueryParameters(request, top, skip);

            var result = client.Execute<List<BrokerDealer>>(request);
            return result.Data;
        }

        public BrokerDealer Get(long id) {
            var request = new RestRequest("Portfolio/BrokerDealers/Verbose/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var result = client.Execute<BrokerDealer>(request);
            return result.Data;
        }

        public BrokerDealer Create(BrokerDealer representative) {
            throw new NotImplementedException();
        }

        public BrokerDealer Update(BrokerDealer representative) {
            throw new NotImplementedException();
        }
    }
}