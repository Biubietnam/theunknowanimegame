using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F3F RID: 3903
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMiracleInfo : IMessage<RogueMiracleInfo>, IMessage, IEquatable<RogueMiracleInfo>, IDeepCloneable<RogueMiracleInfo>, IBufferMessage
	{
		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0600AE2D RID: 44589 RVA: 0x001D47E7 File Offset: 0x001D29E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMiracleInfo> Parser
		{
			get
			{
				return RogueMiracleInfo._parser;
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0600AE2E RID: 44590 RVA: 0x001D47EE File Offset: 0x001D29EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMiracleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0600AE2F RID: 44591 RVA: 0x001D4800 File Offset: 0x001D2A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMiracleInfo.Descriptor;
			}
		}

		// Token: 0x0600AE30 RID: 44592 RVA: 0x001D4807 File Offset: 0x001D2A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleInfo()
		{
		}

		// Token: 0x0600AE31 RID: 44593 RVA: 0x001D481C File Offset: 0x001D2A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleInfo(RogueMiracleInfo other) : this()
		{
			this.eKNGCHDOKCK_ = other.eKNGCHDOKCK_;
			this.miracleList_ = other.miracleList_.Clone();
			this.pMPHNLLHKJD_ = other.pMPHNLLHKJD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE32 RID: 44594 RVA: 0x001D4869 File Offset: 0x001D2A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleInfo Clone()
		{
			return new RogueMiracleInfo(this);
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0600AE33 RID: 44595 RVA: 0x001D4871 File Offset: 0x001D2A71
		// (set) Token: 0x0600AE34 RID: 44596 RVA: 0x001D4879 File Offset: 0x001D2A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EKNGCHDOKCK
		{
			get
			{
				return this.eKNGCHDOKCK_;
			}
			set
			{
				this.eKNGCHDOKCK_ = value;
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0600AE35 RID: 44597 RVA: 0x001D4882 File Offset: 0x001D2A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMiracle> MiracleList
		{
			get
			{
				return this.miracleList_;
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0600AE36 RID: 44598 RVA: 0x001D488A File Offset: 0x001D2A8A
		// (set) Token: 0x0600AE37 RID: 44599 RVA: 0x001D4892 File Offset: 0x001D2A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PMPHNLLHKJD
		{
			get
			{
				return this.pMPHNLLHKJD_;
			}
			set
			{
				this.pMPHNLLHKJD_ = value;
			}
		}

		// Token: 0x0600AE38 RID: 44600 RVA: 0x001D489B File Offset: 0x001D2A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMiracleInfo);
		}

		// Token: 0x0600AE39 RID: 44601 RVA: 0x001D48AC File Offset: 0x001D2AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMiracleInfo other)
		{
			return other != null && (other == this || (this.EKNGCHDOKCK == other.EKNGCHDOKCK && this.miracleList_.Equals(other.miracleList_) && this.PMPHNLLHKJD == other.PMPHNLLHKJD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE3A RID: 44602 RVA: 0x001D490C File Offset: 0x001D2B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EKNGCHDOKCK != 0U)
			{
				num ^= this.EKNGCHDOKCK.GetHashCode();
			}
			num ^= this.miracleList_.GetHashCode();
			if (this.PMPHNLLHKJD != 0U)
			{
				num ^= this.PMPHNLLHKJD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE3B RID: 44603 RVA: 0x001D4972 File Offset: 0x001D2B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE3C RID: 44604 RVA: 0x001D497A File Offset: 0x001D2B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x001D4984 File Offset: 0x001D2B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PMPHNLLHKJD != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PMPHNLLHKJD);
			}
			this.miracleList_.WriteTo(ref output, RogueMiracleInfo._repeated_miracleList_codec);
			if (this.EKNGCHDOKCK != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EKNGCHDOKCK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x001D49F0 File Offset: 0x001D2BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EKNGCHDOKCK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EKNGCHDOKCK);
			}
			num += this.miracleList_.CalculateSize(RogueMiracleInfo._repeated_miracleList_codec);
			if (this.PMPHNLLHKJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PMPHNLLHKJD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE3F RID: 44607 RVA: 0x001D4A5C File Offset: 0x001D2C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMiracleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EKNGCHDOKCK != 0U)
			{
				this.EKNGCHDOKCK = other.EKNGCHDOKCK;
			}
			this.miracleList_.Add(other.miracleList_);
			if (other.PMPHNLLHKJD != 0U)
			{
				this.PMPHNLLHKJD = other.PMPHNLLHKJD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE40 RID: 44608 RVA: 0x001D4ABD File Offset: 0x001D2CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE41 RID: 44609 RVA: 0x001D4AC8 File Offset: 0x001D2CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 82U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EKNGCHDOKCK = input.ReadUInt32();
						}
					}
					else
					{
						this.miracleList_.AddEntriesFrom(ref input, RogueMiracleInfo._repeated_miracleList_codec);
					}
				}
				else
				{
					this.PMPHNLLHKJD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040046EB RID: 18155
		private static readonly MessageParser<RogueMiracleInfo> _parser = new MessageParser<RogueMiracleInfo>(() => new RogueMiracleInfo());

		// Token: 0x040046EC RID: 18156
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046ED RID: 18157
		public const int EKNGCHDOKCKFieldNumber = 14;

		// Token: 0x040046EE RID: 18158
		private uint eKNGCHDOKCK_;

		// Token: 0x040046EF RID: 18159
		public const int MiracleListFieldNumber = 10;

		// Token: 0x040046F0 RID: 18160
		private static readonly FieldCodec<RogueMiracle> _repeated_miracleList_codec = FieldCodec.ForMessage<RogueMiracle>(82U, RogueMiracle.Parser);

		// Token: 0x040046F1 RID: 18161
		private readonly RepeatedField<RogueMiracle> miracleList_ = new RepeatedField<RogueMiracle>();

		// Token: 0x040046F2 RID: 18162
		public const int PMPHNLLHKJDFieldNumber = 9;

		// Token: 0x040046F3 RID: 18163
		private uint pMPHNLLHKJD_;
	}
}
