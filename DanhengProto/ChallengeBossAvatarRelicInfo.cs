using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000191 RID: 401
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossAvatarRelicInfo : IMessage<ChallengeBossAvatarRelicInfo>, IMessage, IEquatable<ChallengeBossAvatarRelicInfo>, IDeepCloneable<ChallengeBossAvatarRelicInfo>, IBufferMessage
	{
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x00033AA4 File Offset: 0x00031CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossAvatarRelicInfo> Parser
		{
			get
			{
				return ChallengeBossAvatarRelicInfo._parser;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00033AAB File Offset: 0x00031CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossAvatarRelicInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x00033ABD File Offset: 0x00031CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossAvatarRelicInfo.Descriptor;
			}
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00033AC4 File Offset: 0x00031CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossAvatarRelicInfo()
		{
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00033AD7 File Offset: 0x00031CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossAvatarRelicInfo(ChallengeBossAvatarRelicInfo other) : this()
		{
			this.avatarRelicSlotMap_ = other.avatarRelicSlotMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00033B01 File Offset: 0x00031D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossAvatarRelicInfo Clone()
		{
			return new ChallengeBossAvatarRelicInfo(this);
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00033B09 File Offset: 0x00031D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, ChallengeBossRelicInfo> AvatarRelicSlotMap
		{
			get
			{
				return this.avatarRelicSlotMap_;
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00033B11 File Offset: 0x00031D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossAvatarRelicInfo);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00033B1F File Offset: 0x00031D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossAvatarRelicInfo other)
		{
			return other != null && (other == this || (this.AvatarRelicSlotMap.Equals(other.AvatarRelicSlotMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00033B54 File Offset: 0x00031D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.AvatarRelicSlotMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00033B88 File Offset: 0x00031D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00033B90 File Offset: 0x00031D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00033B99 File Offset: 0x00031D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarRelicSlotMap_.WriteTo(ref output, ChallengeBossAvatarRelicInfo._map_avatarRelicSlotMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00033BC0 File Offset: 0x00031DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarRelicSlotMap_.CalculateSize(ChallengeBossAvatarRelicInfo._map_avatarRelicSlotMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00033BF9 File Offset: 0x00031DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossAvatarRelicInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarRelicSlotMap_.MergeFrom(other.avatarRelicSlotMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00033C27 File Offset: 0x00031E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00033C30 File Offset: 0x00031E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.avatarRelicSlotMap_.AddEntriesFrom(ref input, ChallengeBossAvatarRelicInfo._map_avatarRelicSlotMap_codec);
				}
			}
		}

		// Token: 0x04000788 RID: 1928
		private static readonly MessageParser<ChallengeBossAvatarRelicInfo> _parser = new MessageParser<ChallengeBossAvatarRelicInfo>(() => new ChallengeBossAvatarRelicInfo());

		// Token: 0x04000789 RID: 1929
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400078A RID: 1930
		public const int AvatarRelicSlotMapFieldNumber = 4;

		// Token: 0x0400078B RID: 1931
		private static readonly MapField<uint, ChallengeBossRelicInfo>.Codec _map_avatarRelicSlotMap_codec = new MapField<uint, ChallengeBossRelicInfo>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<ChallengeBossRelicInfo>(18U, ChallengeBossRelicInfo.Parser), 34U);

		// Token: 0x0400078C RID: 1932
		private readonly MapField<uint, ChallengeBossRelicInfo> avatarRelicSlotMap_ = new MapField<uint, ChallengeBossRelicInfo>();
	}
}
