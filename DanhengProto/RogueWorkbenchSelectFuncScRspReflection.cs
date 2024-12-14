using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200103C RID: 4156
	public static class RogueWorkbenchSelectFuncScRspReflection
	{
		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600B8E2 RID: 47330 RVA: 0x001F0531 File Offset: 0x001EE731
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchSelectFuncScRspReflection.descriptor;
			}
		}

		// Token: 0x04004AE6 RID: 19174
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNSb2d1ZVdvcmtiZW5jaFNlbGVjdEZ1bmNTY1JzcC5wcm90bxoXV29ya2Jl",
			"bmNoRnVuY0luZm8ucHJvdG8ieQodUm9ndWVXb3JrYmVuY2hTZWxlY3RGdW5j",
			"U2NSc3ASLAoQdGFyZ2V0X2Z1bmNfaW5mbxgHIAEoCzISLldvcmtiZW5jaEZ1",
			"bmNJbmZvEhkKEXdvcmtiZW5jaF9mdW5jX2lkGAkgASgNEg8KB3JldGNvZGUY",
			"BiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			WorkbenchFuncInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchSelectFuncScRsp), RogueWorkbenchSelectFuncScRsp.Parser, new string[]
			{
				"TargetFuncInfo",
				"WorkbenchFuncId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
