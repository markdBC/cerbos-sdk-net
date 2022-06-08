// Copyright 2021-2022 Zenauth Ltd.
// SPDX-License-Identifier: Apache-2.0

namespace Cerbos.Sdk.Builders
{
    public class AuxData
    {
        private Cerbos.Api.V1.Request.AuxData A { get; }

        private AuxData() {
            A = new Cerbos.Api.V1.Request.AuxData();
        }
        
        public static AuxData NewInstance() {
            return new AuxData();
        }
        
        public static AuxData WithJwt(string token) {
            AuxData auxData = NewInstance();
            auxData.A.Jwt.Token = token;
            return auxData;
        }
        
        public static AuxData WithJwt(string token, string keySetId) {
            AuxData auxData = NewInstance();
            auxData.A.Jwt.Token = token;
            auxData.A.Jwt.KeySetId = keySetId;
            return auxData;
        }

        public Cerbos.Api.V1.Request.AuxData ToAuxData()
        {
            return A;
        }
    }
}