using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CD7 RID: 3287
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnSignCsReq : IMessage<PlayerReturnSignCsReq>, IMessage, IEquatable<PlayerReturnSignCsReq>, IDeepCloneable<PlayerReturnSignCsReq>, IBufferMessage
	{
		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x0600929F RID: 37535 RVA: 0x00184D79 File Offset: 0x00182F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnSignCsReq> Parser
		{
			get
			{
				return PlayerReturnSignCsReq._parser;
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x060092A0 RID: 37536 RVA: 0x00184D80 File Offset: 0x00182F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnSignCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x060092A1 RID: 37537 RVA: 0x00184D92 File Offset: 0x00182F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnSignCsReq.Descriptor;
			}
		}

		// Token: 0x060092A2 RID: 37538 RVA: 0x00184D99 File Offset: 0x00182F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnSignCsReq()
		{
		}

		// Token: 0x060092A3 RID: 37539 RVA: 0x00184DAC File Offset: 0x00182FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnSignCsReq(PlayerReturnSignCsReq other) : this()
		{
			this.kABFEPDMFBH_ = other.kABFEPDMFBH_;
			this.nOFCPIPLKOI_ = other.nOFCPIPLKOI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092A4 RID: 37540 RVA: 0x00184DE2 File Offset: 0x00182FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnSignCsReq Clone()
		{
			return new PlayerReturnSignCsReq(this);
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x060092A5 RID: 37541 RVA: 0x00184DEA File Offset: 0x00182FEA
		// (set) Token: 0x060092A6 RID: 37542 RVA: 0x00184DF2 File Offset: 0x00182FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KABFEPDMFBH
		{
			get
			{
				return this.kABFEPDMFBH_;
			}
			set
			{
				this.kABFEPDMFBH_ = value;
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x060092A7 RID: 37543 RVA: 0x00184DFB File Offset: 0x00182FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NOFCPIPLKOI
		{
			get
			{
				return this.nOFCPIPLKOI_;
			}
		}

		// Token: 0x060092A8 RID: 37544 RVA: 0x00184E03 File Offset: 0x00183003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnSignCsReq);
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x00184E14 File Offset: 0x00183014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnSignCsReq other)
		{
			return other != null && (other == this || (this.KABFEPDMFBH == other.KABFEPDMFBH && this.nOFCPIPLKOI_.Equals(other.nOFCPIPLKOI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x00184E64 File Offset: 0x00183064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KABFEPDMFBH != 0U)
			{
				num ^= this.KABFEPDMFBH.GetHashCode();
			}
			num ^= this.nOFCPIPLKOI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x00184EB1 File Offset: 0x001830B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00184EB9 File Offset: 0x001830B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x00184EC4 File Offset: 0x001830C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KABFEPDMFBH != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.KABFEPDMFBH);
			}
			this.nOFCPIPLKOI_.WriteTo(ref output, PlayerReturnSignCsReq._repeated_nOFCPIPLKOI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x00184F14 File Offset: 0x00183114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KABFEPDMFBH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KABFEPDMFBH);
			}
			num += this.nOFCPIPLKOI_.CalculateSize(PlayerReturnSignCsReq._repeated_nOFCPIPLKOI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x00184F68 File Offset: 0x00183168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnSignCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KABFEPDMFBH != 0U)
			{
				this.KABFEPDMFBH = other.KABFEPDMFBH;
			}
			this.nOFCPIPLKOI_.Add(other.nOFCPIPLKOI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092B0 RID: 37552 RVA: 0x00184FB5 File Offset: 0x001831B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x00184FC0 File Offset: 0x001831C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 32U && num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.nOFCPIPLKOI_.AddEntriesFrom(ref input, PlayerReturnSignCsReq._repeated_nOFCPIPLKOI_codec);
					}
				}
				else
				{
					this.KABFEPDMFBH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400388F RID: 14479
		private static readonly MessageParser<PlayerReturnSignCsReq> _parser = new MessageParser<PlayerReturnSignCsReq>(() => new PlayerReturnSignCsReq());

		// Token: 0x04003890 RID: 14480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003891 RID: 14481
		public const int KABFEPDMFBHFieldNumber = 1;

		// Token: 0x04003892 RID: 14482
		private uint kABFEPDMFBH_;

		// Token: 0x04003893 RID: 14483
		public const int NOFCPIPLKOIFieldNumber = 4;

		// Token: 0x04003894 RID: 14484
		private static readonly FieldCodec<uint> _repeated_nOFCPIPLKOI_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04003895 RID: 14485
		private readonly RepeatedField<uint> nOFCPIPLKOI_ = new RepeatedField<uint>();
	}
}
