using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000480 RID: 1152
	public static class EnterTrialActivityStageScRspReflection
	{
		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06003358 RID: 13144 RVA: 0x0008D1CA File Offset: 0x0008B3CA
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterTrialActivityStageScRspReflection.descriptor;
			}
		}

		// Token: 0x04001469 RID: 5225
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJFbnRlclRyaWFsQWN0aXZpdHlTdGFnZVNjUnNwLnByb3RvGhVTY2VuZUJh",
			"dHRsZUluZm8ucHJvdG8iVgocRW50ZXJUcmlhbEFjdGl2aXR5U3RhZ2VTY1Jz",
			"cBIlCgtiYXR0bGVfaW5mbxgMIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIPCgdy",
			"ZXRjb2RlGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterTrialActivityStageScRsp), EnterTrialActivityStageScRsp.Parser, new string[]
			{
				"BattleInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
