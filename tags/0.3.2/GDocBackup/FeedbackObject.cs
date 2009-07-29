/*
   Copyright 2009  Fabrizio Accatino

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/



using System;
using System.Collections.Generic;
using System.Text;

namespace GDocBackup
{
    /// <summary>
    /// Contains more feedback information about documents/folders
    /// </summary>
    public class FeedbackObject
    {
        public string FileName;
        public string DocType;
        public string Action;
        public string Folder;
        public DateTime? LocalDateTime;
        public DateTime? RemoteDateTime;

        public FeedbackObject(
            string fileName, string docType, string action, string folder,
            DateTime? localDateTime, DateTime? remoteDateTime)
        {
            FileName = fileName;
            DocType = docType;
            Action = action;
            Folder = folder;
            LocalDateTime = localDateTime;
            RemoteDateTime = remoteDateTime;
        }

        public override string ToString()
        {
            return "FN=" + FileName + " DT=" + DocType + " Act=" + Action + 
                " FLD=" + Folder + " LDT=" + LocalDateTime + " RDT=" + RemoteDateTime;
        }
    }
}