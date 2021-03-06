﻿using System.Collections.Generic;
using System.Runtime.Caching;
using System.Threading;
using _30TipsAndTricks.WebForms.Interfaces;
using _30TipsAndTricks.WebForms.Models;

namespace _30TipsAndTricks.WebForms.Repositories
{
    public class StateRepository : IStateRepository
    {
        private ICacheProvider _cacheProvider;

        public StateRepository(ICacheProvider cacheProvider)
        {
            
            _cacheProvider = cacheProvider;

        }

        public IEnumerable<State> GetAll()
        {
            //If its in the cache, grab it.
            var cacheKey = "States";

            //var cachedStates = (List<State>) MemoryCache.Default.Get("SomeObject", "SomeValue");

            var cachedStates = _cacheProvider.Get<List<State>>(cacheKey);
            if (cachedStates != null)
            {
                return cachedStates;
            }
            else
            {
                //Fake delay
                Thread.Sleep(5000);
                string[] values = { "", "" };

                string[] states =
                {
                    "", "", "AL", "Alabama - AL", "AK", "Alaska - AK", "AZ", "Arizona - AZ",
                    "AR", "Arkansas - AR", "CA", "California - CA", "CO", "Colorado - CO", "CT", "Connecticut - CT",
                    "DC", "District of Columbia",
                    "DE", "Delaware - DE", "FL", "Florida - FL", "GA", "Georgia - GA", "HI", "Hawaii - HI", "ID",
                    "Idaho - ID", "IL", "Illinois - IL",
                    "IN", "Indiana - IN", "IA", "Iowa - IA", "KS", "Kansas - KS", "KY", "Kentucky - KY", "LA",
                    "Louisiana - LA", "ME", "Maine - ME",
                    "MD", "Maryland - MD", "MA", "Massachusetts - MA", "MI", "Michigan - MI", "MN", "Minnesota - MN",
                    "MS", "Mississippi - MS",
                    "MO", "Missouri - MO", "MT", "Montana - MT", "NE", "Nebraska - NE", "NV", "Nevada - NV", "NH",
                    "New Hampshire - NH",
                    "NJ", "New Jersey - NJ", "NM", "New Mexico - NM", "NY", "New York - NY", "NC", "North Carolina - NC"
                    , "ND", "North Dakota - ND",
                    "OH", "Ohio - OH", "OK", "Oklahoma - OK", "OR", "Oregon - OR", "PA", "Pennsylvania - PA", "PR",
                    "Puerto Rico - PR", "RI", "Rhode Island - RI",
                    "SC", "South Carolina - SC", "SD", "South Dakota - SD", "TN", "Tennessee - TN", "TX", "Texas - TX",
                    "UT", "Utah - UT", "VT", "Vermont - VT",
                    "VA", "Virginia - VA", "WA", "Washington - WA", "WV", "West Virginia - WV", "WI", "Wisconsin - WI",
                    "WY", "Wyoming - WY"
                };

                List<State> stateList = new List<State>();

                for (int i = 0; i < states.GetUpperBound(0); i += 2)
                {
                    stateList.Add(new State() { Name = states[i + 1], Abbreviation = states[i] });
                }
                _cacheProvider.Add(cacheKey, stateList, 1000);
                return stateList;
            }

        }
    }
}