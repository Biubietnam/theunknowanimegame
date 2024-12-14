using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F11 RID: 3857
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterTakeOffUnitCsReq : IMessage<RogueMagicScepterTakeOffUnitCsReq>, IMessage, IEquatable<RogueMagicScepterTakeOffUnitCsReq>, IDeepCloneable<RogueMagicScepterTakeOffUnitCsReq>, IBufferMessage
	{
		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0600AC2E RID: 44078 RVA: 0x001CF7AD File Offset: 0x001CD9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterTakeOffUnitCsReq> Parser
		{
			get
			{
				return RogueMagicScepterTakeOffUnitCsReq._parser;
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0600AC2F RID: 44079 RVA: 0x001CF7B4 File Offset: 0x001CD9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterTakeOffUnitCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0600AC30 RID: 44080 RVA: 0x001CF7C6 File Offset: 0x001CD9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterTakeOffUnitCsReq.Descriptor;
			}
		}

		// Token: 0x0600AC31 RID: 44081 RVA: 0x001CF7CD File Offset: 0x001CD9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterTakeOffUnitCsReq()
		{
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x001CF7E0 File Offset: 0x001CD9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterTakeOffUnitCsReq(RogueMagicScepterTakeOffUnitCsReq other) : this()
		{
			this.scepterId_ = other.scepterId_;
			this.magicUnitIdList_ = other.magicUnitIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x001CF816 File Offset: 0x001CDA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterTakeOffUnitCsReq Clone()
		{
			return new RogueMagicScepterTakeOffUnitCsReq(this);
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0600AC34 RID: 44084 RVA: 0x001CF81E File Offset: 0x001CDA1E
		// (set) Token: 0x0600AC35 RID: 44085 RVA: 0x001CF826 File Offset: 0x001CDA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScepterId
		{
			get
			{
				return this.scepterId_;
			}
			set
			{
				this.scepterId_ = value;
			}
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0600AC36 RID: 44086 RVA: 0x001CF82F File Offset: 0x001CDA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MagicUnitIdList
		{
			get
			{
				return this.magicUnitIdList_;
			}
		}

		// Token: 0x0600AC37 RID: 44087 RVA: 0x001CF837 File Offset: 0x001CDA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterTakeOffUnitCsReq);
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x001CF848 File Offset: 0x001CDA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterTakeOffUnitCsReq other)
		{
			return other != null && (other == this || (this.ScepterId == other.ScepterId && this.magicUnitIdList_.Equals(other.magicUnitIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC39 RID: 44089 RVA: 0x001CF898 File Offset: 0x001CDA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScepterId != 0U)
			{
				num ^= this.ScepterId.GetHashCode();
			}
			num ^= this.magicUnitIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x001CF8E5 File Offset: 0x001CDAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x001CF8ED File Offset: 0x001CDAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x001CF8F8 File Offset: 0x001CDAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScepterId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ScepterId);
			}
			this.magicUnitIdList_.WriteTo(ref output, RogueMagicScepterTakeOffUnitCsReq._repeated_magicUnitIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x001CF948 File Offset: 0x001CDB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScepterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScepterId);
			}
			num += this.magicUnitIdList_.CalculateSize(RogueMagicScepterTakeOffUnitCsReq._repeated_magicUnitIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x001CF99C File Offset: 0x001CDB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterTakeOffUnitCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScepterId != 0U)
			{
				this.ScepterId = other.ScepterId;
			}
			this.magicUnitIdList_.Add(other.magicUnitIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x001CF9E9 File Offset: 0x001CDBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x001CF9F4 File Offset: 0x001CDBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.magicUnitIdList_.AddEntriesFrom(ref input, RogueMagicScepterTakeOffUnitCsReq._repeated_magicUnitIdList_codec);
					}
				}
				else
				{
					this.ScepterId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004632 RID: 17970
		private static readonly MessageParser<RogueMagicScepterTakeOffUnitCsReq> _parser = new MessageParser<RogueMagicScepterTakeOffUnitCsReq>(() => new RogueMagicScepterTakeOffUnitCsReq());

		// Token: 0x04004633 RID: 17971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004634 RID: 17972
		public const int ScepterIdFieldNumber = 11;

		// Token: 0x04004635 RID: 17973
		private uint scepterId_;

		// Token: 0x04004636 RID: 17974
		public const int MagicUnitIdListFieldNumber = 12;

		// Token: 0x04004637 RID: 17975
		private static readonly FieldCodec<uint> _repeated_magicUnitIdList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04004638 RID: 17976
		private readonly RepeatedField<uint> magicUnitIdList_ = new RepeatedField<uint>();
	}
}
