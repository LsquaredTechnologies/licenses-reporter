// <copyright file="Licenses.DefaultUrlsMapping.cs" company="Lsquared Technologies">
// Copyright © Lsquared Technologies
// SPDX-License-Identifier: MIT
// </copyright>

namespace Lsquared.DotnetTools.LicensesReporter.Core;

public static partial class Licenses
{
    public static IReadOnlyDictionary<string, string> DefaultUrlsMapping { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["https://licenses.nuget.org/Apache-1.0"] = APACHE_1_0,
        ["https://licenses.nuget.org/Apache-1.1"] = APACHE_1_1,
        ["https://licenses.nuget.org/Apache-2.0"] = APACHE_2_0,
        ["https://licenses.nuget.org/APL-1.0"] = APL_1_0,
        ["https://licenses.nuget.org/AGPL-1.0-only"] = AGPL_1_0_ONLY,
        ["https://licenses.nuget.org/AGPL-1.0-or-later"] = AGPL_1_0_OR_LATER,
        ["https://licenses.nuget.org/AGPL-3.0-only"] = AGPL_3_0_ONLY,
        ["https://licenses.nuget.org/AGPL-3.0-or-later"] = AGPL_3_0_OR_LATER,
        ["https://licenses.nuget.org/Beerware"] = BEERWARE,
        ["https://licenses.nuget.org/0BSDe"] = BSD_0,
        ["https://licenses.nuget.org/BSD-1-Clause"] = BSD_1,
        ["https://licenses.nuget.org/BSD-2-Clause"] = BSD_2,
        ["https://licenses.nuget.org/BSD-3-Clause"] = BSD_3,
        ["https://licenses.nuget.org/BSD 4-Clause"] = BSD_4,
        ["https://licenses.nuget.org/CDDL-1.0"] = CDDL_1_0,
        ["https://licenses.nuget.org/CDDL-1.1"] = CDDL_1_1,
        ["https://licenses.nuget.org/CDL-1.0"] = CDL_1_0,
        // TODO add CC-BY-* licenses
        ["https://licenses.nuget.org/GPL-2.0-only"] = GPL_2_0_ONLY,
        ["https://licenses.nuget.org/GPL-2.0-or-later"] = GPL_2_0_OR_LATER,
        ["https://licenses.nuget.org/GPL-3.0-only"] = GPL_3_0_ONLY,
        ["https://licenses.nuget.org/GPL-3.0-or-later"] = GPL_3_0_OR_LATER,
        ["https://licenses.nuget.org/ISC"] = ISC,
        ["https://licenses.nuget.org/LGPL-2.0-only"] = LGPL_2_0_ONLY,
        ["https://licenses.nuget.org/LGPL-2.0-or-later"] = LGPL_2_0_OR_LATER,
        ["https://licenses.nuget.org/LGPL-2.1-only"] = LGPL_2_1_ONLY,
        ["https://licenses.nuget.org/LGPL-2.1-or-later"] = LGPL_2_1_OR_LATER,
        ["https://licenses.nuget.org/LGPL-3.0-only"] = LGPL_3_0_ONLY,
        ["https://licenses.nuget.org/LGPL-3.0-or-later"] = LGPL_3_0_OR_LATER,
        ["https://licenses.nuget.org/MIT"] = MIT,
        ["https://licenses.nuget.org/MS-PL"] = MS_PL,
        ["https://licenses.nuget.org/MS-RL"] = MS_RL,
        ["https://licenses.nuget.org/MPL-1.0"] = MPL_1_0,
        ["https://licenses.nuget.org/MPL-1.1"] = MPL_1_1,
        ["https://licenses.nuget.org/MPL-2.0"] = MPL_2_0,
        ["https://licenses.nuget.org/ODbL-1.0"] = ODBL_1_0,
        ["https://licenses.nuget.org/OSL-1.0"] = OSL_1_0,
        ["https://licenses.nuget.org/OSL-1.1"] = OSL_1_1,
        ["https://licenses.nuget.org/OSL-2.0"] = OSL_2_0,
        ["https://licenses.nuget.org/OSL-2.1"] = OSL_2_1,
        ["https://licenses.nuget.org/OSL-3.0"] = OSL_3_0,
        ["https://licenses.nuget.org/OpenSSL"] = OPENSSL,
        ["https://licenses.nuget.org/Unlicense"] = UNLICENSE,
        ["https://licenses.nuget.org/X11"] = X11,
        ["https://licenses.nuget.org/Zlib"] = ZLIB,

        ["https://opensource.org/license/apache-1-1"] = APACHE_1_1,
        ["https://opensource.org/license/apache-2-0"] = APACHE_2_0,
        ["https://opensource.org/license/agpl-v3"] = AGPL_3_0_ONLY,
        ["https://opensource.org/license/0BSD"] = BSD_0,
        ["https://opensource.org/licenses/BSD-1-Clause"] = BSD_1,
        ["https://opensource.org/licenses/BSD-2-Clause"] = BSD_2,
        ["https://opensource.org/licenses/BSD-3-Clause"] = BSD_3,
        ["https://opensource.org/license/gpl-1-0"] = GPL_1_0_OR_LATER,
        ["https://opensource.org/license/gpl-2-0"] = GPL_2_0_OR_LATER,
        ["https://opensource.org/license/gpl-3-0"] = GPL_3_0_OR_LATER,
        ["https://opensource.org/license/icu-license"] = ICU,
        ["https://opensource.org/license/isc-license-txt"] = ISC,
        ["https://opensource.org/license/lgpl-2-0"] = LGPL_2_0_OR_LATER,
        ["https://opensource.org/license/lgpl-2-1"] = LGPL_2_1_OR_LATER,
        ["https://opensource.org/license/lgpl-3-0"] = LGPL_3_0_OR_LATER,
        ["https://opensource.org/license/mit"] = MIT,
        ["https://opensource.org/license/ms-pl-html"] = MS_PL,
        ["https://opensource.org/license/ms-rl-html"] = MS_RL,
        ["https://opensource.org/license/mpl-1-0"] = MPL_1_0,
        ["https://opensource.org/license/mpl-1-1"] = MPL_1_1,
        ["https://opensource.org/license/mpl-2-0"] = MPL_2_0,
        ["https://opensource.org/license/osl-1-0"] = OSL_1_0,
        ["https://opensource.org/license/osl-1-1"] = OSL_1_1,
        ["https://opensource.org/license/osl-2-0"] = OSL_2_0,
        ["https://opensource.org/license/osl-2-1"] = OSL_2_1,
        ["https://opensource.org/license/osl-3-0"] = OSL_3_0,
        ["https://opensource.org/license/Unlicense"] = UNLICENSE,
        ["https://opensource.org/license/zlib"] = ZLIB,

        ["https://spdx.org/licenses/Apache-1.0.html"] = APACHE_1_0,
        ["https://spdx.org/licenses/Apache-1.1.html"] = APACHE_1_1,
        ["https://spdx.org/licenses/Apache-2.0.html"] = APACHE_2_0,
        ["https://spdx.org/licenses/APL-1.0.html"] = APL_1_0,
        ["https://spdx.org/licenses/AGPL-1.0-only.html"] = AGPL_1_0_ONLY,
        ["https://spdx.org/licenses/AGPL-1.0-or-later.html"] = AGPL_1_0_OR_LATER,
        ["https://spdx.org/licenses/AGPL-3.0-only.html"] = AGPL_3_0_ONLY,
        ["https://spdx.org/licenses/AGPL-3.0-or-later.html"] = AGPL_3_0_OR_LATER,
        ["https://spdx.org/licenses/Beerware.html"] = BEERWARE,
        ["https://spdx.org/licenses/0BSD.html"] = BSD_0,
        ["https://spdx.org/licenses/BSD-1-Clause.html"] = BSD_1,
        ["https://spdx.org/licenses/BSD-2-Clause.html"] = BSD_2,
        ["https://spdx.org/licenses/BSD-3-Clause.html"] = BSD_3,
        ["https://spdx.org/licenses/BSD-4-Clause.html"] = BSD_4,
        ["https://spdx.org/licenses/CDDL-1.0.html"] = CDDL_1_0,
        ["https://spdx.org/licenses/CDDL-1.1.html"] = CDDL_1_1,
        // TODO add CC-BY-* licenses
        ["https://spdx.org/licenses/curl.html"] = CURL,
        ["https://spdx.org/licenses/GPL-1.0-only.html"] = GPL_1_0_ONLY,
        ["https://spdx.org/licenses/GPL-1.0-or-later.html"] = GPL_1_0_OR_LATER,
        ["https://spdx.org/licenses/GPL-2.0-only.html"] = GPL_2_0_ONLY,
        ["https://spdx.org/licenses/GPL-2.0-or-later.html"] = GPL_2_0_OR_LATER,
        ["https://spdx.org/licenses/GPL-3.0-only.html"] = GPL_3_0_ONLY,
        ["https://spdx.org/licenses/GPL-3.0-or-later.html"] = GPL_3_0_OR_LATER,
        ["https://spdx.org/licenses/ICU.html"] = ICU,
        ["https://spdx.org/licenses/Info-ZIP.html"] = INFO_ZIP,
        ["https://spdx.org/licenses/ISC.html"] = ISC,
        ["https://spdx.org/licenses/JSON.html"] = JSON,
        ["https://spdx.org/licenses/LGPL-2.0-only.html"] = LGPL_2_0_ONLY,
        ["https://spdx.org/licenses/LGPL-2.0-or-later.html"] = LGPL_2_0_OR_LATER,
        ["https://spdx.org/licenses/LGPL-2.1-only.html"] = LGPL_2_1_ONLY,
        ["https://spdx.org/licenses/LGPL-2.1-or-later.html"] = LGPL_2_1_OR_LATER,
        ["https://spdx.org/licenses/LGPL-3.0-only.html"] = LGPL_3_0_ONLY,
        ["https://spdx.org/licenses/LGPL-3.0-or-later.html"] = LGPL_3_0_OR_LATER,
        ["https://spdx.org/licenses/MIT.html"] = MIT,
        ["https://spdx.org/licenses/MS-LPL.html"] = MS_LPL,
        ["https://spdx.org/licenses/MS-PL.html"] = MS_PL,
        ["https://spdx.org/licenses/MS-RL.html"] = MS_RL,
        ["https://spdx.org/licenses/MPL-1.0.html"] = MPL_1_0,
        ["https://spdx.org/licenses/MPL-1.1.html"] = MPL_1_1,
        ["https://spdx.org/licenses/MPL-2.0.html"] = MPL_2_0,
        ["https://spdx.org/licenses/ODbL-1.0.html"] = ODBL_1_0,
        ["https://spdx.org/licenses/OSL-1.0.html"] = OSL_1_0,
        ["https://spdx.org/licenses/OSL-1.1.html"] = OSL_1_1,
        ["https://spdx.org/licenses/OSL-2.0.html"] = OSL_2_0,
        ["https://spdx.org/licenses/OSL-2.1.html"] = OSL_2_1,
        ["https://spdx.org/licenses/OSL-3.0.html"] = OSL_3_0,
        ["https://spdx.org/licenses/OpenSSL.html"] = OPENSSL,
        ["https://spdx.org/licenses/Unlicense.html"] = UNLICENSE,
        ["https://spdx.org/licenses/X11.html"] = X11,
        ["https://spdx.org/licenses/Zlib.html"] = ZLIB,

        ["http://www.apache.org/licenses/LICENSE-1.0"] = APACHE_1_0,
        ["http://www.apache.org/licenses/LICENSE-1.1"] = APACHE_1_1,
        ["https://www.apache.org/licenses/LICENSE-2.0"] = APACHE_2_0,
        ["https://www.gnu.org/licenses/agpl.txt"] = AGPL_3_0_OR_LATER,
        ["https://www.gnu.org/licenses/agpl-3.0.txt"] = AGPL_3_0_OR_LATER,
        ["https://fedoraproject.org/wiki/Licensing/Beerware"] = BEERWARE,
        ["https://directory.fsf.org/wiki/License:BSD-4-Clause"] = BSD_4,
        ["https://www.gnu.org/licenses/gpl-3.0.txt"] = GPL_3_0_OR_LATER,
        ["http://source.icu-project.org/repos/icu/icu/trunk/license.html"] = ICU,
        ["https://home.unicode.org/basic-info/projects/#/icu/icu/trunk/license.html"] = ICU,
        ["http://www.info-zip.org/license.html"] = INFO_ZIP,
        ["https://infozip.sourceforge.net/license.html"] = INFO_ZIP,
        // TODO add more licenses...
    };
}
