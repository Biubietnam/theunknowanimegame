using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001438 RID: 5176
	public static class WorkbenchEnhanceBuffFuncInfoReflection
	{
		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x0600E6F3 RID: 59123 RVA: 0x00265C58 File Offset: 0x00263E58
		public static FileDescriptor Descriptor
		{
			get
			{
				return WorkbenchEnhanceBuffFuncInfoReflection.descriptor;
			}
		}

		// Token: 0x04005BA2 RID: 23458
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJXb3JrYmVuY2hFbmhhbmNlQnVmZkZ1bmNJbmZvLnByb3RvItEBChxXb3Jr",
			"YmVuY2hFbmhhbmNlQnVmZkZ1bmNJbmZvElQKFWJ1ZmZfZW5oYW5jZV9jb3N0",
			"X21hcBgEIAMoCzI1LldvcmtiZW5jaEVuaGFuY2VCdWZmRnVuY0luZm8uQnVm",
			"ZkVuaGFuY2VDb3N0TWFwRW50cnkSDwoHY3VyX251bRgLIAEoDRIPCgdtYXhf",
			"bnVtGAIgASgNGjkKF0J1ZmZFbmhhbmNlQ29zdE1hcEVudHJ5EgsKA2tleRgB",
			"IAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WorkbenchEnhanceBuffFuncInfo), WorkbenchEnhanceBuffFuncInfo.Parser, new string[]
			{
				"BuffEnhanceCostMap",
				"CurNum",
				"MaxNum"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
