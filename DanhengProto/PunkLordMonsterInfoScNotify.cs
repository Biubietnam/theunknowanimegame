using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D2B RID: 3371
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordMonsterInfoScNotify : IMessage<PunkLordMonsterInfoScNotify>, IMessage, IEquatable<PunkLordMonsterInfoScNotify>, IDeepCloneable<PunkLordMonsterInfoScNotify>, IBufferMessage
	{
		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0600968E RID: 38542 RVA: 0x00190A3C File Offset: 0x0018EC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordMonsterInfoScNotify> Parser
		{
			get
			{
				return PunkLordMonsterInfoScNotify._parser;
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x0600968F RID: 38543 RVA: 0x00190A43 File Offset: 0x0018EC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordMonsterInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x06009690 RID: 38544 RVA: 0x00190A55 File Offset: 0x0018EC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordMonsterInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06009691 RID: 38545 RVA: 0x00190A5C File Offset: 0x0018EC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterInfoScNotify()
		{
		}

		// Token: 0x06009692 RID: 38546 RVA: 0x00190A70 File Offset: 0x0018EC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterInfoScNotify(PunkLordMonsterInfoScNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
			this.fDDFAKGGPGF_ = other.fDDFAKGGPGF_.Clone();
			this.cDAJGLIIBII_ = ((other.cDAJGLIIBII_ != null) ? other.cDAJGLIIBII_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009693 RID: 38547 RVA: 0x00190AE9 File Offset: 0x0018ECE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterInfoScNotify Clone()
		{
			return new PunkLordMonsterInfoScNotify(this);
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x06009694 RID: 38548 RVA: 0x00190AF1 File Offset: 0x0018ECF1
		// (set) Token: 0x06009695 RID: 38549 RVA: 0x00190AF9 File Offset: 0x0018ECF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterInfoNotifyReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x06009696 RID: 38550 RVA: 0x00190B02 File Offset: 0x0018ED02
		// (set) Token: 0x06009697 RID: 38551 RVA: 0x00190B0A File Offset: 0x0018ED0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterBasicInfo BasicInfo
		{
			get
			{
				return this.basicInfo_;
			}
			set
			{
				this.basicInfo_ = value;
			}
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x06009698 RID: 38552 RVA: 0x00190B13 File Offset: 0x0018ED13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FDDFAKGGPGF
		{
			get
			{
				return this.fDDFAKGGPGF_;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x06009699 RID: 38553 RVA: 0x00190B1B File Offset: 0x0018ED1B
		// (set) Token: 0x0600969A RID: 38554 RVA: 0x00190B23 File Offset: 0x0018ED23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecord CDAJGLIIBII
		{
			get
			{
				return this.cDAJGLIIBII_;
			}
			set
			{
				this.cDAJGLIIBII_ = value;
			}
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x00190B2C File Offset: 0x0018ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordMonsterInfoScNotify);
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x00190B3C File Offset: 0x0018ED3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordMonsterInfoScNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && object.Equals(this.BasicInfo, other.BasicInfo) && this.fDDFAKGGPGF_.Equals(other.fDDFAKGGPGF_) && object.Equals(this.CDAJGLIIBII, other.CDAJGLIIBII) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x00190BB4 File Offset: 0x0018EDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != PunkLordMonsterInfoNotifyReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.basicInfo_ != null)
			{
				num ^= this.BasicInfo.GetHashCode();
			}
			num ^= this.fDDFAKGGPGF_.GetHashCode();
			if (this.cDAJGLIIBII_ != null)
			{
				num ^= this.CDAJGLIIBII.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x00190C33 File Offset: 0x0018EE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x00190C3B File Offset: 0x0018EE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x00190C44 File Offset: 0x0018EE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fDDFAKGGPGF_.WriteTo(ref output, PunkLordMonsterInfoScNotify._repeated_fDDFAKGGPGF_codec);
			if (this.cDAJGLIIBII_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CDAJGLIIBII);
			}
			if (this.Reason != PunkLordMonsterInfoNotifyReason.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Reason);
			}
			if (this.basicInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BasicInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x00190CCC File Offset: 0x0018EECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != PunkLordMonsterInfoNotifyReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.basicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BasicInfo);
			}
			num += this.fDDFAKGGPGF_.CalculateSize(PunkLordMonsterInfoScNotify._repeated_fDDFAKGGPGF_codec);
			if (this.cDAJGLIIBII_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CDAJGLIIBII);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x00190D50 File Offset: 0x0018EF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordMonsterInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != PunkLordMonsterInfoNotifyReason.None)
			{
				this.Reason = other.Reason;
			}
			if (other.basicInfo_ != null)
			{
				if (this.basicInfo_ == null)
				{
					this.BasicInfo = new PunkLordMonsterBasicInfo();
				}
				this.BasicInfo.MergeFrom(other.BasicInfo);
			}
			this.fDDFAKGGPGF_.Add(other.fDDFAKGGPGF_);
			if (other.cDAJGLIIBII_ != null)
			{
				if (this.cDAJGLIIBII_ == null)
				{
					this.CDAJGLIIBII = new PunkLordBattleRecord();
				}
				this.CDAJGLIIBII.MergeFrom(other.CDAJGLIIBII);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x00190DF5 File Offset: 0x0018EFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x00190E00 File Offset: 0x0018F000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.fDDFAKGGPGF_.AddEntriesFrom(ref input, PunkLordMonsterInfoScNotify._repeated_fDDFAKGGPGF_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.cDAJGLIIBII_ == null)
						{
							this.CDAJGLIIBII = new PunkLordBattleRecord();
						}
						input.ReadMessage(this.CDAJGLIIBII);
						continue;
					}
					if (num == 88U)
					{
						this.Reason = (PunkLordMonsterInfoNotifyReason)input.ReadEnum();
						continue;
					}
					if (num == 114U)
					{
						if (this.basicInfo_ == null)
						{
							this.BasicInfo = new PunkLordMonsterBasicInfo();
						}
						input.ReadMessage(this.BasicInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A6F RID: 14959
		private static readonly MessageParser<PunkLordMonsterInfoScNotify> _parser = new MessageParser<PunkLordMonsterInfoScNotify>(() => new PunkLordMonsterInfoScNotify());

		// Token: 0x04003A70 RID: 14960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A71 RID: 14961
		public const int ReasonFieldNumber = 11;

		// Token: 0x04003A72 RID: 14962
		private PunkLordMonsterInfoNotifyReason reason_;

		// Token: 0x04003A73 RID: 14963
		public const int BasicInfoFieldNumber = 14;

		// Token: 0x04003A74 RID: 14964
		private PunkLordMonsterBasicInfo basicInfo_;

		// Token: 0x04003A75 RID: 14965
		public const int FDDFAKGGPGFFieldNumber = 1;

		// Token: 0x04003A76 RID: 14966
		private static readonly FieldCodec<uint> _repeated_fDDFAKGGPGF_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04003A77 RID: 14967
		private readonly RepeatedField<uint> fDDFAKGGPGF_ = new RepeatedField<uint>();

		// Token: 0x04003A78 RID: 14968
		public const int CDAJGLIIBIIFieldNumber = 8;

		// Token: 0x04003A79 RID: 14969
		private PunkLordBattleRecord cDAJGLIIBII_;
	}
}
