// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.NetAppFiles.Test.ScenarioTests.ScenarioTest
{
    public class AccountTests : NetAppFilesTestRunner
    {
        public AccountTests(Xunit.Abstractions.ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAccountCrud()
        {
            TestRunner.RunTestScript("Test-AccountCrud");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAccountActiveDirectory()
        {
            TestRunner.RunTestScript("Test-AccountActiveDirectory");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAccountPipelines()
        {
            TestRunner.RunTestScript("Test-AccountPipelines");
        }

        [Fact]
        //[Fact(Skip = "Doesn't work at the moment due to service side issue, un-skip when it is working again")]
        [Trait(Category.AcceptanceType, Category.LiveOnly)]        
        public void TestAccountCMK()
        {
            TestRunner.RunTestScript("Test-AccountCMK");
        }
    }
}
