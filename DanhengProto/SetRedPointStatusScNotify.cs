using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001125 RID: 4389
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetRedPointStatusScNotify : IMessage<SetRedPointStatusScNotify>, IMessage, IEquatable<SetRedPointStatusScNotify>, IDeepCloneable<SetRedPointStatusScNotify>, IBufferMessage
	{
		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600C3B7 RID: 50103 RVA: 0x0020D463 File Offset: 0x0020B663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetRedPointStatusScNotify> Parser
		{
			get
			{
				return SetRedPointStatusScNotify._parser;
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600C3B8 RID: 50104 RVA: 0x0020D46A File Offset: 0x0020B66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetRedPointStatusScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600C3B9 RID: 50105 RVA: 0x0020D47C File Offset: 0x0020B67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetRedPointStatusScNotify.Descriptor;
			}
		}

		// Token: 0x0600C3BA RID: 50106 RVA: 0x0020D483 File Offset: 0x0020B683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRedPointStatusScNotify()
		{
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x0020D498 File Offset: 0x0020B698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRedPointStatusScNotify(SetRedPointStatusScNotify other) : this()
		{
			this.contentId_ = other.contentId_;
			this.uid_ = other.uid_;
			this.oMOKDOPAIHG_ = other.oMOKDOPAIHG_.Clone();
			this.iBMPGMBHHPP_ = other.iBMPGMBHHPP_;
			this.aEDDEMIGDGB_ = other.aEDDEMIGDGB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x0020D4FD File Offset: 0x0020B6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRedPointStatusScNotify Clone()
		{
			return new SetRedPointStatusScNotify(this);
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600C3BD RID: 50109 RVA: 0x0020D505 File Offset: 0x0020B705
		// (set) Token: 0x0600C3BE RID: 50110 RVA: 0x0020D50D File Offset: 0x0020B70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600C3BF RID: 50111 RVA: 0x0020D516 File Offset: 0x0020B716
		// (set) Token: 0x0600C3C0 RID: 50112 RVA: 0x0020D51E File Offset: 0x0020B71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600C3C1 RID: 50113 RVA: 0x0020D527 File Offset: 0x0020B727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DJPHMOJGKCO> OMOKDOPAIHG
		{
			get
			{
				return this.oMOKDOPAIHG_;
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600C3C2 RID: 50114 RVA: 0x0020D52F File Offset: 0x0020B72F
		// (set) Token: 0x0600C3C3 RID: 50115 RVA: 0x0020D537 File Offset: 0x0020B737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IBMPGMBHHPP
		{
			get
			{
				return this.iBMPGMBHHPP_;
			}
			set
			{
				this.iBMPGMBHHPP_ = value;
			}
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600C3C4 RID: 50116 RVA: 0x0020D540 File Offset: 0x0020B740
		// (set) Token: 0x0600C3C5 RID: 50117 RVA: 0x0020D548 File Offset: 0x0020B748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AEDDEMIGDGB
		{
			get
			{
				return this.aEDDEMIGDGB_;
			}
			set
			{
				this.aEDDEMIGDGB_ = value;
			}
		}

		// Token: 0x0600C3C6 RID: 50118 RVA: 0x0020D551 File Offset: 0x0020B751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetRedPointStatusScNotify);
		}

		// Token: 0x0600C3C7 RID: 50119 RVA: 0x0020D560 File Offset: 0x0020B760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetRedPointStatusScNotify other)
		{
			return other != null && (other == this || (this.ContentId == other.ContentId && this.Uid == other.Uid && this.oMOKDOPAIHG_.Equals(other.oMOKDOPAIHG_) && this.IBMPGMBHHPP == other.IBMPGMBHHPP && this.AEDDEMIGDGB == other.AEDDEMIGDGB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3C8 RID: 50120 RVA: 0x0020D5E0 File Offset: 0x0020B7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			num ^= this.oMOKDOPAIHG_.GetHashCode();
			if (this.IBMPGMBHHPP != 0U)
			{
				num ^= this.IBMPGMBHHPP.GetHashCode();
			}
			if (this.AEDDEMIGDGB != 0U)
			{
				num ^= this.AEDDEMIGDGB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3C9 RID: 50121 RVA: 0x0020D678 File Offset: 0x0020B878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C3CA RID: 50122 RVA: 0x0020D680 File Offset: 0x0020B880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3CB RID: 50123 RVA: 0x0020D68C File Offset: 0x0020B88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IBMPGMBHHPP != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.IBMPGMBHHPP);
			}
			if (this.AEDDEMIGDGB != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AEDDEMIGDGB);
			}
			this.oMOKDOPAIHG_.WriteTo(ref output, SetRedPointStatusScNotify._repeated_oMOKDOPAIHG_codec);
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ContentId);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3CC RID: 50124 RVA: 0x0020D730 File Offset: 0x0020B930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			num += this.oMOKDOPAIHG_.CalculateSize(SetRedPointStatusScNotify._repeated_oMOKDOPAIHG_codec);
			if (this.IBMPGMBHHPP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IBMPGMBHHPP);
			}
			if (this.AEDDEMIGDGB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AEDDEMIGDGB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3CD RID: 50125 RVA: 0x0020D7CC File Offset: 0x0020B9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetRedPointStatusScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this.oMOKDOPAIHG_.Add(other.oMOKDOPAIHG_);
			if (other.IBMPGMBHHPP != 0U)
			{
				this.IBMPGMBHHPP = other.IBMPGMBHHPP;
			}
			if (other.AEDDEMIGDGB != 0U)
			{
				this.AEDDEMIGDGB = other.AEDDEMIGDGB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3CE RID: 50126 RVA: 0x0020D855 File Offset: 0x0020BA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3CF RID: 50127 RVA: 0x0020D860 File Offset: 0x0020BA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.IBMPGMBHHPP = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.AEDDEMIGDGB = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.oMOKDOPAIHG_.AddEntriesFrom(ref input, SetRedPointStatusScNotify._repeated_oMOKDOPAIHG_codec);
						continue;
					}
					if (num == 104U)
					{
						this.ContentId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F10 RID: 20240
		private static readonly MessageParser<SetRedPointStatusScNotify> _parser = new MessageParser<SetRedPointStatusScNotify>(() => new SetRedPointStatusScNotify());

		// Token: 0x04004F11 RID: 20241
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F12 RID: 20242
		public const int ContentIdFieldNumber = 13;

		// Token: 0x04004F13 RID: 20243
		private uint contentId_;

		// Token: 0x04004F14 RID: 20244
		public const int UidFieldNumber = 14;

		// Token: 0x04004F15 RID: 20245
		private uint uid_;

		// Token: 0x04004F16 RID: 20246
		public const int OMOKDOPAIHGFieldNumber = 6;

		// Token: 0x04004F17 RID: 20247
		private static readonly FieldCodec<DJPHMOJGKCO> _repeated_oMOKDOPAIHG_codec = FieldCodec.ForMessage<DJPHMOJGKCO>(50U, DJPHMOJGKCO.Parser);

		// Token: 0x04004F18 RID: 20248
		private readonly RepeatedField<DJPHMOJGKCO> oMOKDOPAIHG_ = new RepeatedField<DJPHMOJGKCO>();

		// Token: 0x04004F19 RID: 20249
		public const int IBMPGMBHHPPFieldNumber = 1;

		// Token: 0x04004F1A RID: 20250
		private uint iBMPGMBHHPP_;

		// Token: 0x04004F1B RID: 20251
		public const int AEDDEMIGDGBFieldNumber = 2;

		// Token: 0x04004F1C RID: 20252
		private uint aEDDEMIGDGB_;
	}
}
