using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004B2 RID: 1202
	public static class EvolveBuildQueryInfoScRspReflection
	{
		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x0009402E File Offset: 0x0009222E
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildQueryInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x0400156E RID: 5486
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Fdm9sdmVCdWlsZFF1ZXJ5SW5mb1NjUnNwLnByb3RvGhFLQkJNTlBDTkhN",
			"Ty5wcm90bxoaRXZvbHZlQnVpbGRMZXZlbEluZm8ucHJvdG8igQEKGUV2b2x2",
			"ZUJ1aWxkUXVlcnlJbmZvU2NSc3ASKQoKbGV2ZWxfaW5mbxgEIAEoCzIVLkV2",
			"b2x2ZUJ1aWxkTGV2ZWxJbmZvEigKEnJvZ3VlX2N1cnJlbnRfaW5mbxgHIAEo",
			"CzIMLktCQk1OUENOSE1PEg8KB3JldGNvZGUYDSABKA1CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			KBBMNPCNHMOReflection.Descriptor,
			EvolveBuildLevelInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildQueryInfoScRsp), EvolveBuildQueryInfoScRsp.Parser, new string[]
			{
				"LevelInfo",
				"RogueCurrentInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
