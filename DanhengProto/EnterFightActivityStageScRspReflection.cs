using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200044C RID: 1100
	public static class EnterFightActivityStageScRspReflection
	{
		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x00086734 File Offset: 0x00084934
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterFightActivityStageScRspReflection.descriptor;
			}
		}

		// Token: 0x0400137C RID: 4988
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJFbnRlckZpZ2h0QWN0aXZpdHlTdGFnZVNjUnNwLnByb3RvGhVTY2VuZUJh",
			"dHRsZUluZm8ucHJvdG8ifQocRW50ZXJGaWdodEFjdGl2aXR5U3RhZ2VTY1Jz",
			"cBITCgtBSEZOR1BMREFJSRgFIAEoDRIlCgtiYXR0bGVfaW5mbxgPIAEoCzIQ",
			"LlNjZW5lQmF0dGxlSW5mbxIPCgdyZXRjb2RlGAwgASgNEhAKCGdyb3VwX2lk",
			"GAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterFightActivityStageScRsp), EnterFightActivityStageScRsp.Parser, new string[]
			{
				"AHFNGPLDAII",
				"BattleInfo",
				"Retcode",
				"GroupId"
			}, null, null, null, null)
		}));
	}
}
