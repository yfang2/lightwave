﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VmDirInterop.Schema;
using VmDirInterop.Schema.Entries;

//TODO - This file is for testing purposes to provide a mock server with test data. Will be removed.
namespace SchemaConnectionTest.Mocks
{
    public class SchemaConnTestData
    {
        public String HostName { get; set; }

        public Boolean Reachable { get; set; }

        public DseRootEntry DseRootEntry { get; set; }

        public IDictionary<String, ServerEntry> ServerEntries { get; set; }

        public SubSchemaSubEntry SubSchemaSubEntry { get; set; }

        public SchemaComparableList<SchemaEntry> AttributeSchemaEntries { get; set; }

        public SchemaComparableList<SchemaEntry> ClassSchemaEntries { get; set; }
    }
}
