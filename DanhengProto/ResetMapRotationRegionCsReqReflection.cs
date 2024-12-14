using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DC8 RID: 3528
	public static class ResetMapRotationRegionCsReqReflection
	{
		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x06009DC7 RID: 40391 RVA: 0x001A44A5 File Offset: 0x001A26A5
		public static FileDescriptor Descriptor
		{
			get
			{
				return ResetMapRotationRegionCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003D58 RID: 15704
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSZXNldE1hcFJvdGF0aW9uUmVnaW9uQ3NSZXEucHJvdG8aEE1vdGlvbklu",
			"Zm8ucHJvdG8aEUhNQkxJQUROS0VPLnByb3RvIloKG1Jlc2V0TWFwUm90YXRp",
			"b25SZWdpb25Dc1JlcRIeCghyb29tX21hcBgJIAEoCzIMLkhNQkxJQUROS0VP",
			"EhsKBm1vdGlvbhgHIAEoCzILLk1vdGlvbkluZm9CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor,
			HMBLIADNKEOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ResetMapRotationRegionCsReq), ResetMapRotationRegionCsReq.Parser, new string[]
			{
				"RoomMap",
				"Motion"
			}, null, null, null, null)
		}));
	}
}
