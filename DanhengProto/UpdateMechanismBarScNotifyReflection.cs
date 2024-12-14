using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013E0 RID: 5088
	public static class UpdateMechanismBarScNotifyReflection
	{
		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x0600E2E1 RID: 58081 RVA: 0x0025B883 File Offset: 0x00259A83
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateMechanismBarScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005A3C RID: 23100
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBVcGRhdGVNZWNoYW5pc21CYXJTY05vdGlmeS5wcm90bxoWTWVjaGFuaXNt",
			"QmFySW5mby5wcm90byJoChpVcGRhdGVNZWNoYW5pc21CYXJTY05vdGlmeRIQ",
			"CghwbGFuZV9pZBgNIAEoDRIQCghmbG9vcl9pZBgDIAEoDRImCgtFQU1OTElO",
			"SEdJSRgKIAEoCzIRLk1lY2hhbmlzbUJhckluZm9CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MechanismBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMechanismBarScNotify), UpdateMechanismBarScNotify.Parser, new string[]
			{
				"PlaneId",
				"FloorId",
				"EAMNLINHGII"
			}, null, null, null, null)
		}));
	}
}
