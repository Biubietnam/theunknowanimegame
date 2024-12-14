using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011DC RID: 4572
	public static class StartWolfBroGameCsReqReflection
	{
		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600CC67 RID: 52327 RVA: 0x002248B5 File Offset: 0x00222AB5
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartWolfBroGameCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400526A RID: 21098
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtTdGFydFdvbGZCcm9HYW1lQ3NSZXEucHJvdG8aFEdyb3VwU3RhdGVJbmZv",
			"LnByb3RvGhBNb3Rpb25JbmZvLnByb3RvIoABChVTdGFydFdvbGZCcm9HYW1l",
			"Q3NSZXESGwoGbW90aW9uGAogASgLMgsuTW90aW9uSW5mbxIKCgJpZBgEIAEo",
			"DRIpChBncm91cF9zdGF0ZV9pbmZvGAUgASgLMg8uR3JvdXBTdGF0ZUluZm8S",
			"EwoLSk1BUEVQR0xFTk4YCCABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			GroupStateInfoReflection.Descriptor,
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartWolfBroGameCsReq), StartWolfBroGameCsReq.Parser, new string[]
			{
				"Motion",
				"Id",
				"GroupStateInfo",
				"JMAPEPGLENN"
			}, null, null, null, null)
		}));
	}
}
