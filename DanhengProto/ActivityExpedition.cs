using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000035 RID: 53
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivityExpedition : IMessage<ActivityExpedition>, IMessage, IEquatable<ActivityExpedition>, IDeepCloneable<ActivityExpedition>, IBufferMessage
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00006A47 File Offset: 0x00004C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityExpedition> Parser
		{
			get
			{
				return ActivityExpedition._parser;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00006A4E File Offset: 0x00004C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ActivityExpeditionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00006A60 File Offset: 0x00004C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityExpedition.Descriptor;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00006A67 File Offset: 0x00004C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityExpedition()
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00006A7C File Offset: 0x00004C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityExpedition(ActivityExpedition other) : this()
		{
			this.id_ = other.id_;
			this.lAOJBOCIEHN_ = other.lAOJBOCIEHN_;
			this.bPMJPELFJBK_ = other.bPMJPELFJBK_;
			this.pHOGEMPLHLN_ = other.pHOGEMPLHLN_;
			this.oFLKHCBDCAJ_ = other.oFLKHCBDCAJ_;
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00006AED File Offset: 0x00004CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityExpedition Clone()
		{
			return new ActivityExpedition(this);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00006AF5 File Offset: 0x00004CF5
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00006AFD File Offset: 0x00004CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00006B06 File Offset: 0x00004D06
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00006B0E File Offset: 0x00004D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LAOJBOCIEHN
		{
			get
			{
				return this.lAOJBOCIEHN_;
			}
			set
			{
				this.lAOJBOCIEHN_ = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00006B17 File Offset: 0x00004D17
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00006B1F File Offset: 0x00004D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BPMJPELFJBK
		{
			get
			{
				return this.bPMJPELFJBK_;
			}
			set
			{
				this.bPMJPELFJBK_ = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00006B28 File Offset: 0x00004D28
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00006B30 File Offset: 0x00004D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHOGEMPLHLN
		{
			get
			{
				return this.pHOGEMPLHLN_;
			}
			set
			{
				this.pHOGEMPLHLN_ = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00006B39 File Offset: 0x00004D39
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00006B41 File Offset: 0x00004D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OFLKHCBDCAJ
		{
			get
			{
				return this.oFLKHCBDCAJ_;
			}
			set
			{
				this.oFLKHCBDCAJ_ = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00006B4A File Offset: 0x00004D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00006B52 File Offset: 0x00004D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityExpedition);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00006B60 File Offset: 0x00004D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityExpedition other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LAOJBOCIEHN == other.LAOJBOCIEHN && this.BPMJPELFJBK == other.BPMJPELFJBK && this.PHOGEMPLHLN == other.PHOGEMPLHLN && this.OFLKHCBDCAJ == other.OFLKHCBDCAJ && this.avatarIdList_.Equals(other.avatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00006BF0 File Offset: 0x00004DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LAOJBOCIEHN != 0U)
			{
				num ^= this.LAOJBOCIEHN.GetHashCode();
			}
			if (this.BPMJPELFJBK != 0U)
			{
				num ^= this.BPMJPELFJBK.GetHashCode();
			}
			if (this.PHOGEMPLHLN != 0U)
			{
				num ^= this.PHOGEMPLHLN.GetHashCode();
			}
			if (this.OFLKHCBDCAJ != 0L)
			{
				num ^= this.OFLKHCBDCAJ.GetHashCode();
			}
			num ^= this.avatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00006CA1 File Offset: 0x00004EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00006CA9 File Offset: 0x00004EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00006CB4 File Offset: 0x00004EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LAOJBOCIEHN != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LAOJBOCIEHN);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Id);
			}
			if (this.PHOGEMPLHLN != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.PHOGEMPLHLN);
			}
			if (this.OFLKHCBDCAJ != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.OFLKHCBDCAJ);
			}
			if (this.BPMJPELFJBK != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.BPMJPELFJBK);
			}
			this.avatarIdList_.WriteTo(ref output, ActivityExpedition._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00006D74 File Offset: 0x00004F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.LAOJBOCIEHN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LAOJBOCIEHN);
			}
			if (this.BPMJPELFJBK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BPMJPELFJBK);
			}
			if (this.PHOGEMPLHLN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHOGEMPLHLN);
			}
			if (this.OFLKHCBDCAJ != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OFLKHCBDCAJ);
			}
			num += this.avatarIdList_.CalculateSize(ActivityExpedition._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00006E28 File Offset: 0x00005028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityExpedition other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.LAOJBOCIEHN != 0U)
			{
				this.LAOJBOCIEHN = other.LAOJBOCIEHN;
			}
			if (other.BPMJPELFJBK != 0U)
			{
				this.BPMJPELFJBK = other.BPMJPELFJBK;
			}
			if (other.PHOGEMPLHLN != 0U)
			{
				this.PHOGEMPLHLN = other.PHOGEMPLHLN;
			}
			if (other.OFLKHCBDCAJ != 0L)
			{
				this.OFLKHCBDCAJ = other.OFLKHCBDCAJ;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00006EC5 File Offset: 0x000050C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00006ED0 File Offset: 0x000050D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.LAOJBOCIEHN = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PHOGEMPLHLN = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 112U)
				{
					if (num == 104U)
					{
						this.OFLKHCBDCAJ = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.BPMJPELFJBK = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.avatarIdList_.AddEntriesFrom(ref input, ActivityExpedition._repeated_avatarIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000AE RID: 174
		private static readonly MessageParser<ActivityExpedition> _parser = new MessageParser<ActivityExpedition>(() => new ActivityExpedition());

		// Token: 0x040000AF RID: 175
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000B0 RID: 176
		public const int IdFieldNumber = 6;

		// Token: 0x040000B1 RID: 177
		private uint id_;

		// Token: 0x040000B2 RID: 178
		public const int LAOJBOCIEHNFieldNumber = 3;

		// Token: 0x040000B3 RID: 179
		private uint lAOJBOCIEHN_;

		// Token: 0x040000B4 RID: 180
		public const int BPMJPELFJBKFieldNumber = 14;

		// Token: 0x040000B5 RID: 181
		private uint bPMJPELFJBK_;

		// Token: 0x040000B6 RID: 182
		public const int PHOGEMPLHLNFieldNumber = 7;

		// Token: 0x040000B7 RID: 183
		private uint pHOGEMPLHLN_;

		// Token: 0x040000B8 RID: 184
		public const int OFLKHCBDCAJFieldNumber = 13;

		// Token: 0x040000B9 RID: 185
		private long oFLKHCBDCAJ_;

		// Token: 0x040000BA RID: 186
		public const int AvatarIdListFieldNumber = 15;

		// Token: 0x040000BB RID: 187
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x040000BC RID: 188
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();
	}
}
