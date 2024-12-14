using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AEA RID: 2794
	public static class MissionSyncReflection
	{
		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x001477FD File Offset: 0x001459FD
		public static FileDescriptor Descriptor
		{
			get
			{
				return MissionSyncReflection.descriptor;
			}
		}

		// Token: 0x04002F80 RID: 12160
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFNaXNzaW9uU3luYy5wcm90bxoRT0JFUElIQUhNREYucHJvdG8aEUxGTklI",
			"T0hNTlBOLnByb3RvGg1NaXNzaW9uLnByb3RvItkBCgtNaXNzaW9uU3luYxIe",
			"CgxtaXNzaW9uX2xpc3QYByADKAsyCC5NaXNzaW9uEiEKC0VHS01GREFORExO",
			"GAQgAygLMgwuTEZOSUhPSE1OUE4SIQoLTEdHRktOR0dCSkQYCiADKAsyDC5P",
			"QkVQSUhBSE1ERhITCgtESk9CR0tERkxCSRgMIAMoDRITCgtFS09LRU5JQkxO",
			"RBgDIAMoDRIlCh1maW5pc2hlZF9tYWluX21pc3Npb25faWRfbGlzdBgFIAMo",
			"DRITCgtGSEpQR0tPS0lNUBgLIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			OBEPIHAHMDFReflection.Descriptor,
			LFNIHOHMNPNReflection.Descriptor,
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MissionSync), MissionSync.Parser, new string[]
			{
				"MissionList",
				"EGKMFDANDLN",
				"LGGFKNGGBJD",
				"DJOBGKDFLBI",
				"EKOKENIBLND",
				"FinishedMainMissionIdList",
				"FHJPGKOKIMP"
			}, null, null, null, null)
		}));
	}
}
