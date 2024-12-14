using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001038 RID: 4152
	public static class RogueWorkbenchHandleFuncScRspReflection
	{
		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600B8B2 RID: 47282 RVA: 0x001EFD9B File Offset: 0x001EDF9B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchHandleFuncScRspReflection.descriptor;
			}
		}

		// Token: 0x04004AD6 RID: 19158
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNSb2d1ZVdvcmtiZW5jaEhhbmRsZUZ1bmNTY1JzcC5wcm90bxoXV29ya2Jl",
			"bmNoRnVuY0luZm8ucHJvdG8ieQodUm9ndWVXb3JrYmVuY2hIYW5kbGVGdW5j",
			"U2NSc3ASDwoHcmV0Y29kZRgGIAEoDRIsChB0YXJnZXRfZnVuY19pbmZvGAkg",
			"ASgLMhIuV29ya2JlbmNoRnVuY0luZm8SGQoRd29ya2JlbmNoX2Z1bmNfaWQY",
			"DSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			WorkbenchFuncInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchHandleFuncScRsp), RogueWorkbenchHandleFuncScRsp.Parser, new string[]
			{
				"Retcode",
				"TargetFuncInfo",
				"WorkbenchFuncId"
			}, null, null, null, null)
		}));
	}
}
