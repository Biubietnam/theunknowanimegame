using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200139C RID: 5020
	public static class TreasureDungeonRecordDataReflection
	{
		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x0600E02C RID: 57388 RVA: 0x00254FD9 File Offset: 0x002531D9
		public static FileDescriptor Descriptor
		{
			get
			{
				return TreasureDungeonRecordDataReflection.descriptor;
			}
		}

		// Token: 0x0400592D RID: 22829
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9UcmVhc3VyZUR1bmdlb25SZWNvcmREYXRhLnByb3RvGh9UcmVhc3VyZUR1",
			"bmdlb25SZWNvcmRUeXBlLnByb3RvIpEBChlUcmVhc3VyZUR1bmdlb25SZWNv",
			"cmREYXRhEg4KBlBhcmFtMRgKIAEoDRIUCgxTb3VyY2VHcmlkSWQYCCABKA0S",
			"FAoMVGFyZ2V0R3JpZElkGAsgASgNEg4KBlBhcmFtMhgFIAEoDRIoCgRUeXBl",
			"GA0gASgOMhouVHJlYXN1cmVEdW5nZW9uUmVjb3JkVHlwZUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			TreasureDungeonRecordTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TreasureDungeonRecordData), TreasureDungeonRecordData.Parser, new string[]
			{
				"Param1",
				"SourceGridId",
				"TargetGridId",
				"Param2",
				"Type"
			}, null, null, null, null)
		}));
	}
}
